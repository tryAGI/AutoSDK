//HintName: G.Models.GetRemainingCreditAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetRemainingCreditAdminResponse contains the remaining credit of a user or<br/>
    /// organization.
    /// </summary>
    public sealed partial class GetRemainingCreditAdminResponse
    {
        /// <summary>
        /// The requested credit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount")]
        public float Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}