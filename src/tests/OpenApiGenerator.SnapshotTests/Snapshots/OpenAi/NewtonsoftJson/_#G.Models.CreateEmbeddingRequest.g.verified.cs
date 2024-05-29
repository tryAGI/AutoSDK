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
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model (8192 tokens for `text-embedding-ada-002`), cannot be an empty string, and any array must be 2048 dimensions or less. [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken) for counting tokens.
        /// <br/>Example: The quick brown fox jumped over the lazy dog
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>> Input { get; set; } = default!;

        /// <summary>
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them.
        /// <br/>Example: text-embedding-3-small
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.AnyOf<string, CreateEmbeddingRequestModel> Model { get; set; } = default!;

        /// <summary>
        /// The format to return the embeddings in. Can be either `float` or [`base64`](https://pypi.org/project/pybase64/).
        /// <br/>Default Value: float
        /// <br/>Example: float
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding_format")]
        public CreateEmbeddingRequestEncodingFormat? EncodingFormat { get; set; } = CreateEmbeddingRequestEncodingFormat.Float;

        /// <summary>
        /// The number of dimensions the resulting output embeddings should have. Only supported in `text-embedding-3` and later models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimensions")]
        public int Dimensions { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// <br/>Example: user-1234
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}