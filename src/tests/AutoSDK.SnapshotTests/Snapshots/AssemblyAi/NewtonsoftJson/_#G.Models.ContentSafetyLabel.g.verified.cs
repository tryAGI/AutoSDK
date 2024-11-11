//HintName: G.Models.ContentSafetyLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentSafetyLabel
    {
        /// <summary>
        /// The label of the sensitive topic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// The confidence score for the topic being discussed, from 0 to 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// How severely the topic is discussed in the section, from 0 to 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public double Severity { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSafetyLabel" /> class.
        /// </summary>
        /// <param name="label">
        /// The label of the sensitive topic
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the topic being discussed, from 0 to 1
        /// </param>
        /// <param name="severity">
        /// How severely the topic is discussed in the section, from 0 to 1
        /// </param>
        public ContentSafetyLabel(
            string label,
            double confidence,
            double severity)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Confidence = confidence;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSafetyLabel" /> class.
        /// </summary>
        public ContentSafetyLabel()
        {
        }
    }
}