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
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcePolicy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnforcePolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireChar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireChar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireUpper")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireUpper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireSymbol")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireSymbol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAgeInDays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxAgeInDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require2Auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Require2Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relogin2Auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Relogin2Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idleTimeoutInMinutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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