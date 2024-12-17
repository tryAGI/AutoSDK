//HintName: G.Models.TranscriptWebhookUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The URL to which we send webhook requests.<br/>
    /// We sends two different types of webhook requests.<br/>
    /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
    /// </summary>
    public sealed partial class TranscriptWebhookUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}