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
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorInput Target { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FeedbackItem> Feedback { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NaiveFeedbackStrategy Strategy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelevanceFeedbackInput" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="feedback"></param>
        /// <param name="strategy"></param>
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