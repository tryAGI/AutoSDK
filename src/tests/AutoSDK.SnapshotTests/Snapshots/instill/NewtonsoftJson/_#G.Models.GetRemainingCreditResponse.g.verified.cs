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
        /// Amount of perishable credit, i.e. credit with an expiration date.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("perishable")]
        public float? Perishable { get; set; }

        /// <summary>
        /// Amount of imperishable credit, e.g. purchased credit, which doesn't<br/>
        /// expire.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imperishable")]
        public float? Imperishable { get; set; }

        /// <summary>
        /// Total remaining credit.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public float? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRemainingCreditResponse" /> class.
        /// </summary>
        /// <param name="perishable">
        /// Amount of perishable credit, i.e. credit with an expiration date.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="imperishable">
        /// Amount of imperishable credit, e.g. purchased credit, which doesn't<br/>
        /// expire.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="total">
        /// Total remaining credit.<br/>
        /// Included only in responses
        /// </param>
        public GetRemainingCreditResponse(
            float? perishable,
            float? imperishable,
            float? total)
        {
            this.Perishable = perishable;
            this.Imperishable = imperishable;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRemainingCreditResponse" /> class.
        /// </summary>
        public GetRemainingCreditResponse()
        {
        }
    }
}