namespace BrokrService.Models
{

    public record PolicyDto
    {
       
        private string _Branch;

        private string _PolicySource;

        private string _DocumentType;

        private string _DocumentSerial;

        private string _TenderNo;

        private string _BusinessType;

        private string _PolicyType;

        private string _DocumentNo;

        private DateTime _IssuedDate;

        private DateTime _EffectiveDate;

        private DateTime _ExpiryDate;

        private string _PeriodNotes;

        private string _UwYear;

        private string _Renewal;

        private string _PaymentCycle;

        private decimal _ExRate;

        private DateTime _FinanceDate;

        private string _Insured;

        private string _InsuredNationality;

        private string _AdditionalInsureds;

        private string _CustomerType;

        private string _Beneficiary;

        private string _AgentRefNo;

        private string _AgentType;

        private string _AccountedFor;

        private string _CalculationBase;

        private string _CreditNote;

        private string _DocumentNote;

        private string _DocumentNumber;

        private string _RenewalNote;

        private decimal _MinPremium;

        private string _Attachments;

        private string _OfficeName;

        private decimal _CommissionLC;

        private decimal _SumInsuredLC;

        private decimal _OsPremiumLC;

        private decimal _TotalFeesLC;

        private decimal _TopLocation;

        private decimal _TopLocationSI;

        private string _InsuredBusiness;

        private decimal? _OsCommission;

        private decimal? _GrossPremiumLC;

        private decimal? _NetPremium;

        private string _PolicyOfficer;

        private string _PaymentMode;

        private string _Unit;

        private string _RenewalType;

        private string _PolicyStatus;

        private string _Country;

        private string _State;

        private string _Lga;

        private string _MainRisk;

        private string _SubRisk;

        private string _CoverType;

        private string _ParentDocument;

        private string _BusinessChannel;

        private decimal _OsPremium;

        private decimal _OsCommissionLC;

        private string _Description;

        private decimal _OriginSI;

        private string _CreatedBy;

        private DateTime _CreationDate;

        private string _ModifiedBy;

        private DateTime _ModificationDate;

        private decimal _BranchExRate;

        private int _InterestCount;

        private string _SalesType;

        private string _FrontingPolicy;

        private string _TenderNumber;

        private string _Flag;

        private string _LocNumber;

        private string _InsuredNumber;

        private string _RegistrationNumber;

        private int _CoverPeriod;

        private string _Signature;

        private string _PostType;

        private string _PolicyId;

        private string _CurrencyType;

        public int PolicyNo { get; set; }
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

        public string LocNumber
        {
            get
            {
                return _LocNumber;
            }
            set
            {
                _LocNumber = value?.Trim();
            }
        }

        public string InsuredNumber
        {
            get
            {
                return _InsuredNumber;
            }
            set
            {
                _InsuredNumber = value?.Trim();
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return _RegistrationNumber;
            }
            set
            {
                _RegistrationNumber = value?.Trim();
            }
        }

        public int BatchNumber
        {
            get;
            set;
        }

        public int CoverPeriod
        {
            get
            {
                return _CoverPeriod;
            }
            set
            {
                _CoverPeriod = value;
            }
        }

        public string Signature
        {
            get
            {
                return _Signature;
            }
            set
            {
                _Signature = value?.Trim();
            }
        }

        public DateTime? RenewalStartDate
        {
            get;
            set;
        }

        public string PostType
        {
            get
            {
                return _PostType;
            }
            set
            {
                _PostType = value?.Trim();
            }
        }

        public DateTime? RenewalEndDate
        {
            get;
            set;
        }

        public string PolicyId
        {
            get
            {
                return _PolicyId;
            }
            set
            {
                _PolicyId = value?.Trim();
            }
        }

        public string Branch
        {
            get
            {
                return _Branch;
            }
            set
            {
                _Branch = value?.Trim();
            }
        }

        public string PolicySource
        {
            get
            {
                return _PolicySource;
            }
            set
            {
                _PolicySource = value?.Trim();
            }
        }

        public string DocumentType
        {
            get
            {
                return _DocumentType;
            }
            set
            {
                _DocumentType = value?.Trim();
            }
        }

        public string DocumentSerial
        {
            get
            {
                return _DocumentSerial;
            }
            set
            {
                _DocumentSerial = value?.Trim();
            }
        }

        public string TenderNumber
        {
            get
            {
                return _TenderNumber;
            }
            set
            {
                _TenderNumber = value?.Trim();
            }
        }

        public string BusinessType
        {
            get
            {
                return _BusinessType;
            }
            set
            {
                _BusinessType = value?.Trim();
            }
        }

