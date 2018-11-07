using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DragRecordsXDG
{
    public static class EmployeeData
    {
        public static BindingList<Employee> GenerateEmployeeData()
        {
            BindingList<Employee> employees = new BindingList<Employee>();

            employees.Add(new Employee("John Smith",
                                                    new DateTime(1967, 6, 1),
                                                    new Uri(@"People/Guy01.jpg", UriKind.RelativeOrAbsolute),
                                                    "Human Resources",
                                                    52500.00M,
                                                    "(712) 555-9899",
                                                    "(214) 555-7222",
                                                    "7655 5th Avenue",
                                                    "Apt 3B",
                                                    "Teaneck",
                                                    "NJ",
                                                    "15772",
                                                    "john@hotmail.com"));

            employees.Add(new Employee("Mary Hernandez",
                                                    new DateTime(1975, 7, 23),
                                                    new Uri(@"People/Girl01.jpg", UriKind.RelativeOrAbsolute),
                                                    "Sales",
                                                    65100.00M,
                                                    "(612) 555-1234",
                                                    "(612) 555-8775",
                                                    "776 Maple Avenue",
                                                    "",
                                                    "Lido",
                                                    "CA",
                                                    "99837",
                                                    "MaryH@hotmail.com"));


            employees.Add(new Employee("Barbara Bailey",
                                                    new DateTime(1996, 1, 15),
                                                    new Uri(@"People/Girl02.jpg", UriKind.RelativeOrAbsolute),
                                                    "Admin",
                                                    35750.00M,
                                                    "(512) 555-3899",
                                                    "(512) 555-2221",
                                                    "12 Larkfield Court",
                                                    "Suite 206",
                                                    "Chicago",
                                                    "IL",
                                                    "45883",
                                                    "BB@hotmail.com"));


            employees.Add(new Employee("Margaret Jones",
                                                    new DateTime(1999, 11, 1),
                                                    new Uri(@"People/Girl03.jpg", UriKind.RelativeOrAbsolute),
                                                    "Admin",
                                                    37750.00M,
                                                    "(512) 555-7776",
                                                    "(512) 555-2351",
                                                    "144 Main Street",
                                                    "",
                                                    "Chicago",
                                                    "IL",
                                                    "45883",
                                                    "MargeJ@hotmail.com"));


            employees.Add(new Employee("Bobby Jones",
                                                    new DateTime(2003, 9, 1),
                                                    new Uri(@"People/Guy02.jpg", UriKind.RelativeOrAbsolute),
                                                    "Accounting",
                                                    53250.00M,
                                                    "(212) 555-1727",
                                                    "(212) 555-9938",
                                                    "3166 72nd Street",
                                                    "Apt 229",
                                                    "New York",
                                                    "NY",
                                                    "01992",
                                                    "BobbyJ@hotmail.com"));


            employees.Add(new Employee("Jonathan Barclay",
                                                    new DateTime(1990, 4, 15),
                                                    new Uri(@"People/Guy03.jpg", UriKind.RelativeOrAbsolute),
                                                    "Board Of Directors",
                                                    123000.00M,
                                                    "(212) 555-1199",
                                                    "(212) 555-9911",
                                                    "219 Park Avenue",
                                                    "3rd Floor",
                                                    "New York",
                                                    "NY",
                                                    "02887",
                                                    "JonathanB@hotmail.com"));


            employees.Add(new Employee("Martha Beckinsale",
                                                    new DateTime(1989, 5, 25),
                                                    new Uri(@"People/Girl04.jpg", UriKind.RelativeOrAbsolute),
                                                    "Sales",
                                                    99700.00M,
                                                    "(213) 555-8837",
                                                    "(213) 555-1009",
                                                    "12 Sepulveda Blvd",
                                                    "Suite 5",
                                                    "Los Angeles",
                                                    "CA",
                                                    "98772",
                                                    "MarthaB@hotmail.com"));


            employees.Add(new Employee("Kate Shannon",
                                                    new DateTime(1985, 12, 21),
                                                    new Uri(@"People/Girl20.jpg", UriKind.RelativeOrAbsolute),
                                                    "Sales",
                                                    69000.00M,
                                                    "(213) 555-8837",
                                                    "(213) 555-1009",
                                                    "53 Dark Canyon Road",
                                                    "2nd floor",
                                                    "Santa Barbara",
                                                    "CA",
                                                    "99112",
                                                    "KateS@hotmail.com"));


            employees.Add(new Employee("Maggie Smithfield",
                                                    new DateTime(1983, 10, 1),
                                                    new Uri(@"People/Girl06.jpg", UriKind.RelativeOrAbsolute),
                                                    "Human Resources",
                                                    41000.00M,
                                                    "(533) 555-8837",
                                                    "(533) 555-1424",
                                                    "33 Palm Court",
                                                    "",
                                                    "Saint Augustine",
                                                    "Fl",
                                                    "34211",
                                                    "MaggieS@hotmail.com"));


            //employees.Add(new Employee("Bradley Swinford",
            //                                        new DateTime(1991, 6, 8),
            //                                        new Uri(@"People/Guy04.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Development",
            //                                        85500.00M,
            //                                        "(516) 555-2111",
            //                                        "(516) 555-9887",
            //                                        "355 Old Country Road",
            //                                        "Suite 6",
            //                                        "Dix Hills",
            //                                        "NY",
            //                                        "11677",
            //                                        "BradS@hotmail.com"));


            //employees.Add(new Employee("Derek Hardstone",
            //                                        new DateTime(1996, 2, 28),
            //                                        new Uri(@"People/Guy05.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Testing",
            //                                        50500.00M,
            //                                        "(211) 555-4983",
            //                                        "(211) 555-8275",
            //                                        "1199 Silver Bluff Way",
            //                                        "",
            //                                        "Denver",
            //                                        "CO",
            //                                        "76625",
            //                                        "DerekH@hotmail.com"));


            //employees.Add(new Employee("Melissa Allman",
            //                                        new DateTime(1969, 7, 18),
            //                                        new Uri(@"People/Girl07.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Sales",
            //                                        73600.00M,
            //                                        "(545) 555-2938",
            //                                        "(545) 555-6645",
            //                                        "2233 Red Rock Road",
            //                                        "Suite 77",
            //                                        "Austin",
            //                                        "TX",
            //                                        "65534",
            //                                        "MelissaA@hotmail.com"));


            //employees.Add(new Employee("Terence Starchedpants",
            //                                        new DateTime(1983, 8, 11),
            //                                        new Uri(@"People/Guy06.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Accounting",
            //                                        53700.00M,
            //                                        "(301) 555-1000",
            //                                        "(301) 555-0990",
            //                                        "2773 Easton Way",
            //                                        "Apt 8H",
            //                                        "Seattle",
            //                                        "WA",
            //                                        "98006",
            //                                        "TerenceS@hotmail.com"));


            //employees.Add(new Employee("Ashley Fabray",
            //                                        new DateTime(1990, 3, 8),
            //                                        new Uri(@"People/Girl08.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Human Resources",
            //                                        43000.00M,
            //                                        "(515) 555-3321",
            //                                        "(515) 555-1123",
            //                                        "93888 East Main Street",
            //                                        "2nd Floor",
            //                                        "Racine",
            //                                        "WI",
            //                                        "50082",
            //                                        "AshleyF@hotmail.com"));


            //employees.Add(new Employee("Randall Carruthers",
            //                                        new DateTime(2004, 4, 9),
            //                                        new Uri(@"People/Guy07.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Sales",
            //                                        89700.00M,
            //                                        "(201) 555-1100",
            //                                        "(201) 555-8870",
            //                                        "37 Fairfield Court",
            //                                        "Apt 1",
            //                                        "Holmdel",
            //                                        "NJ",
            //                                        "19882",
            //                                        "RandallC@hotmail.com"));


            //employees.Add(new Employee("Jake Swanson",
            //                                        new DateTime(1967, 6, 1),
            //                                        new Uri(@"People/Guy08.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Human Resources",
            //                                        52500.00M,
            //                                        "(712) 555-9837",
            //                                        "(214) 555-7222",
            //                                        "7655 5th Avenue",
            //                                        "Apt 3B",
            //                                        "Teaneck",
            //                                        "NJ",
            //                                        "15772",
            //                                        "jakeswan@hotmail.com"));


            //employees.Add(new Employee("Melissa Harvay",
            //                                        new DateTime(1975, 7, 23),
            //                                        new Uri(@"People/Girl09.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Sales",
            //                                        65100.00M,
            //                                        "(612) 555-1234",
            //                                        "(612) 555-8775",
            //                                        "776 Maple Avenue",
            //                                        "",
            //                                        "Lido",
            //                                        "CA",
            //                                        "99837",
            //                                        "MelissaH@hotmail.com"));


            //employees.Add(new Employee("Elizabeth Baker",
            //                                        new DateTime(1996, 1, 15),
            //                                        new Uri(@"People/Girl10.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Admin",
            //                                        35750.00M,
            //                                        "(512) 555-3899",
            //                                        "(512) 555-2221",
            //                                        "12 Larkfield Court",
            //                                        "Suite 206",
            //                                        "Chicago",
            //                                        "IL",
            //                                        "45883",
            //                                        "LizBaker@hotmail.com"));


            //employees.Add(new Employee("Alice Simpson",
            //                                        new DateTime(1999, 11, 1),
            //                                        new Uri(@"People/Girl11.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Admin",
            //                                        37750.00M,
            //                                        "(512) 555-7776",
            //                                        "(512) 555-2351",
            //                                        "144 Main Street",
            //                                        "",
            //                                        "Chicago",
            //                                        "IL",
            //                                        "45883",
            //                                        "AliceS@hotmail.com"));


            //employees.Add(new Employee("Fred Thompson",
            //                                        new DateTime(2003, 9, 1),
            //                                        new Uri(@"People/Guy09.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Accounting",
            //                                        53250.00M,
            //                                        "(212) 555-1727",
            //                                        "(212) 555-9938",
            //                                        "3166 72nd Street",
            //                                        "Apt 229",
            //                                        "New York",
            //                                        "NY",
            //                                        "01992",
            //                                        "FreddieT@hotmail.com"));


            //employees.Add(new Employee("Pete Stevens",
            //                                        new DateTime(1990, 4, 15),
            //                                        new Uri(@"People/Guy10.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Board Of Directors",
            //                                        123000.00M,
            //                                        "(212) 555-1199",
            //                                        "(212) 555-9911",
            //                                        "219 Park Avenue",
            //                                        "3rd Floor",
            //                                        "New York",
            //                                        "NY",
            //                                        "02887",
            //                                        "PeteMoss@hotmail.com"));


            //employees.Add(new Employee("Jane Meadows",
            //                                        new DateTime(1989, 5, 25),
            //                                        new Uri(@"People/Girl12.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Sales",
            //                                        99700.00M,
            //                                        "(213) 555-8837",
            //                                        "(213) 555-1009",
            //                                        "12 Sepulveda Blvd",
            //                                        "Suite 5",
            //                                        "Los Angeles",
            //                                        "CA",
            //                                        "98772",
            //                                        "AudreysSister@hotmail.com"));


            //employees.Add(new Employee("Sally Dougherty",
            //                                        new DateTime(1985, 12, 21),
            //                                        new Uri(@"People/Girl13.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Sales",
            //                                        69000.00M,
            //                                        "(213) 555-8837",
            //                                        "(213) 555-1009",
            //                                        "53 Dark Canyon Road",
            //                                        "2nd floor",
            //                                        "Santa Barbara",
            //                                        "CA",
            //                                        "99112",
            //                                        "SallyDoh@hotmail.com"));


            //employees.Add(new Employee("Susan Springfield",
            //                                        new DateTime(1983, 10, 1),
            //                                        new Uri(@"People/Girl14.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Human Resources",
            //                                        41000.00M,
            //                                        "(533) 555-8837",
            //                                        "(533) 555-1424",
            //                                        "33 Palm Court",
            //                                        "",
            //                                        "Saint Augustine",
            //                                        "Fl",
            //                                        "34211",
            //                                        "SusieS@hotmail.com"));


            //employees.Add(new Employee("Joseph Breckinrich",
            //                                        new DateTime(1991, 6, 8),
            //                                        new Uri(@"People/Guy11.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Development",
            //                                        85500.00M,
            //                                        "(516) 555-2111",
            //                                        "(516) 555-9887",
            //                                        "355 Old Country Road",
            //                                        "Suite 6",
            //                                        "Dix Hills",
            //                                        "NY",
            //                                        "11677",
            //                                        "JoeBreck@hotmail.com"));


            //employees.Add(new Employee("David Cooper",
            //                                        new DateTime(1996, 2, 28),
            //                                        new Uri(@"People/Guy12.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Testing",
            //                                        50500.00M,
            //                                        "(211) 555-4983",
            //                                        "(211) 555-8275",
            //                                        "1199 Silver Bluff Way",
            //                                        "",
            //                                        "Denver",
            //                                        "CO",
            //                                        "76625",
            //                                        "DavidCoop@hotmail.com"));


            //employees.Add(new Employee("Janine Falstaff",
            //                                        new DateTime(1969, 7, 18),
            //                                        new Uri(@"People/Girl15.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Sales",
            //                                        73600.00M,
            //                                        "(545) 555-2938",
            //                                        "(545) 555-6645",
            //                                        "2233 Red Rock Road",
            //                                        "Suite 77",
            //                                        "Austin",
            //                                        "TX",
            //                                        "65534",
            //                                        "JFalstaff@hotmail.com"));


            //employees.Add(new Employee("Toby Gillis",
            //                                        new DateTime(1983, 8, 11),
            //                                        new Uri(@"People/Guy13.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Accounting",
            //                                        53700.00M,
            //                                        "(301) 555-1000",
            //                                        "(301) 555-0990",
            //                                        "2773 Easton Way",
            //                                        "Apt 8H",
            //                                        "Seattle",
            //                                        "WA",
            //                                        "98006",
            //                                        "TobyNotDobie@hotmail.com"));


            //employees.Add(new Employee("Margaret Douglas",
            //                                        new DateTime(1990, 3, 8),
            //                                        new Uri(@"People/Girl16.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Human Resources",
            //                                        43000.00M,
            //                                        "(515) 555-3321",
            //                                        "(515) 555-1123",
            //                                        "93888 East Main Street",
            //                                        "2nd Floor",
            //                                        "Racine",
            //                                        "WI",
            //                                        "50082",
            //                                        "MargieD@hotmail.com"));

            //employees.Add(new Employee("Soupy Sales",
            //                                        new DateTime(2004, 4, 9),
            //                                        new Uri(@"People/Guy14.jpg", UriKind.RelativeOrAbsolute),
            //                                        "Sales",
            //                                        89700.00M,
            //                                        "(201) 555-1100",
            //                                        "(201) 555-8870",
            //                                        "37 Fairfield Court",
            //                                        "Apt 1",
            //                                        "Holmdel",
            //                                        "NJ",
            //                                        "19882",
            //                                        "SoupyS@hotmail.com"));




            return employees;
        }
    }
}
