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
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public string From { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSponsorshipEditedChangesPrivacyLevel" /> class.
        /// </summary>
        /// <param name="from">
        /// The `edited` event types include the details about the change when someone edits a sponsorship to change the privacy.
        /// </param>
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