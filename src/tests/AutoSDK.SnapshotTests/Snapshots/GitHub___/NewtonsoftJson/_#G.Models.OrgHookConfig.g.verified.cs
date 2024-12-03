//HintName: G.Models.OrgHookConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgHookConfig
    {
        /// <summary>
        /// Example: "http://example.com/2"
        /// </summary>
        /// <example>"http://example.com/2"</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Example: "0"
        /// </summary>
        /// <example>"0"</example>
        [global::Newtonsoft.Json.JsonProperty("insecure_ssl")]
        public string? InsecureSsl { get; set; }

        /// <summary>
        /// Example: "form"
        /// </summary>
        /// <example>"form"</example>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Example: "********"
        /// </summary>
        /// <example>"********"</example>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgHookConfig" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: "http://example.com/2"
        /// </param>
        /// <param name="insecureSsl">
        /// Example: "0"
        /// </param>
        /// <param name="contentType">
        /// Example: "form"
        /// </param>
        /// <param name="secret">
        /// Example: "********"
        /// </param>
        public OrgHookConfig(
            string? url,
            string? insecureSsl,
            string? contentType,
            string? secret)
        {
            this.Url = url;
            this.InsecureSsl = insecureSsl;
            this.ContentType = contentType;
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgHookConfig" /> class.
        /// </summary>
        public OrgHookConfig()
        {
        }
    }
}