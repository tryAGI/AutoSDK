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
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Toolkit { get; set; }

        /// <summary>
        /// Specific auth configuration ID for this toolkit<br/>
        /// Example: auth_config_123
        /// </summary>
        /// <example>auth_config_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config_id")]
        public string? AuthConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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