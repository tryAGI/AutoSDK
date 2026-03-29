//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// for slack user scopes
    /// </summary>
    public sealed partial class PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser(
            string? accessToken,
            string? scope)
        {
            this.AccessToken = accessToken;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser" /> class.
        /// </summary>
        public PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser()
        {
        }
    }
}