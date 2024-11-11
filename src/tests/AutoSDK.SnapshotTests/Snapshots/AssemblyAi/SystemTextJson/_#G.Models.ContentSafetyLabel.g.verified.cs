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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The confidence score for the topic being discussed, from 0 to 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// How severely the topic is discussed in the section, from 0 to 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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