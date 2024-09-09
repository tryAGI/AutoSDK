//HintName: G.Models.WebhookCheckRunRerequestedFormEncoded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The check_run.rerequested webhook encoded with URL encoding
    /// </summary>
    public sealed partial class WebhookCheckRunRerequestedFormEncoded
    {
        /// <summary>
        /// A URL-encoded string of the check_run.rerequested JSON payload. The decoded payload is a JSON object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public string Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}