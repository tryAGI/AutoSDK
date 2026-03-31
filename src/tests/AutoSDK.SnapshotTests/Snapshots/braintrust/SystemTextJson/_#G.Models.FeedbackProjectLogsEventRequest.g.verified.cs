//HintName: G.Models.FeedbackProjectLogsEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackProjectLogsEventRequest
    {
        /// <summary>
        /// A list of project logs feedback items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FeedbackProjectLogsItem> Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackProjectLogsEventRequest" /> class.
        /// </summary>
        /// <param name="feedback">
        /// A list of project logs feedback items
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackProjectLogsEventRequest(
            global::System.Collections.Generic.IList<global::G.FeedbackProjectLogsItem> feedback)
        {
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackProjectLogsEventRequest" /> class.
        /// </summary>
        public FeedbackProjectLogsEventRequest()
        {
        }
    }
}