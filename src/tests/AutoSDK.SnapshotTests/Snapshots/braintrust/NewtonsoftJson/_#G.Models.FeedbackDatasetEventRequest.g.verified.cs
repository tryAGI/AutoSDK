//HintName: G.Models.FeedbackDatasetEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackDatasetEventRequest
    {
        /// <summary>
        /// A list of dataset feedback items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FeedbackDatasetItem> Feedback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackDatasetEventRequest" /> class.
        /// </summary>
        /// <param name="feedback">
        /// A list of dataset feedback items
        /// </param>
        public FeedbackDatasetEventRequest(
            global::System.Collections.Generic.IList<global::G.FeedbackDatasetItem> feedback)
        {
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackDatasetEventRequest" /> class.
        /// </summary>
        public FeedbackDatasetEventRequest()
        {
        }
    }
}