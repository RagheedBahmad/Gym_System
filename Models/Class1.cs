

namespace Models;

public class Customers {
    public int Id { get; set; }
    public String Name { get; set; }
    public DateTime ExpiryDate { get; set; }
    public List<Subscriptions> subscriptions { get; set; }
}

public class Subscriptions
{
    
}