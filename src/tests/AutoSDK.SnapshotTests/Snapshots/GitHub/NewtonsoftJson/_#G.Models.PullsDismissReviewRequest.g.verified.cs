//HintName: G.Models.PullsDismissReviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsDismissReviewRequest
    {
        /// <summary>
        /// The message for the pull request review dismissal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Example: "DISMISS"
        /// </summary>
        /// <example>"DISMISS"</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.PullsDismissReviewRequestEvent? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsDismissReviewRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// The message for the pull request review dismissal
        /// </param>
        /// <param name="event">
        /// Example: "DISMISS"
        /// </param>
        public PullsDismissReviewRequest(
            string message,
            global::G.PullsDismissReviewRequestEvent? @event)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsDismissReviewRequest" /> class.
        /// </summary>
        public PullsDismissReviewRequest()
        {
        }
    }
}