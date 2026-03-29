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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Authentication scheme type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_scheme", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthScheme { get; set; } = default!;

        /// <summary>
        /// Whether this is a Composio-managed auth config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_composio_managed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsComposioManaged { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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