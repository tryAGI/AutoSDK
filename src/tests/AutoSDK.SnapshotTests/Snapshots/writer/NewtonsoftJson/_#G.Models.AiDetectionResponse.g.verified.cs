//HintName: G.Models.AiDetectionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiDetectionResponse
    {
        /// <summary>
        /// Example: fake
        /// </summary>
        /// <example>fake</example>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AiDetectionResponseLabelJsonConverter))]
        public global::G.AiDetectionResponseLabel Label { get; set; } = default!;

        /// <summary>
        /// Example: 0.6265060305595398
        /// </summary>
        /// <example>0.6265060305595398</example>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiDetectionResponse" /> class.
        /// </summary>
        /// <param name="label">
        /// Example: fake
        /// </param>
        /// <param name="score">
        /// Example: 0.6265060305595398
        /// </param>
        public AiDetectionResponse(
            global::G.AiDetectionResponseLabel label,
            double score)
        {
            this.Label = label;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiDetectionResponse" /> class.
        /// </summary>
        public AiDetectionResponse()
        {
        }
    }
}