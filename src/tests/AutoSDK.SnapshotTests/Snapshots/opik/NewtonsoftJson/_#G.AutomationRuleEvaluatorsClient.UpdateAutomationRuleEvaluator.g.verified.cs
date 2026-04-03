//HintName: G.AutomationRuleEvaluatorsClient.UpdateAutomationRuleEvaluator.g.cs

#nullable enable

namespace G
{
    public partial class AutomationRuleEvaluatorsClient
    {
        partial void PrepareUpdateAutomationRuleEvaluatorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            global::G.AutomationRuleEvaluatorUpdate request);
        partial void PrepareUpdateAutomationRuleEvaluatorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            global::G.AutomationRuleEvaluatorUpdate request);
        partial void ProcessUpdateAutomationRuleEvaluatorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update Automation Rule Evaluator by id<br/>
        /// Update Automation Rule Evaluator by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UpdateAutomationRuleEvaluatorAsync(
            global::System.Guid id,

            global::G.AutomationRuleEvaluatorUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateAutomationRuleEvaluatorArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/private/automations/evaluators/{id}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateAutomationRuleEvaluatorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateAutomationRuleEvaluatorResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Update Automation Rule Evaluator by id<br/>
        /// Update Automation Rule Evaluator by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="samplingRate"></param>
        /// <param name="enabled"></param>
        /// <param name="projectId">
        /// Primary project ID (legacy field, maintained for backwards compatibility)
        /// </param>
        /// <param name="projectIds">
        /// Multiple project IDs (new field for multi-project support)
        /// </param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateAutomationRuleEvaluatorAsync(
            global::System.Guid id,
            string name,
            float? samplingRate = default,
            bool? enabled = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            global::G.AutomationRuleEvaluatorUpdateAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.AutomationRuleEvaluatorUpdate
            {
                Name = name,
                SamplingRate = samplingRate,
                Enabled = enabled,
                ProjectId = projectId,
                ProjectIds = projectIds,
                Action = action,
            };

            await UpdateAutomationRuleEvaluatorAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}