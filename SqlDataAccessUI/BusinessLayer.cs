using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SqlDataAccessUI.Helper;

namespace SqlDataAccessUI
{
    public class BusinessLayer
    {
        public List<Person> GetPeopleByLastName(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.GetConStringValue("SqlDataAccess")))
            {
                //Sql injection is not a good practice
                //return connection.Query<Person>($"select * from People where LastName = '{LastName}'").ToList();
                
                //Dapper mathces up sql data with Person object properties and puts each of them in a list for us
                return connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();

            //new { } -> new class instance which does not exist(C# magic), a dynamic class
            //this class has a property called LastName, which must be named same with stored procedure parameter
            //method parameter lastName will be is being passed in to dynamic class property
            //then this property LastName is being passed in to stored procedure parameter LastName by dapper
            }
        }

        public void InsertPeople(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.GetConStringValue("SqlDataAccess")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });
                connection.Execute("dbo.Insert_People @FirstName,@LastName,@EmailAddress,@PhoneNumber", people);
            }
        }
    }
}