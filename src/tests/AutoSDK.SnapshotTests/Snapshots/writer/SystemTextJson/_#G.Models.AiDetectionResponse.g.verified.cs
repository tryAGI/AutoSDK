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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AiDetectionResponseLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AiDetectionResponseLabel Label { get; set; }

        /// <summary>
        /// Example: 0.6265060305595398
        /// </summary>
        /// <example>0.6265060305595398</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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