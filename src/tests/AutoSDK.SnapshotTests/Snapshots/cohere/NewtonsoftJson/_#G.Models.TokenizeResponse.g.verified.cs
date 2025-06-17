﻿//HintName: G.Models.TokenizeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_strings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TokenStrings { get; set; } = default!;

        /// <summary>
        /// An array of tokens, where each token is an integer.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public global::System.Collections.Generic.IList<int> Tokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse" /> class.
        /// </summary>
        /// <param name="meta"></param>
        /// <param name="tokenStrings"></param>
        /// <param name="tokens">
        /// An array of tokens, where each token is an integer.<br/>
        /// Included only in responses
        /// </param>
        public TokenizeResponse(
            global::System.Collections.Generic.IList<string> tokenStrings,
            global::G.ApiMeta? meta,
            global::System.Collections.Generic.IList<int> tokens = default!)
        {
            this.TokenStrings = tokenStrings ?? throw new global::System.ArgumentNullException(nameof(tokenStrings));
            this.Meta = meta;
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse" /> class.
        /// </summary>
        public TokenizeResponse()
        {
        }
    }
}