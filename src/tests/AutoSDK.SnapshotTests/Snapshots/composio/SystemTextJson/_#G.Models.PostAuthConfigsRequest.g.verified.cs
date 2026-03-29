//HintName: G.Models.PostAuthConfigsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthConfigsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostAuthConfigsRequestToolkit Toolkit { get; set; }

        /// <summary>
        /// Default Value: {"type":"use_composio_managed_auth","credentials":{},"restrict_to_following_tools":[]}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PostAuthConfigsRequestAuthConfigVariant1, global::G.PostAuthConfigsRequestAuthConfigVariant2>))]
        public global::G.OneOf<global::G.PostAuthConfigsRequestAuthConfigVariant1, global::G.PostAuthConfigsRequestAuthConfigVariant2>? AuthConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequest" /> class.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="authConfig">
        /// Default Value: {"type":"use_composio_managed_auth","credentials":{},"restrict_to_following_tools":[]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthConfigsRequest(
            global::G.PostAuthConfigsRequestToolkit toolkit,
            global::G.OneOf<global::G.PostAuthConfigsRequestAuthConfigVariant1, global::G.PostAuthConfigsRequestAuthConfigVariant2>? authConfig)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.AuthConfig = authConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequest" /> class.
        /// </summary>
        public PostAuthConfigsRequest()
        {
        }
    }
}