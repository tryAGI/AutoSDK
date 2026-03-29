//HintName: G.Models.FeedbackUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackUpdateRequest
    {
        /// <summary>
        /// Feedback value, an integer between -10 and 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Weight of the feedback, a float between 0 and 1. Default is 1.0.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Additional metadata for the feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackUpdateRequest" /> class.
        /// </summary>
        /// <param name="value">
        /// Feedback value, an integer between -10 and 10.
        /// </param>
        /// <param name="weight">
        /// Weight of the feedback, a float between 0 and 1. Default is 1.0.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the feedback.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackUpdateRequest(
            int value,
            float? weight,
            object? metadata)
        {
            this.Value = value;
            this.Weight = weight;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackUpdateRequest" /> class.
        /// </summary>
        public FeedbackUpdateRequest()
        {
        }
    }
}