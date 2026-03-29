//HintName: G.Models.ControlTagWeight.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Weights configuration for a single control tag.<br/>
    /// Structure: {"overall": 0.5, "type": "Choices", "labels": {"cat": 1.0, "dog": 0.0}}
    /// </summary>
    public sealed partial class ControlTagWeight
    {
        /// <summary>
        /// Per-label weights (0.0 to 1.0). Zero excludes the label from agreement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, double>? Labels { get; set; }

        /// <summary>
        /// Overall weight for this control tag (0.0 to 1.0). Zero excludes the tag from agreement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Overall { get; set; }

        /// <summary>
        /// Control tag type from the labeling config (e.g. Choices, Labels, TextArea).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlTagWeight" /> class.
        /// </summary>
        /// <param name="overall">
        /// Overall weight for this control tag (0.0 to 1.0). Zero excludes the tag from agreement.
        /// </param>
        /// <param name="type">
        /// Control tag type from the labeling config (e.g. Choices, Labels, TextArea).
        /// </param>
        /// <param name="labels">
        /// Per-label weights (0.0 to 1.0). Zero excludes the label from agreement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ControlTagWeight(
            double overall,
            string type,
            global::System.Collections.Generic.Dictionary<string, double>? labels)
        {
            this.Labels = labels;
            this.Overall = overall;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlTagWeight" /> class.
        /// </summary>
        public ControlTagWeight()
        {
        }
    }
}