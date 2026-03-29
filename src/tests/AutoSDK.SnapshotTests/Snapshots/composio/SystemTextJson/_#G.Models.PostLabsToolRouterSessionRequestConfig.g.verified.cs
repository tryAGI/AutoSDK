//HintName: G.Models.PostLabsToolRouterSessionRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Session configuration including enabled toolkits and their auth configs<br/>
    /// Default Value: {}<br/>
    /// Example: {"manually_manage_connections":false,"toolkits":[{"toolkit":"gmail","auth_config_id":"auth_config_123"},{"toolkit":"slack"}]}
    /// </summary>
    public sealed partial class PostLabsToolRouterSessionRequestConfig
    {
        /// <summary>
        /// Whether to manually manage connections<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("manually_manage_connections")]
        public bool? ManuallyManageConnections { get; set; }

        /// <summary>
        /// Array of toolkit configurations with optional auth configs<br/>
        /// Default Value: []<br/>
        /// Example: [{"toolkit":"gmail","auth_config_id":"auth_config_123"}, {"toolkit":"slack"}]
        /// </summary>
        /// <example>[{"toolkit":"gmail","auth_config_id":"auth_config_123"}, {"toolkit":"slack"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        public global::System.Collections.Generic.IList<global::G.PostLabsToolRouterSessionRequestConfigToolkit>? Toolkits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLabsToolRouterSessionRequestConfig" /> class.
        /// </summary>
        /// <param name="manuallyManageConnections">
        /// Whether to manually manage connections<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="toolkits">
        /// Array of toolkit configurations with optional auth configs<br/>
        /// Default Value: []<br/>
        /// Example: [{"toolkit":"gmail","auth_config_id":"auth_config_123"}, {"toolkit":"slack"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostLabsToolRouterSessionRequestConfig(
            bool? manuallyManageConnections,
            global::System.Collections.Generic.IList<global::G.PostLabsToolRouterSessionRequestConfigToolkit>? toolkits)
        {
            this.ManuallyManageConnections = manuallyManageConnections;
            this.Toolkits = toolkits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLabsToolRouterSessionRequestConfig" /> class.
        /// </summary>
        public PostLabsToolRouterSessionRequestConfig()
        {
        }
    }
}