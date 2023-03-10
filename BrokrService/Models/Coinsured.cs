namespace BrokrService.Models
{
    public class CoInsured
    {
        private int _Id;

        private string _PolicyNumber;

        private string _InsuredId;

        private string _UserId;

        private string _Company;

        private string _UnderwritingYear;

        private string _Flag;

        private string _IsLeading;

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public string PolicyNumber
        {
            get
            {
                return _PolicyNumber;
            }
            set
            {
                _PolicyNumber = value?.Trim();
            }
        }

        public string InsuredId
        {
            get
            {
                return _InsuredId;
            }
            set
            {
                _InsuredId = value?.Trim();
            }
        }

        public string UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }

        public string Company
        {
            get
            {
                return _Company;
            }
            set
            {
                _Company = value?.Trim();
            }
        }

        public string UnderwritingYear
        {
            get
            {
                return _UnderwritingYear;
            }
            set
            {
                _UnderwritingYear = value?.Trim();
            }
        }

        public string Flag
        {
            get
            {
                return _Flag;
            }
            set
            {
                _Flag = value?.Trim();
            }
        }

        public decimal Commission { get; set; }

        public DateTime KeyDate { get; set; }

        public string IsLeading
        {
            get
            {
                return _IsLeading;
            }
            set
            {
                _IsLeading = value?.Trim();
            }
        }

        public decimal Orc { get; set; }

        public decimal OrcAmount { get; set; }

        public decimal OriginalPremium { get; set; }

        public decimal OriginalSumInsured { get; set; }

        public decimal PremiumAmount { get; set; }

        public decimal PremiumPortion { get; set; }

        public decimal SumInsuredAmount { get; set; }
    }

}
