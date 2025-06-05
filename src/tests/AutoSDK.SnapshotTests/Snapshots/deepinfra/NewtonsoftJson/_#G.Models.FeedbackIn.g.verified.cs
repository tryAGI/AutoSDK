//HintName: G.Models.FeedbackIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackIn
    {
        /// <summary>
        /// The message you'd like to send to deepinfra team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Optional contact email to reach you back
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contact_email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackIn" /> class.
        /// </summary>
        /// <param name="message">
        /// The message you'd like to send to deepinfra team
        /// </param>
        /// <param name="contactEmail">
        /// Optional contact email to reach you back
        /// </param>
        public FeedbackIn(
            string message,
            string? contactEmail)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ContactEmail = contactEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackIn" /> class.
        /// </summary>
        public FeedbackIn()
        {
        }
    }
}