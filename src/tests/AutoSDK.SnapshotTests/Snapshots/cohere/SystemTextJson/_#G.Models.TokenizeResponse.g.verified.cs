//HintName: G.Models.TokenizeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizeResponse
    {
        /// <summary>
        /// An array of tokens, where each token is an integer.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<int> Tokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_strings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TokenStrings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse" /> class.
        /// </summary>
        /// <param name="tokens">
        /// An array of tokens, where each token is an integer.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tokenStrings"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizeResponse(
            global::System.Collections.Generic.IList<string> tokenStrings,
            global::G.ApiMeta? meta,
            global::System.Collections.Generic.IList<int> tokens = default!)
        {
            this.TokenStrings = tokenStrings ?? throw new global::System.ArgumentNullException(nameof(tokenStrings));
            this.Tokens = tokens;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse" /> class.
        /// </summary>
        public TokenizeResponse()
        {
        }
    }
}