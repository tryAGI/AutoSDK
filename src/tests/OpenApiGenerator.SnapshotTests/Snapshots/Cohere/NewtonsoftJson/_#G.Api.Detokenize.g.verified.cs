//HintName: G.Api.Detokenize.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareDetokenizeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.DetokenizeRequest request);
        partial void PrepareDetokenizeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.DetokenizeRequest request);
        partial void ProcessDetokenizeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDetokenizeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Detokenize<br/>
        /// This endpoint takes tokens using byte-pair encoding and returns their text representation. To learn more about tokenization and byte pair encoding, see the tokens page.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DetokenizeResponse> DetokenizeAsync(
            string? xClientName,
            global::G.DetokenizeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDetokenizeArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/detokenize", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDetokenizeRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xClientName: xClientName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDetokenizeResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDetokenizeResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DetokenizeResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Detokenize<br/>
        /// This endpoint takes tokens using byte-pair encoding and returns their text representation. To learn more about tokenization and byte pair encoding, see the tokens page.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="tokens">
        /// The list of tokens to be detokenized.
        /// </param>
        /// <param name="model">
        /// An optional parameter to provide the model name. This will ensure that the detokenization is done by the tokenizer used by that model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DetokenizeResponse> DetokenizeAsync(
            global::System.Collections.Generic.IList<int> tokens,
            string model,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.DetokenizeRequest
            {
                Tokens = tokens,
                Model = model,
            };

            return await DetokenizeAsync(
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}