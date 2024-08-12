using System.ComponentModel.DataAnnotations;

namespace fiap_5nett_tech.Application.DataTransfer.Request
{
    public class ContactRequestAll
    {
        private string? _name;
        private string? _email;
        private string? _phoneNumber;
        private int? _ddd;

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email ?? ""; }
            set { _email = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber ?? ""; }
            set { _phoneNumber = value; }
        }

        public int Ddd
        {
            get { return _ddd ?? 0; }
            set { _ddd = value; }
        }
    }

}
