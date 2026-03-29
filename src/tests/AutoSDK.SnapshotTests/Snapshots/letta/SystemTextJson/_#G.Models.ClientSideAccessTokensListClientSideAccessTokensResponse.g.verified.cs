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
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ClientSideAccessTokensListClientSideAccessTokensResponseToken> Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponse" /> class.
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="hasNextPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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