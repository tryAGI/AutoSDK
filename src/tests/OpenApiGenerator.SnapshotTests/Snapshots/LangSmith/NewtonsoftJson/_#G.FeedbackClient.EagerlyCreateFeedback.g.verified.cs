//HintName: G.FeedbackClient.EagerlyCreateFeedback.g.cs

#nullable enable

namespace G
{
    public partial class FeedbackClient
    {
        partial void PrepareEagerlyCreateFeedbackArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.FeedbackCreateSchema request);
        partial void PrepareEagerlyCreateFeedbackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.FeedbackCreateSchema request);
        partial void ProcessEagerlyCreateFeedbackResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEagerlyCreateFeedbackResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Eagerly Create Feedback<br/>
        /// Create a new feedback.<br/>
        /// This method is invoked under the assumption that the run<br/>
        /// is already visible in the app, thus already present in DB
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FeedbackSchema> EagerlyCreateFeedbackAsync(
            global::G.FeedbackCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareEagerlyCreateFeedbackArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/feedback/eager", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareEagerlyCreateFeedbackRequest(
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
            ProcessEagerlyCreateFeedbackResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessEagerlyCreateFeedbackResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FeedbackSchema?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Eagerly Create Feedback<br/>
        /// Create a new feedback.<br/>
        /// This method is invoked under the assumption that the run<br/>
        /// is already visible in the app, thus already present in DB
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="key"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackGroupId"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FeedbackSchema> EagerlyCreateFeedbackAsync(
            string key,
            global::System.DateTime createdAt = default,
            global::System.DateTime modifiedAt = default,
            global::System.AnyOf<double?, int?, bool?, object>? score = default,
            global::System.AnyOf<double?, int?, bool?, string, global::G.FeedbackCreateSchemaValue, object>? value = default,
            global::System.AnyOf<string, object>? comment = default,
            global::System.AnyOf<global::G.FeedbackCreateSchemaCorrection, string, object>? correction = default,
            global::System.AnyOf<string, object>? feedbackGroupId = default,
            global::System.AnyOf<string, object>? comparativeExperimentId = default,
            global::System.AnyOf<string, object>? runId = default,
            global::System.AnyOf<string, object>? sessionId = default,
            string? id = default,
            global::System.AnyOf<global::G.AppFeedbackSource, global::G.APIFeedbackSource, global::G.ModelFeedbackSource, global::G.AutoEvalFeedbackSource, object>? feedbackSource = default,
            global::System.AnyOf<global::G.FeedbackConfig, object>? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.FeedbackCreateSchema
            {
                CreatedAt = createdAt,
                ModifiedAt = modifiedAt,
                Key = key,
                Score = score,
                Value = value,
                Comment = comment,
                Correction = correction,
                FeedbackGroupId = feedbackGroupId,
                ComparativeExperimentId = comparativeExperimentId,
                RunId = runId,
                SessionId = sessionId,
                Id = id,
                FeedbackSource = feedbackSource,
                FeedbackConfig = feedbackConfig,
            };

            return await EagerlyCreateFeedbackAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}