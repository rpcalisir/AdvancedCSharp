using System;

namespace InterfaceAndAbstract.Abstract
{
    public interface IEntity
    {
        DateTime DateOfBirth { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string NationalityId { get; set; }
    }
}