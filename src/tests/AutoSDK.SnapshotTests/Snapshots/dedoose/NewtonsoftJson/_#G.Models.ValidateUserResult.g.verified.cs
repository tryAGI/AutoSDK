//HintName: G.Models.ValidateUserResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidateUserResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userData")]
        public global::G.User2? UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isFederated")]
        public bool? IsFederated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountIdleTimeout")]
        public int? AccountIdleTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountRequire2Factor")]
        public bool? AccountRequire2Factor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountRequire2FactorOnRelog")]
        public bool? AccountRequire2FactorOnRelog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isValidated")]
        public bool? IsValidated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUserResult" /> class.
        /// </summary>
        /// <param name="userData"></param>
        /// <param name="isFederated"></param>
        /// <param name="accountIdleTimeout"></param>
        /// <param name="accountRequire2Factor"></param>
        /// <param name="accountRequire2FactorOnRelog"></param>
        /// <param name="isValidated"></param>
        public ValidateUserResult(
            global::G.User2? userData,
            bool? isFederated,
            int? accountIdleTimeout,
            bool? accountRequire2Factor,
            bool? accountRequire2FactorOnRelog,
            bool? isValidated)
        {
            this.UserData = userData;
            this.IsFederated = isFederated;
            this.AccountIdleTimeout = accountIdleTimeout;
            this.AccountRequire2Factor = accountRequire2Factor;
            this.AccountRequire2FactorOnRelog = accountRequire2FactorOnRelog;
            this.IsValidated = isValidated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUserResult" /> class.
        /// </summary>
        public ValidateUserResult()
        {
        }
    }
}