        public string PolicyType
        {
            get
            {
                return _PolicyType;
            }
            set
            {
                _PolicyType = value?.Trim();
            }
        }

        public string DocumentNumber
        {
            get
            {
                return _DocumentNumber;
            }
            set
            {
                _DocumentNumber = value?.Trim();
            }
        }

        public DateTime IssuedDate
        {
            get
            {
                return _IssuedDate;
            }
            set
            {
                _IssuedDate = value;
            }
        }

        public DateTime EffectiveDate
        {
            get
            {
                return _EffectiveDate;
            }
            set
            {
                _EffectiveDate = value;
            }
        }

        public DateTime ExpiryDate
        {
            get
            {
                return _ExpiryDate;
            }
            set
            {
                _ExpiryDate = value;
            }
        }

        public string PeriodNotes
        {
            get
            {
                return _PeriodNotes;
            }
            set
            {
                _PeriodNotes = value?.Trim();
            }
        }

        public string UwYear
        {
            get
            {
                return _UwYear.ToString();
            }
            set
            {
                _UwYear = value.ToString();
            }
        }

        public string Renewal
        {
            get
            {
                return _Renewal;
            }
            set
            {
                _Renewal = value?.Trim();
            }
        }

        public string PaymentCycle
        {
            get
            {
                return _PaymentCycle;
            }
            set
            {
                _PaymentCycle = value?.Trim();
            }
        }

        public decimal ExRate
        {
            get
            {
                return _ExRate;
            }
            set
            {
                _ExRate = value;
            }
        }

        public DateTime FinanceDate
        {
            get
            {
                return _FinanceDate;
            }
            set
            {
                _FinanceDate = value;
            }
        }

        public string Insured
        {
            get
            {
                return _Insured;
            }
            set
            {
                _Insured = value?.Trim();
            }
        }

        public string InsuredNationality
        {
            get
            {
                return _InsuredNationality;
            }
            set
            {
                _InsuredNationality = value?.Trim();
            }
        }

        public string AdditionalInsureds
        {
            get
            {
                return _AdditionalInsureds;
            }
            set
            {
                _AdditionalInsureds = value?.Trim();
            }
        }

        public string CustomerType
        {
            get
            {
                return _CustomerType;
            }
            set
            {
                _CustomerType = value?.Trim();
            }
        }

        public string Beneficiary
        {
            get
            {
                return _Beneficiary;
            }
            set
            {
                _Beneficiary = value?.Trim();
            }
        }

        public string AgentRefNo
        {
            get
            {
                return _AgentRefNo;
            }
            set
            {
                _AgentRefNo = value?.Trim();
            }
        }

        public string AgentType
        {
            get
            {
                return _AgentType;
            }
            set
            {
                _AgentType = value?.Trim();
            }
        }

        public string AccountedFor
        {
            get
            {
                return _AccountedFor;
            }
            set
            {
                _AccountedFor = value?.Trim();
            }
        }

        public string CalculationBase
        {
            get
            {
                return _CalculationBase;
            }
            set
            {
                _CalculationBase = value?.Trim();
            }
        }

        public string CreditNote
        {
            get
            {
                return _CreditNote;
            }
            set
            {
                _CreditNote = value?.Trim();
            }
        }

        public string DocumentNote
        {
            get
            {
                return _DocumentNote;
            }
            set
            {
                _DocumentNote = value?.Trim();
            }
        }

        public string RenewalNote
        {
            get
            {
                return _RenewalNote;
            }
            set
            {
                _RenewalNote = value?.Trim();
            }
        }

        public decimal MinPremium
        {
            get
            {
                return _MinPremium;
            }
            set
            {
                _MinPremium = value;
            }
        }

        public string Attachments
        {
            get
            {
                return _Attachments;
            }
            set
            {
                _Attachments = value?.Trim();
            }
        }

        public string OfficeName
        {
            get
            {
                return _OfficeName;
            }
            set
            {
                _OfficeName = value?.Trim();
            }
        }

        public decimal CommissionLC
        {
            get;
            set;
        }

        public decimal SumInsuredLC
        {
            get
            {
                return _SumInsuredLC;
            }
            set
            {
                _SumInsuredLC = value;
            }
        }

        public decimal OsPremiumLC
        {
            get
            {
                return _OsPremiumLC;
            }
            set
            {
                _OsPremiumLC = value;
            }
        }

        public decimal TotalFeesLC
        {
            get
            {
                return _TotalFeesLC;
            }
            set
            {
                _TotalFeesLC = value;
            }
        }

        public decimal TopLocation
        {
            get
            {
                return _TopLocation;
            }
            set
            {
                _TopLocation = value;
            }
        }

