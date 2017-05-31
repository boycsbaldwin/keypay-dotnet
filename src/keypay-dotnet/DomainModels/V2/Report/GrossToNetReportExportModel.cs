using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Report
{
    public class GrossToNetReportExportModel
    {
        public GrossToNetReportExportModel()
        {
            GrossEarnings = new Dictionary<string, decimal>();
            PreTaxDeductions = new Dictionary<string, decimal>();
            PostTaxDeductions = new Dictionary<string, decimal>();
            Expenses = new Dictionary<string, decimal>();
        }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int PrimaryLocationId { get; set; }
        public string PrimaryLocation { get; set; }
        public string ExternalId { get; set; }
        public decimal TotalHours { get; set; }
        public Dictionary<string, decimal> GrossEarnings { get; set; }
        public decimal TotalGrossEarnings { get; set; }
        public decimal TotalTaxExemptEarnings { get; set; }
        public Dictionary<string, decimal> PreTaxDeductions { get; set; }
        public decimal TotalPreTaxDeductions { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal Payg { get; set; }
        public decimal Sfss { get; set; }
        public decimal Help { get; set; }
        public Dictionary<string, decimal> PostTaxDeductions { get; set; }
        public decimal TotalPostTaxDeductions { get; set; }
        public decimal NetEarnings { get; set; }
        public Dictionary<string, decimal> Expenses { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal BankPayments { get; set; }
        public decimal Sgc { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal TotalGrossPlusSuper { get; set; }

    }
}