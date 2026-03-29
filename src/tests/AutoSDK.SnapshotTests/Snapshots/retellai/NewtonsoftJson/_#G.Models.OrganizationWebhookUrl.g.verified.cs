//HintName: G.Models.OrganizationWebhookUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationWebhookUrl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationWebhookUrl" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeoutMs"></param>
        public OrganizationWebhookUrl(
            string? url,
            int? timeoutMs)
        {
            this.Url = url;
            this.TimeoutMs = timeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationWebhookUrl" /> class.
        /// </summary>
        public OrganizationWebhookUrl()
        {
        }
    }
}