        public decimal TopLocationSI
        {
            get
            {
                return _TopLocationSI;
            }
            set
            {
                _TopLocationSI = value;
            }
        }

        public string InsuredBusiness
        {
            get
            {
                return _InsuredBusiness;
            }
            set
            {
                _InsuredBusiness = value?.Trim();
            }
        }

        public decimal? OsCommission
        {
            get
            {
                return _OsCommission;
            }
            set
            {
                _OsCommission = value;
            }
        }

        public decimal? GrossPremiumLC
        {
            get
            {
                return _GrossPremiumLC;
            }
            set
            {
                _GrossPremiumLC = value;
            }
        }

        public decimal? NetPremium
        {
            get
            {
                return _NetPremium;
            }
            set
            {
                _NetPremium = value;
            }
        }

        public string PolicyOfficer
        {
            get
            {
                return _PolicyOfficer;
            }
            set
            {
                _PolicyOfficer = value?.Trim();
            }
        }

        public string PaymentMode
        {
            get
            {
                return _PaymentMode;
            }
            set
            {
                _PaymentMode = value?.Trim();
            }
        }

        public string Unit
        {
            get
            {
                return _Unit;
            }
            set
            {
                _Unit = value?.Trim();
            }
        }

        public string RenewalType
        {
            get
            {
                return _RenewalType;
            }
            set
            {
                _RenewalType = value?.Trim();
            }
        }

        public string PolicyStatus
        {
            get
            {
                return _PolicyStatus;
            }
            set
            {
                _PolicyStatus = value?.Trim();
            }
        }

        public string Country
        {
            get
            {
                return _Country;
            }
            set
            {
                _Country = value?.Trim();
            }
        }

        public string State
        {
            get
            {
                return _State;
            }
            set
            {
                _State = value?.Trim();
            }
        }

        public string Lga
        {
            get
            {
                return _Lga;
            }
            set
            {
                _Lga = value?.Trim();
            }
        }

        public string MainRisk
        {
            get
            {
                return _MainRisk;
            }
            set
            {
                _MainRisk = value?.Trim();
            }
        }

        public string SubRisk
        {
            get
            {
                return _SubRisk;
            }
            set
            {
                _SubRisk = value?.Trim();
            }
        }

        public string CoverType
        {
            get
            {
                return _CoverType;
            }
            set
            {
                _CoverType = value?.Trim();
            }
        }

        public string ParentDocument
        {
            get
            {
                return _ParentDocument;
            }
            set
            {
                _ParentDocument = value?.Trim();
            }
        }

        public string BusinessChannel
        {
            get
            {
                return _BusinessChannel;
            }
            set
            {
                _BusinessChannel = value?.Trim();
            }
        }

        public decimal OsPremium
        {
            get
            {
                return _OsPremium;
            }
            set
            {
                _OsPremium = value;
            }
        }

        public decimal OsCommissionLC
        {
            get
            {
                return _OsCommissionLC;
            }
            set
            {
                _OsCommissionLC = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value?.Trim();
            }
        }

        public decimal OriginSI
        {
            get
            {
                return _OriginSI;
            }
            set
            {
                _OriginSI = value;
            }
        }

        public string CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                _CreatedBy = value?.Trim();
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                _CreationDate = value;
            }
        }

        public string ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }
            set
            {
                _ModifiedBy = value?.Trim();
            }
        }

        public DateTime ModificationDate
        {
            get
            {
                return _ModificationDate;
            }
            set
            {
                _ModificationDate = value;
            }
        }

        public int NoOfDays
        {
            get;
            set;
        }

        public decimal BranchExRate
        {
            get
            {
                return _BranchExRate;
            }
            set
            {
                _BranchExRate = value;
            }
        }

        public string CurrencyType
        {
            get
            {
                return _CurrencyType;
            }
            set
            {
                _CurrencyType = value?.Trim();
            }
        }

        public int InterestCount
        {
            get
            {
                return _InterestCount;
            }
            set
            {
                _InterestCount = value;
            }
        }

        public string SalesType
        {
            get
            {
                return _SalesType;
            }
            set
            {
                _SalesType = value?.Trim();
            }
        }

        public string FrontingPolicy
        {
            get
            {
                return _FrontingPolicy;
            }
            set
            {
                _FrontingPolicy = value?.Trim();
            }
        }

        public decimal AgencyRate
        {
            get;
            set;
        }

        public string PhoneNumber { get; set; }

        public string NaicomId { get; set; }

        public ClientDto clientDto { get; set; }

        public IList<CoInsured> CoInsuredLists
        {
            get;
            set;
        }
    }
}


