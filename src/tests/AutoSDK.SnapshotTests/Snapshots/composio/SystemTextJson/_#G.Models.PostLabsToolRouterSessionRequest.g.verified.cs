//HintName: G.Models.PostLabsToolRouterSessionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostLabsToolRouterSessionRequest
    {
        /// <summary>
        /// Unique user identifier for the session owner<br/>
        /// Example: user_123456789
        /// </summary>
        /// <example>user_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Session configuration including enabled toolkits and their auth configs<br/>
        /// Default Value: {}<br/>
        /// Example: {"manually_manage_connections":false,"toolkits":[{"toolkit":"gmail","auth_config_id":"auth_config_123"},{"toolkit":"slack"}]}
        /// </summary>
        /// <example>{"manually_manage_connections":false,"toolkits":[{"toolkit":"gmail","auth_config_id":"auth_config_123"},{"toolkit":"slack"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.PostLabsToolRouterSessionRequestConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLabsToolRouterSessionRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// Unique user identifier for the session owner<br/>
        /// Example: user_123456789
        /// </param>
        /// <param name="config">
        /// Session configuration including enabled toolkits and their auth configs<br/>
        /// Default Value: {}<br/>
        /// Example: {"manually_manage_connections":false,"toolkits":[{"toolkit":"gmail","auth_config_id":"auth_config_123"},{"toolkit":"slack"}]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostLabsToolRouterSessionRequest(
            string userId,
            global::G.PostLabsToolRouterSessionRequestConfig? config)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLabsToolRouterSessionRequest" /> class.
        /// </summary>
        public PostLabsToolRouterSessionRequest()
        {
        }
    }
}