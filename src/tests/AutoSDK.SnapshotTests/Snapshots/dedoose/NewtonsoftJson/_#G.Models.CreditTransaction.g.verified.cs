﻿//HintName: G.Models.CreditTransaction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditTransaction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId")]
        public global::System.Guid? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditDate")]
        public global::System.DateTime? CreditDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDebit")]
        public bool? IsDebit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prevBal")]
        public double? PrevBal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remBal")]
        public double? RemBal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memo")]
        public string? Memo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditTransaction" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accountId"></param>
        /// <param name="creditDate"></param>
        /// <param name="amount"></param>
        /// <param name="isDebit"></param>
        /// <param name="prevBal"></param>
        /// <param name="remBal"></param>
        /// <param name="memo"></param>
        public CreditTransaction(
            global::System.Guid? id,
            global::System.Guid? accountId,
            global::System.DateTime? creditDate,
            double? amount,
            bool? isDebit,
            double? prevBal,
            double? remBal,
            string? memo)
        {
            this.Id = id;
            this.AccountId = accountId;
            this.CreditDate = creditDate;
            this.Amount = amount;
            this.IsDebit = isDebit;
            this.PrevBal = prevBal;
            this.RemBal = remBal;
            this.Memo = memo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditTransaction" /> class.
        /// </summary>
        public CreditTransaction()
        {
        }
    }
}