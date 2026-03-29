//HintName: G.Models.PostLabsToolRouterSessionRequestConfigToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostLabsToolRouterSessionRequestConfigToolkit
    {
        /// <summary>
        /// Toolkit identifier (e.g., gmail, slack, github)<br/>
        /// Example: gmail
        /// </summary>
        /// <example>gmail</example>
        [global::Newtonsoft.Json.JsonProperty("toolkit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Toolkit { get; set; } = default!;

        /// <summary>
        /// Specific auth configuration ID for this toolkit<br/>
        /// Example: auth_config_123
        /// </summary>
        /// <example>auth_config_123</example>
        [global::Newtonsoft.Json.JsonProperty("auth_config_id")]
        public string? AuthConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLabsToolRouterSessionRequestConfigToolkit" /> class.
        /// </summary>
        /// <param name="toolkit">
        /// Toolkit identifier (e.g., gmail, slack, github)<br/>
        /// Example: gmail
        /// </param>
        /// <param name="authConfigId">
        /// Specific auth configuration ID for this toolkit<br/>
        /// Example: auth_config_123
        /// </param>
        public PostLabsToolRouterSessionRequestConfigToolkit(
            string toolkit,
            string? authConfigId)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.AuthConfigId = authConfigId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLabsToolRouterSessionRequestConfigToolkit" /> class.
        /// </summary>
        public PostLabsToolRouterSessionRequestConfigToolkit()
        {
        }
    }
}