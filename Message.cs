using Microsoft.AspNetCore.Identity;

namespace testchat.Models;

public class Contact
{
    public int Id { get; set; }

    public ICollection<IdentityUser>? UserObjs{ get; set; } // Mto1 Foreign Key
    
    public string? Friend { get; set; } // MtoM
    public string? Image { get; set; }
}
public class Message
{
    public int Id { get; set; }
    public ICollection<Contact>? ContactObjs { get; set; } // Mto1
    public string? Text { get; set; }
    public DateTime TimeStamp { get; set; }
}

public class ChatRoom
{
    public int Id { get; set; }
    public int ContactId { get; set; }
    public int MessageId { get; set; }
    public Contact? ContactObj { get; set; } // MtoM
    public Message? MessageObj { get; set; } // MtoM
}

public class Friend
{
    public int PersonOneId { get; set; }
    public int PersonTwoId { get; set; }
    public Contact? PersonOneObj { get; set; }
    public Contact? PersonTwoObj { get; set; }
}