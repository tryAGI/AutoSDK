//HintName: G.Models.UserAccountVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserAccountVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPastDue")]
        public bool? IsPastDue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDisabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId")]
        public global::System.Guid? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountUserCount")]
        public int? AccountUserCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountCPUPM")]
        public double? AccountCPUPM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentBalance")]
        public double? CurrentBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastPaymentDate")]
        public global::System.DateTime? LastPaymentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastPastDueNoticeDate")]
        public global::System.DateTime? LastPastDueNoticeDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastPaymentAmmount")]
        public double? LastPaymentAmmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPastLateGracePeriod")]
        public bool? IsPastLateGracePeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountVO" /> class.
        /// </summary>
        /// <param name="isPastDue"></param>
        /// <param name="isDisabled"></param>
        /// <param name="accountId"></param>
        /// <param name="accountUserCount"></param>
        /// <param name="accountCPUPM"></param>
        /// <param name="currentBalance"></param>
        /// <param name="lastPaymentDate"></param>
        /// <param name="lastPastDueNoticeDate"></param>
        /// <param name="lastPaymentAmmount"></param>
        /// <param name="isPastLateGracePeriod"></param>
        public UserAccountVO(
            bool? isPastDue,
            bool? isDisabled,
            global::System.Guid? accountId,
            int? accountUserCount,
            double? accountCPUPM,
            double? currentBalance,
            global::System.DateTime? lastPaymentDate,
            global::System.DateTime? lastPastDueNoticeDate,
            double? lastPaymentAmmount,
            bool? isPastLateGracePeriod)
        {
            this.IsPastDue = isPastDue;
            this.IsDisabled = isDisabled;
            this.AccountId = accountId;
            this.AccountUserCount = accountUserCount;
            this.AccountCPUPM = accountCPUPM;
            this.CurrentBalance = currentBalance;
            this.LastPaymentDate = lastPaymentDate;
            this.LastPastDueNoticeDate = lastPastDueNoticeDate;
            this.LastPaymentAmmount = lastPaymentAmmount;
            this.IsPastLateGracePeriod = isPastLateGracePeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountVO" /> class.
        /// </summary>
        public UserAccountVO()
        {
        }
    }
}