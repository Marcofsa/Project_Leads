import { FaMapMarkerAlt, FaBriefcase, FaEnvelope, FaPhone } from "react-icons/fa";

const LeadCard = ({ lead, onAccept, onDecline, status }) => {
    return (
        <div className="bg-white border rounded-lg shadow-md p-4 mb-4">
            <div className="flex items-center gap-4">
                <div className="w-12 h-12 flex items-center justify-center bg-gray-300 rounded-full text-lg font-bold text-white">
                    {lead.firstName.charAt(0).toUpperCase()}
                </div>
                <div>
                    <h3 className="text-lg font-bold">{status === "invited" ? lead.firstName : lead.fullName}</h3>
                    <p className="text-gray-500">{lead.dateCreated}</p>
                </div>
            </div>
            <div className="mt-2 text-gray-700">
                <p className="flex items-center gap-2"><FaMapMarkerAlt /> {lead.suburb}</p>
                <p className="flex items-center gap-2"><FaBriefcase /> {lead.category} - Job ID: {lead.id}</p>
                <p className="mt-2">{lead.description}</p>
                <p className="text-lg font-bold mt-2">${lead.price.toFixed(2)} Lead Invitation</p>
            </div>
            {status === "accepted" && (
                <div className="mt-2 text-gray-700">
                    <p className="flex items-center gap-2 text-orange-600"><FaPhone /> {lead.phoneNumber}</p>
                    <p className="flex items-center gap-2 text-blue-600"><FaEnvelope /> {lead.email}</p>
                </div>
            )}
            {status === "invited" && (
                <div className="flex gap-2 mt-4">
                    <button onClick={() => onAccept(lead.id)} className="bg-orange-500 text-white p-2 rounded-lg">Accept</button>
                    <button onClick={() => onDecline(lead.id)} className="bg-gray-300 text-gray-700 p-2 rounded-lg">Decline</button>
                </div>
            )}
        </div>
    );
};

export default LeadCard;