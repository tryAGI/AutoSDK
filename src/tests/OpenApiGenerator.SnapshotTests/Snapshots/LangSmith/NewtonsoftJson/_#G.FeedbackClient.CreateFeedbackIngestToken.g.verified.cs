//HintName: G.FeedbackClient.CreateFeedbackIngestToken.g.cs

#nullable enable

namespace G
{
    public partial class FeedbackClient
    {
        partial void PrepareCreateFeedbackIngestTokenArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.AnyOf<global::G.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenCreateSchema>> request);
        partial void PrepareCreateFeedbackIngestTokenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<global::G.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenCreateSchema>> request);
        partial void ProcessCreateFeedbackIngestTokenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFeedbackIngestTokenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Feedback Ingest Token<br/>
        /// Create a new feedback ingest token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.AnyOf<global::G.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenSchema>>> CreateFeedbackIngestTokenAsync(
            global::System.AnyOf<global::G.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenCreateSchema>> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFeedbackIngestTokenArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/feedback/tokens", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFeedbackIngestTokenRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateFeedbackIngestTokenResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFeedbackIngestTokenResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.AnyOf<global::G.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenSchema>>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Feedback Ingest Token<br/>
        /// Create a new feedback ingest token.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.AnyOf<global::G.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenSchema>>> CreateFeedbackIngestTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::System.AnyOf<global::G.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenCreateSchema>>
            {
            };

            return await CreateFeedbackIngestTokenAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}