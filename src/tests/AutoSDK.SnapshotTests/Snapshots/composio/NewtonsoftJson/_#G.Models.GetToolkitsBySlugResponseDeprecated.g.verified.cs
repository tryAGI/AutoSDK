//HintName: G.Models.GetToolkitsBySlugResponseDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseDeprecated
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkitId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolkitId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("getCurrentUserEndpoint")]
        public string? GetCurrentUserEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rawProxyInfoByAuthSchemes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>> RawProxyInfoByAuthSchemes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseDeprecated" /> class.
        /// </summary>
        /// <param name="toolkitId"></param>
        /// <param name="rawProxyInfoByAuthSchemes"></param>
        /// <param name="getCurrentUserEndpoint"></param>
        public GetToolkitsBySlugResponseDeprecated(
            string toolkitId,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>> rawProxyInfoByAuthSchemes,
            string? getCurrentUserEndpoint)
        {
            this.ToolkitId = toolkitId ?? throw new global::System.ArgumentNullException(nameof(toolkitId));
            this.GetCurrentUserEndpoint = getCurrentUserEndpoint;
            this.RawProxyInfoByAuthSchemes = rawProxyInfoByAuthSchemes ?? throw new global::System.ArgumentNullException(nameof(rawProxyInfoByAuthSchemes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseDeprecated" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseDeprecated()
        {
        }
    }
}