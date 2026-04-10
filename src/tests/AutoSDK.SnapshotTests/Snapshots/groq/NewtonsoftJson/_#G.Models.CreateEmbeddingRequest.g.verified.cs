//HintName: G.Models.CreateEmbeddingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmbeddingRequest
    {
        /// <summary>
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model, cannot be an empty string, and any array must be 2048 dimensions or less.<br/>
        /// Example: The quick brown fox jumped over the lazy dog
        /// </summary>
        /// <example>The quick brown fox jumped over the lazy dog</example>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; } = default!;

        /// <summary>
        /// ID of the model to use.<br/>
        /// Example: nomic-embed-text-v1_5
        /// </summary>
        /// <example>nomic-embed-text-v1_5</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?> Model { get; set; } = default!;

        /// <summary>
        /// The format to return the embeddings in. Can only be `float` or `base64`.<br/>
        /// Default Value: float<br/>
        /// Example: float
        /// </summary>
        /// <example>float</example>
        [global::Newtonsoft.Json.JsonProperty("encoding_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter))]
        public global::G.CreateEmbeddingRequestEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help us monitor and detect abuse.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model, cannot be an empty string, and any array must be 2048 dimensions or less.<br/>
        /// Example: The quick brown fox jumped over the lazy dog
        /// </param>
        /// <param name="model">
        /// ID of the model to use.<br/>
        /// Example: nomic-embed-text-v1_5
        /// </param>
        /// <param name="encodingFormat">
        /// The format to return the embeddings in. Can only be `float` or `base64`.<br/>
        /// Default Value: float<br/>
        /// Example: float
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help us monitor and detect abuse.
        /// </param>
        public CreateEmbeddingRequest(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?> model,
            global::G.CreateEmbeddingRequestEncodingFormat? encodingFormat,
            string? user)
        {
            this.Input = input;
            this.Model = model;
            this.EncodingFormat = encodingFormat;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingRequest" /> class.
        /// </summary>
        public CreateEmbeddingRequest()
        {
        }
    }
}