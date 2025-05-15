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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Optional contact email to reach you back
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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