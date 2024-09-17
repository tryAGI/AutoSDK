//HintName: G.Models.GetRemainingCreditResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetRemainingCreditResponse contains the remaining credit of a user or<br/>
    /// organization.
    /// </summary>
    public sealed partial class GetRemainingCreditResponse
    {
        /// <summary>
        /// Amount of perishable credit, i.e. credit with an expiration date.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("perishable")]
        public float? Perishable { get; set; }

        /// <summary>
        /// Amount of imperishable credit, e.g. purchased credit, which doesn't<br/>
        /// expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imperishable")]
        public float? Imperishable { get; set; }

        /// <summary>
        /// Total remaining credit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public float? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}