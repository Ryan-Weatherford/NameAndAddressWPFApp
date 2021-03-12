using System;
using System.Collections.Generic;
using System.Text;

namespace NameAndAddressLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel Address { get; set; } = new AddressModel();
        public string FullAddress => $@"{Address.Street}
{Address.City}, {Address.State}  {Address.ZipCode}";



    }
}
