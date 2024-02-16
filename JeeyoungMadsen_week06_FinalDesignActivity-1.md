Date: 2/15/2024
Class: CSE 210 
Professor : Vaughn Poulson
Student: Jeeyoung Madsen

Final Project - Design Activity

1. Foundation-1 (Abstraction)
    Program.cs
    Video.cs : _title : string, _author : string, _length : string
            _comments : List<string>

            GetDisplayInfo : void
            GetcommentCount 

    Comment.cs : _name : string, _text : string

            ToString() : string

2. Foundation-2 (Encapsulation)
    Program.cs
    Product.cs : _name : string, _productID : string, _price : double,
              _quantity : int

              TotalCost() : double
              GetProductLabel() : string

    Order.cs : _customer : Customer, _products : List<string>

                TotalCost() : double
                GetShippingCost() : double
                GetPackingLabel() : string
                GetShippingLabel() : string
                AddProduct() : void

    Customer.cs : _name : string, _address : Address

                InUSA() : bool
                GetCustomerDetails() : string

    Address.cs : _street : string, _city : string, _state : string,
                _country : string

                IsUSA() : bool
                GetAddressDetails() : string

3. Foundation-3 (Inheritance)
    Program.cs
    Address.cs : _street : string, _city : string, _state : string, 
                _country : string

                GetAddressDetails() : string
    
    Lectures.cs : _speaker : string, _capacity : int

                GetEventType() : string
                GetFullDetails() : string
                GetSpecificDetails() : string

    Receptions.cs : _email : string

                GetEventType() : string
                GetFullDetails() : string
                GetSpecficDetails() : string

    Outdoorgatherings.cs : _weather : string

                GetEventType() : string
                GetFullDetails() : string
                GetSpecficDetails() : string

    Events.cs : _title : string, _description : string, _date : string,
                _time : string, _address : Address

                GetFullDetails() : string
                GetEventType() : string
                GetShortDescription() : string

4. Foundation-4 (Polymorphism)
    Program.cs
    Activity.cs : _date : DataTime, _minutes : int

                GetDistance() : double
                GetSpeed() : double
                GetPace() : double
                GetSummary() : string

    Running.cs : _distance : double, _distance : double

                GetDistance() : double
                GetSpeed() : double
                GetPace() : double
                GetSummary() : string

    Cycling.cs : _speed : double

                GetSpeed() : double
                GetPace() : double
                GetSummary() : string

    Swimming.cs : _laps : int

                GetDistance() : double
                GetSpeed() : double
                GetPace() : double
                GetSummary() : string




