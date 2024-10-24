//HintName: G.IEmbeddingsClient.CreateEmbedding.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Creates an embedding vector representing the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEmbeddingResponse> CreateEmbeddingAsync(
            global::G.CreateEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an embedding vector representing the input text.
        /// </summary>
        /// <param name="input">
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model (8192 tokens for `text-embedding-ada-002`), cannot be an empty string, and any array must be 2048 dimensions or less. [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken) for counting tokens.<br/>
        /// Example: The quick brown fox jumped over the lazy dog
        /// </param>
        /// <param name="model">
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them.<br/>
        /// Example: text-embedding-3-small
        /// </param>
        /// <param name="encodingFormat">
        /// The format to return the embeddings in. Can be either `float` or [`base64`](https://pypi.org/project/pybase64/).<br/>
        /// Default Value: float<br/>
        /// Example: float
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions the resulting output embeddings should have. Only supported in `text-embedding-3` and later models.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEmbeddingResponse> CreateEmbeddingAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>> input,
            global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?> model,
            global::G.CreateEmbeddingRequestEncodingFormat? encodingFormat = default,
            int? dimensions = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}