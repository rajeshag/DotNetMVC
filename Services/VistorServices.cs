using System.Text.Json;

public class VistorServices : IVistor
{ 
    public static class Event
    {
        public const string Approved = "approved";
        public const string Reject = "Reject";
    }

    public string entry(Vistor vistor)
    {
        /**
            Write DB saving code.
            After saving success return the same object as json string.
        **/
        return JsonSerializer.Serialize(vistor);
    }

    public string delete(Vistor vistor)
    {
        throw new NotImplementedException();
    }

    public string edit(Vistor vistor)
    {
        return JsonSerializer.Serialize(vistor);
    }

    public string fetch(Vistor vistor)
    {
        throw new NotImplementedException();
    }

    public string sendMail(Vistor vistor)
    {
        /**
            Write the mailing code here

        **/
        return "Mail sent successfuly";
    }
}