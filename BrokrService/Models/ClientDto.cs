namespace BrokrService.Models
{
    public class StandardResponse <T> where T : class
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
    public class CreateClientModelResponse
    {
        public string ClientNo { get; set; }
    }
    public class ClientDto
    {
        //public string Id { get; set; }
        //public string DisplayName { get; set; }    
        //public string InsuredName { get; set; }   
        //public string Address { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Email { get; set; }
        //public string Occupation { get; set;}
        //public string TypeOfInsured { get; set; }
        //public string BVN { get; set; }
        //public DateTime DateOfBirth { get; set; } = DateTime.Now;
        //public string Gender { get; set; }
        //public string StateOfBusisness { get; set; }
        //public string LgaBusinessLocation { get; set; }
        //public string CountryBusinessLocation { get; set;}
        //public string IsCustomerPEP { get; set; }
        //public string Justification { get; set; }
        //public double RiskScale { get; set; }

       
            private string _InsuredName;

            private string _OtherNames;

            private string _Address;

            private string _Address2;

            private string _AgentTelNumber;

            private string _MobileNo;

            private string _Occupation;

            private string _Email;

            private string _TypeOfInsured;

            private string _Bvn;

            private string _Gender;

            private string _StateBusinessLocation;

            private string _LgaBusinessLocation;

            private string _CountryBusinessLocation;

            private string _IsCustomerPEP;

            private string _Justification;

            public string InsuredName
            {
                get
                {
                    return _InsuredName;
                }
                set
                {
                    _InsuredName = value?.Trim();
                }
            }

            public string OtherNames
            {
                get
                {
                    return _OtherNames;
                }
                set
                {
                    _OtherNames = value?.Trim();
                }
            }

            public string Address
            {
                get
                {
                    return _Address;
                }
                set
                {
                    _Address = value?.Trim();
                }
            }

            public string Address2
            {
                get
                {
                    return _Address2;
                }
                set
                {
                    _Address2 = value?.Trim();
                }
            }

            public string AgentTelNumber
            {
                get
                {
                    return _AgentTelNumber;
                }
                set
                {
                    _AgentTelNumber = value?.Trim();
                }
            }

            public string MobileNo
            {
                get
                {
                    return _MobileNo;
                }
                set
                {
                    _MobileNo = value?.Trim();
                }
            }

            public string Occupation
            {
                get
                {
                    return _Occupation;
                }
                set
                {
                    _Occupation = value?.Trim();
                }
            }

            public string Email
            {
                get
                {
                    return _Email;
                }
                set
                {
                    _Email = value?.Trim();
                }
            }

            public string TypeOfInsured
            {
                get
                {
                    return _TypeOfInsured;
                }
                set
                {
                    _TypeOfInsured = value?.Trim();
                }
            }

            public string Bvn
            {
                get
                {
                    return _Bvn;
                }
                set
                {
                    _Bvn = value?.Trim();
                }
            }

            public DateTime DateOfBirth { get; set; }

            public string Gender
            {
                get
                {
                    return _Gender;
                }
                set
                {
                    _Gender = value?.Trim();
                }
            }

            public string StateBusinessLocation
            {
                get
                {
                    return _StateBusinessLocation;
                }
                set
                {
                    _StateBusinessLocation = value?.Trim();
                }
            }

            public string LgaBusinessLocation
            {
                get
                {
                    return _LgaBusinessLocation;
                }
                set
                {
                    _LgaBusinessLocation = value?.Trim();
                }
            }

            public string CountryBusinessLocation
            {
                get
                {
                    return _CountryBusinessLocation;
                }
                set
                {
                    _CountryBusinessLocation = value?.Trim();
                }
            }

            public string IsCustomerPEP
            {
                get
                {
                    return _IsCustomerPEP;
                }
                set
                {
                    _IsCustomerPEP = value?.Trim();
                }
            }

            public string Justification
            {
                get
                {
                    return _Justification;
                }
                set
                {
                    _Justification = value?.Trim();
                }
            }

            public int RiskScale { get; set; }
        }
    }


