<Query Kind="Program">
  <Connection>
    <ID>46a93a35-55b6-4b49-ae31-764d123ceb56</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

void Main()
{
	////from person in Customers
	////select person
	//from purchase in Invoices
	//where purchase.BillingAddress != purchase.Customer.Address
	//select purchase
	// Assuming that we know the customer id, that would be part of our query
	int customerId = 1;
	var profile = from person in Customers
	              where person.CustomerId == customerId
	              select new CustomerProfile()
	{
		FirstName = person.FirstName,
		LastName = person.LastName,
		CompanyName = person.Company,
		StreetAddress = person.Address,
		City = person.City,
		State = person.State,
		Country = person.Country,
		PostalCode = person.PostalCode
	};
	profile.Dump();
	
}

// Define other methods and classes here
public class CustomerProfile
{
	public string FirstName {get;set;}
	public string LastName {get;set;}
	public string CompanyName {get;set;}
	public string StreetAddress {get;set;}
	public string City {get;set;}
	public string State {get;set;}
	public string Country {get;set;}
	public string PostalCode {get;set;}
}