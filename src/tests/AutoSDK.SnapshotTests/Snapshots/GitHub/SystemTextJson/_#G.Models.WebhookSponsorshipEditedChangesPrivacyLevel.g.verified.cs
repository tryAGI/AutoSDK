//HintName: G.Models.WebhookSponsorshipEditedChangesPrivacyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSponsorshipEditedChangesPrivacyLevel
    {
        /// <summary>
        /// The `edited` event types include the details about the change when someone edits a sponsorship to change the privacy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSponsorshipEditedChangesPrivacyLevel" /> class.
        /// </summary>
        /// <param name="from">
        /// The `edited` event types include the details about the change when someone edits a sponsorship to change the privacy.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookSponsorshipEditedChangesPrivacyLevel(
            string from)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSponsorshipEditedChangesPrivacyLevel" /> class.
        /// </summary>
        public WebhookSponsorshipEditedChangesPrivacyLevel()
        {
        }
    }
}