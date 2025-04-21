import React, { useState } from "react";
import LeadCard from "./LeadCard";

const LeadList = () => {
  const [leads, setLeads] = useState([
    {
      id: 5577421,
      name: "Bill",
      date: "January 4 @ 2:37 pm",
      suburb: "Yanderra 2574",
      category: "Painters",
      description: "Need to paint 2 aluminum windows and a sliding glass door",
      price: 62.0,
      status: "invited",
    },
    {
      id: 5588872,
      name: "Craig",
      date: "January 4 @ 1:15 pm",
      suburb: "Woolooware 2230",
      category: "Interior Painters",
      description: "Internal walls 3 colours",
      price: 49.0,
      status: "invited",
    },
  ]);

  const handleAccept = (lead) => {
    const updatedLeads = leads.map((l) =>
      l.id === lead.id
        ? { ...l, status: "accepted", price: l.price > 500 ? l.price * 0.9 : l.price }
        : l
    );
    setLeads(updatedLeads);
    console.log(`Lead ${lead.name} aceito!`);
  };

  const handleDecline = (lead) => {
    const updatedLeads = leads.map((l) =>
      l.id === lead.id ? { ...l, status: "declined" } : l
    );
    setLeads(updatedLeads);
    console.log(`Lead ${lead.name} recusado!`);
  };

  return (
    <div className="max-w-2xl mx-auto mt-8">
      <h2 className="text-2xl font-bold text-gray-700 mb-4">Invited Leads</h2>
      {leads
        .filter((lead) => lead.status === "invited")
        .map((lead) => (
          <LeadCard
            key={lead.id}
            lead={lead}
            onAccept={handleAccept}
            onDecline={handleDecline}
          />
        ))}
    </div>
  );
};

export default LeadList;