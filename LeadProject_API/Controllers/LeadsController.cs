using LeadManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static LeadProject_API.Enum.EnumLead;

namespace LeadManagementAPI.Controllers
{
    [ApiController]
    [Route("api/leads")]
    public class LeadsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LeadsController(ApplicationDbContext context) => _context = context;

        [HttpGet("{status}")]
        public async Task<IActionResult> GetLeads(string status)
        {
            if (!Enum.TryParse(status, true, out LeadStatus leadStatus))
                return BadRequest("Status inválido.");

            var leads = await _context.Leads
                .Where(l => l.Status == leadStatus)
                .ToListAsync();

            return Ok(leads);
        }

        [HttpPost("accept/{id}")]
        public async Task<IActionResult> AcceptLead(int id)
        {
            var lead = await _context.Leads.FindAsync(id);
            if (lead == null) return NotFound();

            lead.Status = LeadStatus.Accepted;

            if (lead.Price > 500) lead.Price *= 0.9M;

            await _context.SaveChangesAsync();
            return Ok(lead);
        }

        [HttpPost("decline/{id}")]
        public async Task<IActionResult> DeclineLead(int id)
        {
            var lead = await _context.Leads.FindAsync(id);
            if (lead == null) return NotFound();

            lead.Status = LeadStatus.Declined;

            await _context.SaveChangesAsync();
            return Ok(lead);
        }
    }
}
