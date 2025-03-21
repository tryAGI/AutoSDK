//HintName: G.IResponsesClient.CreateResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Creates a model response. Provide [text](/docs/guides/text) or<br/>
        /// [image](/docs/guides/images) inputs to generate [text](/docs/guides/text)<br/>
        /// or [JSON](/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](/docs/guides/function-calling) or use built-in<br/>
        /// [tools](/docs/guides/tools) like [web search](/docs/guides/tools-web-search)<br/>
        /// or [file search](/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response> CreateResponseAsync(
            global::G.CreateResponse request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a model response. Provide [text](/docs/guides/text) or<br/>
        /// [image](/docs/guides/images) inputs to generate [text](/docs/guides/text)<br/>
        /// or [JSON](/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](/docs/guides/function-calling) or use built-in<br/>
        /// [tools](/docs/guides/tools) like [web search](/docs/guides/tools-web-search)<br/>
        /// or [file search](/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response> CreateResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}