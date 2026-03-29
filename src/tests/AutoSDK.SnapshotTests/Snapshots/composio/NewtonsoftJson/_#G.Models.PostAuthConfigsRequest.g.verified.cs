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
        [global::Newtonsoft.Json.JsonProperty("toolkit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostAuthConfigsRequestToolkit Toolkit { get; set; } = default!;

        /// <summary>
        /// Default Value: {"type":"use_composio_managed_auth","credentials":{},"restrict_to_following_tools":[]}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_config")]
        public global::G.OneOf<global::G.PostAuthConfigsRequestAuthConfigVariant1, global::G.PostAuthConfigsRequestAuthConfigVariant2>? AuthConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequest" /> class.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="authConfig">
        /// Default Value: {"type":"use_composio_managed_auth","credentials":{},"restrict_to_following_tools":[]}
        /// </param>
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