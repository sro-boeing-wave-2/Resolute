using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ticket_management.Models
{
    public enum Status
{
    open, close, due
}
    public class Ticket
{
    int ticketId;
    string subject;
    string description;
    int agentid;
    int departmentid;
    string source;
    string priority;
    Status status;
    int sla;
    List<Comments> comment;
    List<Conversation> conversation;
    DateTime createdOn;
    String createdBy;
    DateTime updatedOn;
    int userid;
    int customerid;
    string updatedBy;
    [Key]
    public int TicketId { get => ticketId; set => ticketId = value; }
    public string Subject { get => subject; set => subject = value; }
    public string Description { get => description; set => description = value; }
    public string Source { get => source; set => source = value; }
    public string Priority { get => priority; set => priority = value; }
    public Status Status { get => status; set => status = value; }
    public int Sla { get => sla; set => sla = value; }
    public List<Comments> Comment { get => comment; set => comment = value; }
    public List<Conversation> Conversation { get => conversation; set => conversation = value; }
    public DateTime CreatedOn { get => createdOn; set => createdOn = value; }
    public string CreatedBy { get => createdBy; set => createdBy = value; }
    public DateTime UpdatedOn { get => updatedOn; set => updatedOn = value; }
    public string UpdatedBy { get => updatedBy; set => updatedBy = value; }
    public int Agentid { get => agentid; set => agentid = value; }
    public int Departmentid { get => departmentid; set => departmentid = value; }
    public int Userid { get => userid; set => userid = value; }
    public int Customerid { get => customerid; set => customerid = value; }
}

}
