//HintName: G.Models.UpdateAccountPWPolicyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAccountPWPolicyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforcePolicy", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnforcePolicy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minLength", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinLength { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requireChar", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireChar { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requireUpper", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireUpper { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requireNumber", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requireSymbol", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireSymbol { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxAgeInDays", Required = global::Newtonsoft.Json.Required.Always)]
        public double MaxAgeInDays { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require2Auth", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Require2Auth { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relogin2Auth", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Relogin2Auth { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idleTimeoutInMinutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int IdleTimeoutInMinutes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountPWPolicyRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="enforcePolicy"></param>
        /// <param name="minLength"></param>
        /// <param name="requireChar"></param>
        /// <param name="requireUpper"></param>
        /// <param name="requireNumber"></param>
        /// <param name="requireSymbol"></param>
        /// <param name="maxAgeInDays"></param>
        /// <param name="require2Auth"></param>
        /// <param name="relogin2Auth"></param>
        /// <param name="idleTimeoutInMinutes"></param>
        public UpdateAccountPWPolicyRequest(
            global::System.Guid accountId,
            bool enforcePolicy,
            int minLength,
            bool requireChar,
            bool requireUpper,
            bool requireNumber,
            bool requireSymbol,
            double maxAgeInDays,
            bool require2Auth,
            bool relogin2Auth,
            int idleTimeoutInMinutes)
        {
            this.AccountId = accountId;
            this.EnforcePolicy = enforcePolicy;
            this.MinLength = minLength;
            this.RequireChar = requireChar;
            this.RequireUpper = requireUpper;
            this.RequireNumber = requireNumber;
            this.RequireSymbol = requireSymbol;
            this.MaxAgeInDays = maxAgeInDays;
            this.Require2Auth = require2Auth;
            this.Relogin2Auth = relogin2Auth;
            this.IdleTimeoutInMinutes = idleTimeoutInMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountPWPolicyRequest" /> class.
        /// </summary>
        public UpdateAccountPWPolicyRequest()
        {
        }
    }
}