//HintName: G.Models.AssistantSidebarConfigResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantSidebarConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_url")]
        public string? ManifestUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantSidebarConfigResponse" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="manifestUrl"></param>
        public AssistantSidebarConfigResponse(
            bool? enabled,
            string? manifestUrl)
        {
            this.Enabled = enabled;
            this.ManifestUrl = manifestUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantSidebarConfigResponse" /> class.
        /// </summary>
        public AssistantSidebarConfigResponse()
        {
        }
    }
}