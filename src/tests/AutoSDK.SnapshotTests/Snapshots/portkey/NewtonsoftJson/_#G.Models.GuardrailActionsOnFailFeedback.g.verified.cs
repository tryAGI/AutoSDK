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
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Weight of the feedback<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double Weight { get; set; } = default!;

        /// <summary>
        /// Additional metadata for the feedback
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public string Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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