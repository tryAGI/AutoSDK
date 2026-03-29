//HintName: G.Models.GuardrailActionsOnFailFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feedback configuration for failed checks
    /// </summary>
    public sealed partial class GuardrailActionsOnFailFeedback
    {
        /// <summary>
        /// Feedback value for failed checks<br/>
        /// Default Value: -5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Weight of the feedback<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Weight { get; set; }

        /// <summary>
        /// Additional metadata for the feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActionsOnFailFeedback" /> class.
        /// </summary>
        /// <param name="value">
        /// Feedback value for failed checks<br/>
        /// Default Value: -5
        /// </param>
        /// <param name="weight">
        /// Weight of the feedback<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the feedback
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailActionsOnFailFeedback(
            double value,
            double weight,
            string metadata)
        {
            this.Value = value;
            this.Weight = weight;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActionsOnFailFeedback" /> class.
        /// </summary>
        public GuardrailActionsOnFailFeedback()
        {
        }
    }
}