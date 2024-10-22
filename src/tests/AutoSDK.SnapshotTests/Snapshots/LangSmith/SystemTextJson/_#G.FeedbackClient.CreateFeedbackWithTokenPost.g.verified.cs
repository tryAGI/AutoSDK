//HintName: G.FeedbackClient.CreateFeedbackWithTokenPost.g.cs

#nullable enable

namespace G
{
    public partial class FeedbackClient
    {
        partial void PrepareCreateFeedbackWithTokenPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid token,
            global::G.FeedbackCreateWithTokenExtendedSchema request);
        partial void PrepareCreateFeedbackWithTokenPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid token,
            global::G.FeedbackCreateWithTokenExtendedSchema request);
        partial void ProcessCreateFeedbackWithTokenPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFeedbackWithTokenPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Feedback With Token Post<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> CreateFeedbackWithTokenPostAsync(
            global::System.Guid token,
            global::G.FeedbackCreateWithTokenExtendedSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateFeedbackWithTokenPostArguments(
                httpClient: HttpClient,
                token: ref token,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/feedback/tokens/{token}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateFeedbackWithTokenPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateFeedbackWithTokenPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateFeedbackWithTokenPostResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return __content;
        }

        /// <summary>
        /// Create Feedback With Token Post<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> CreateFeedbackWithTokenPostAsync(
            global::System.Guid token,
            global::G.AnyOf<double?, int?, bool?>? score = default,
            global::G.AnyOf<double?, int?, bool?, string>? value = default,
            string? comment = default,
            global::G.AnyOf<object, string>? correction = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.FeedbackCreateWithTokenExtendedSchema
            {
                Score = score,
                Value = value,
                Comment = comment,
                Correction = correction,
                Metadata = metadata,
            };

            return await CreateFeedbackWithTokenPostAsync(
                token: token,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}