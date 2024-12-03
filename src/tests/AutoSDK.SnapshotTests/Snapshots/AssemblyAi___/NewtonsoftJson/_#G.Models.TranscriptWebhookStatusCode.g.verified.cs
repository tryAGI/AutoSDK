//HintName: G.Models.TranscriptWebhookStatusCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status code we received from your server when delivering the transcript completed or failed webhook request, if a webhook URL was provided
    /// </summary>
    public sealed partial class TranscriptWebhookStatusCode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWebhookStatusCode" /> class.
        /// </summary>
        public TranscriptWebhookStatusCode(
 )
        {
        }
    }
}