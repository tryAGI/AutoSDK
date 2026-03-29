//HintName: G.Models.ClassifyV2Result.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of classifying a document.
    /// </summary>
    public sealed partial class ClassifyV2Result
    {
        /// <summary>
        /// Why the document matched (or didn't match) the returned rule
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reasoning { get; set; } = default!;

        /// <summary>
        /// Confidence score between 0.0 and 1.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Matched rule type, or null if no rule matched
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2Result" /> class.
        /// </summary>
        /// <param name="reasoning">
        /// Why the document matched (or didn't match) the returned rule
        /// </param>
        /// <param name="confidence">
        /// Confidence score between 0.0 and 1.0
        /// </param>
        /// <param name="type">
        /// Matched rule type, or null if no rule matched
        /// </param>
        public ClassifyV2Result(
            string reasoning,
            double confidence,
            string? type)
        {
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Confidence = confidence;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2Result" /> class.
        /// </summary>
        public ClassifyV2Result()
        {
        }
    }
}