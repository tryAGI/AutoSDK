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
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkitId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("getCurrentUserEndpoint")]
        public string? GetCurrentUserEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawProxyInfoByAuthSchemes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>> RawProxyInfoByAuthSchemes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseDeprecated" /> class.
        /// </summary>
        /// <param name="toolkitId"></param>
        /// <param name="rawProxyInfoByAuthSchemes"></param>
        /// <param name="getCurrentUserEndpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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