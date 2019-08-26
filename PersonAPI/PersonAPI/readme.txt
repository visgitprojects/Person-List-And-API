**Notes About Project :**
I did DB first approach with the entity framework.  However to initially create the db and seed it with data for someone new running the program I use the 
**DropCreateDatabaseAlways initializer** in the personmodel.context.cs.  To leave the data and db alone after initial run the user can just comment out the initialize call.

I piggy backed off the ado.net entity framework generated PersonalModel.Context.cs to do this.  So **if a user regenerates or updates the .edmx from the database
it will regenerate it and lose the initialization code**. 
     *public PersonEntities(): base("name=PersonEntities")
        {
                 //will drop and create new db and seed
                Database.SetInitializer(new PersonDBInitializer());

            
        }
		
        public virtual DbSet<Person> People { get; set; }
        public class PersonDBInitializer : DropCreateDatabaseAlways<PersonEntities>
        {
            protected override void Seed(PersonEntities context)
            {
                IList<Person> defaultStandards = new List<Person>();

                defaultStandards.Add(new Person() { LastName = "Davolio", FirstName = "Nancy", Age = 39, Address = "507 - 20th Ave. E.Apt. 2A", City = "Seattle", PostalCode = "98122", Interests = "coffee", PhotoPath = "https://images.pexels.com/photos/60883/girl-eyes-makeup-sexy-60883.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });
                defaultStandards.Add(new Person() { LastName = "Fuller", FirstName = "Andrew", Age = 21, Address = "908 W. Capital Way", City = "Tacoma", PostalCode = "98401", Interests = "donuts", PhotoPath = "https://images.pexels.com/photos/37547/suit-business-man-business-man-37547.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });
                defaultStandards.Add(new Person() { LastName = "Leverling", FirstName = "Janet", Age = 38, Address = "722 Moss Bay Blvd.", City = "Kirkland", PostalCode = "98033", Interests = "dolls", PhotoPath = "https://images.pexels.com/photos/157622/woman-bench-stand-by-blonde-157622.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });
                defaultStandards.Add(new Person() { LastName = "Peacock", FirstName = "Margaret", Age = 25, Address = "4110 Old Redmond Rd.", City = "Redmond", PostalCode = "98052", Interests = "race cars", PhotoPath = "https://images.pexels.com/photos/17840/pexels-photo.jpg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });
                defaultStandards.Add(new Person() { LastName = "Buchanan", FirstName = "Steven", Age = 30, Address = "14 Garrett Hill", City = "London", PostalCode = "SW1 8JR", Interests = "programming", PhotoPath = "https://images.pexels.com/photos/193355/pexels-photo-193355.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });
                defaultStandards.Add(new Person() { LastName = "Suyama", FirstName = "Michael", Age = 19, Address = "Coventry House Miner Rd.", City = "London", PostalCode = "EC2 7JR", Interests = "literature", PhotoPath = "https://images.pexels.com/photos/936043/pexels-photo-936043.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });
                defaultStandards.Add(new Person() { LastName = "King", FirstName = "Robert", Age = 15, Address = "Edgeham Hollow Winchester Way", City = "London", PostalCode = "RG1 9SP", Interests = "pokemon", PhotoPath = "https://images.pexels.com/photos/160933/girl-rabbit-friendship-love-160933.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });
                defaultStandards.Add(new Person() { LastName = "Callahan", FirstName = "Laura", Age = 55, Address = "4726 - 11th Ave. N.E.", City = "Seattle", PostalCode = "98105", Interests = "pizza", PhotoPath = "https://images.pexels.com/photos/2712468/pexels-photo-2712468.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });
                defaultStandards.Add(new Person() { LastName = "Dodsworth", FirstName = "Anne", Age = 72, Address = "7 Houndstooth Rd.", City = "London", PostalCode = "WG2 7LT", Interests = "bad decisions", PhotoPath = "https://images.pexels.com/photos/2838056/pexels-photo-2838056.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" });

                context.People.AddRange(defaultStandards);
                base.Seed(context);

            }
        }*
**Be sure to update the connections in the connection string to relevant server info**
* <connectionStrings>
    <add name="PersonEntities" connectionString="metadata=res://*/Models.PersonModel.csdl|res://*/Models.PersonModel.ssdl|res://*/Models.PersonModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=volslaptop\sqlexpress;initial catalog=VioletsInterviewTestDB;user id=netdbuser;password=netdbuser;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
    <add name="PersonContext" connectionString="Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PersonAPIContext-20190824194917; Integrated Security=True; MultipleActiveResultSets=True; AttachDbFilename=|DataDirectory|PersonContext-20190824194917.mdf" providerName="System.Data.SqlClient" />
</connectionStrings>*
To complete the installation of System.Web.Optimization.React, you need to create one or more
bundles containing your JSX files:

// In BundleConfig.cs
bundles.Add(new BabelBundle("~/bundles/main").Include(
    // Add your JSX files here
    "~/Content/HelloWorld.react.jsx",
    "~/Content/AnythingElse.react.jsx",
    // You can include regular JavaScript files in the bundle too
    "~/Content/ajax.js",
));

Please refer to http://reactjs.net/ for more details, usage examples and sample code.


