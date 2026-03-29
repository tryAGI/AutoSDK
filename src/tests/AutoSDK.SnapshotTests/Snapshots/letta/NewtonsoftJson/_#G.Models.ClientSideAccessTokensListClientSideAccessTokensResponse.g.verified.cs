//HintName: G.Models.ClientSideAccessTokensListClientSideAccessTokensResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensListClientSideAccessTokensResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ClientSideAccessTokensListClientSideAccessTokensResponseToken> Tokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasNextPage", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponse" /> class.
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="hasNextPage"></param>
        public ClientSideAccessTokensListClientSideAccessTokensResponse(
            global::System.Collections.Generic.IList<global::G.ClientSideAccessTokensListClientSideAccessTokensResponseToken> tokens,
            bool hasNextPage)
        {
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponse" /> class.
        /// </summary>
        public ClientSideAccessTokensListClientSideAccessTokensResponse()
        {
        }
    }
}