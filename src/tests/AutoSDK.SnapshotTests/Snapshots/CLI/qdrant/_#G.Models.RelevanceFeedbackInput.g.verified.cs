//HintName: G.Models.RelevanceFeedbackInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelevanceFeedbackInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorInput Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FeedbackItem> Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NaiveFeedbackStrategy Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelevanceFeedbackInput" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="feedback"></param>
        /// <param name="strategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelevanceFeedbackInput(
            global::G.VectorInput target,
            global::System.Collections.Generic.IList<global::G.FeedbackItem> feedback,
            global::G.NaiveFeedbackStrategy strategy)
        {
            this.Target = target;
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
            this.Strategy = strategy ?? throw new global::System.ArgumentNullException(nameof(strategy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelevanceFeedbackInput" /> class.
        /// </summary>
        public RelevanceFeedbackInput()
        {
        }
    }
}