//HintName: G.Models.PostAuthConfigsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthConfigsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostAuthConfigsResponseToolkit Toolkit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostAuthConfigsResponseAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponse" /> class.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="authConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthConfigsResponse(
            global::G.PostAuthConfigsResponseToolkit toolkit,
            global::G.PostAuthConfigsResponseAuthConfig authConfig)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.AuthConfig = authConfig ?? throw new global::System.ArgumentNullException(nameof(authConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponse" /> class.
        /// </summary>
        public PostAuthConfigsResponse()
        {
        }
    }
}