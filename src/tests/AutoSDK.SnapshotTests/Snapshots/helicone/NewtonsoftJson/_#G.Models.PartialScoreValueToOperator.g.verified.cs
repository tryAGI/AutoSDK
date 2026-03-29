//HintName: G.Models.PartialScoreValueToOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialScoreValueToOperator
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public global::G.PartialTextOperators? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialScoreValueToOperator" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Make all properties in T optional
        /// </param>
        public PartialScoreValueToOperator(
            global::G.PartialTextOperators? requestId)
        {
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialScoreValueToOperator" /> class.
        /// </summary>
        public PartialScoreValueToOperator()
        {
        }
    }
}