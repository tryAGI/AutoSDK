//HintName: G.Models.TokenizeResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizeResponse200
    {
        /// <summary>
        /// Unique ID for the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (tokens).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the tokens were generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The name of the model used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// An array of token data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public global::System.Collections.Generic.IList<global::G.TokenizePostResponsesContentApplicationJsonSchemaTokensItems>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the token.
        /// </param>
        /// <param name="object">
        /// Type of object (tokens).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the tokens were generated.
        /// </param>
        /// <param name="model">
        /// The name of the model used.
        /// </param>
        /// <param name="tokens">
        /// An array of token data.
        /// </param>
        public TokenizeResponse200(
            string? id,
            string? @object,
            int? created,
            string? model,
            global::System.Collections.Generic.IList<global::G.TokenizePostResponsesContentApplicationJsonSchemaTokensItems>? tokens)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse200" /> class.
        /// </summary>
        public TokenizeResponse200()
        {
        }
    }
}