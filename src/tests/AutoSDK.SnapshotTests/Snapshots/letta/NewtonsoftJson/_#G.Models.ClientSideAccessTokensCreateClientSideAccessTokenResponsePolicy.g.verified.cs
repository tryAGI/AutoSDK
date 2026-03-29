//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="version"></param>
        public ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy(
            global::System.Collections.Generic.IList<global::G.DataItem> data,
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion version)
        {
            this.Version = version;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy" /> class.
        /// </summary>
        public ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy()
        {
        }
    }
}