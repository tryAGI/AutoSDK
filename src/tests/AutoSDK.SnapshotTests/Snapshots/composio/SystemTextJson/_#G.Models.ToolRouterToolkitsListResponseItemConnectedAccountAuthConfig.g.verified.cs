//HintName: G.Models.ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Auth config details
    /// </summary>
    public sealed partial class ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig
    {
        /// <summary>
        /// Auth config identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Authentication scheme type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_scheme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthScheme { get; set; }

        /// <summary>
        /// Whether this is a Composio-managed auth config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_composio_managed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsComposioManaged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// Auth config identifier
        /// </param>
        /// <param name="authScheme">
        /// Authentication scheme type
        /// </param>
        /// <param name="isComposioManaged">
        /// Whether this is a Composio-managed auth config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig(
            string id,
            string authScheme,
            bool isComposioManaged)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AuthScheme = authScheme ?? throw new global::System.ArgumentNullException(nameof(authScheme));
            this.IsComposioManaged = isComposioManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig" /> class.
        /// </summary>
        public ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig()
        {
        }
    }
}