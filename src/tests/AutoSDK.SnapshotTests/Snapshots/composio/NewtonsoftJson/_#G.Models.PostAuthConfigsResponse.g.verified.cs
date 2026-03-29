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
        [global::Newtonsoft.Json.JsonProperty("toolkit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostAuthConfigsResponseToolkit Toolkit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostAuthConfigsResponseAuthConfig AuthConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponse" /> class.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="authConfig"></param>
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