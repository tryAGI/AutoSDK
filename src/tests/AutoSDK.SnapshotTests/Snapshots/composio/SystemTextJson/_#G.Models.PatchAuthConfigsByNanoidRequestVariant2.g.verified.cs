//HintName: G.Models.PatchAuthConfigsByNanoidRequestVariant2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAuthConfigsByNanoidRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchAuthConfigsByNanoidRequestVariant2TypeJsonConverter))]
        public global::G.PatchAuthConfigsByNanoidRequestVariant2Type Type { get; set; }

        /// <summary>
        /// The display name of the authentication configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? Scopes { get; set; }

        /// <summary>
        /// Use tool_access_config instead. This field will be deprecated in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_to_following_tools")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RestrictToFollowingTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_access_config")]
        public global::G.PatchAuthConfigsByNanoidRequestVariant2ToolAccessConfig? ToolAccessConfig { get; set; }

        /// <summary>
        /// Shared credentials that will be inherited by connected accounts. For eg: this can be used to share the API key for a tool with all connected accounts using this auth config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_credentials")]
        public global::System.Collections.Generic.Dictionary<string, object?>? SharedCredentials { get; set; }

        /// <summary>
        /// Whether this auth config is enabled for tool router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled_for_tool_router")]
        public bool? IsEnabledForToolRouter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthConfigsByNanoidRequestVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// The display name of the authentication configuration
        /// </param>
        /// <param name="scopes"></param>
        /// <param name="toolAccessConfig"></param>
        /// <param name="sharedCredentials">
        /// Shared credentials that will be inherited by connected accounts. For eg: this can be used to share the API key for a tool with all connected accounts using this auth config.
        /// </param>
        /// <param name="isEnabledForToolRouter">
        /// Whether this auth config is enabled for tool router
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAuthConfigsByNanoidRequestVariant2(
            global::G.PatchAuthConfigsByNanoidRequestVariant2Type type,
            string? name,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? scopes,
            global::G.PatchAuthConfigsByNanoidRequestVariant2ToolAccessConfig? toolAccessConfig,
            global::System.Collections.Generic.Dictionary<string, object?>? sharedCredentials,
            bool? isEnabledForToolRouter)
        {
            this.Type = type;
            this.Name = name;
            this.Scopes = scopes;
            this.ToolAccessConfig = toolAccessConfig;
            this.SharedCredentials = sharedCredentials;
            this.IsEnabledForToolRouter = isEnabledForToolRouter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthConfigsByNanoidRequestVariant2" /> class.
        /// </summary>
        public PatchAuthConfigsByNanoidRequestVariant2()
        {
        }
    }
}