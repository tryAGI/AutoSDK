//HintName: G.RunClient.CreateRule.g.cs

#nullable enable

namespace G
{
    public partial class RunClient
    {
        partial void PrepareCreateRuleArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RunRulesCreateSchema request);
        partial void PrepareCreateRuleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RunRulesCreateSchema request);
        partial void ProcessCreateRuleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRuleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Rule<br/>
        /// Create a new run rule.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunRulesSchema> CreateRuleAsync(
            global::G.RunRulesCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateRuleArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/runs/rules",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateRuleRequest(
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
            ProcessCreateRuleResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateRuleResponseContent(
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
                global::G.RunRulesSchema.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Rule<br/>
        /// Create a new run rule.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="sessionId"></param>
        /// <param name="isEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="samplingRate"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="backfillFrom"></param>
        /// <param name="useCorrectionsDataset">
        /// Default Value: false
        /// </param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="extendOnly">
        /// Default Value: false
        /// </param>
        /// <param name="addToAnnotationQueueId"></param>
        /// <param name="addToDatasetId"></param>
        /// <param name="addToDatasetPreferCorrection">
        /// Default Value: false
        /// </param>
        /// <param name="evaluators"></param>
        /// <param name="codeEvaluators"></param>
        /// <param name="alerts"></param>
        /// <param name="webhooks"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunRulesSchema> CreateRuleAsync(
            string displayName,
            double samplingRate,
            global::System.Guid? sessionId = default,
            bool? isEnabled = true,
            global::System.Guid? datasetId = default,
            string? filter = default,
            string? traceFilter = default,
            string? treeFilter = default,
            global::System.DateTime? backfillFrom = default,
            bool? useCorrectionsDataset = false,
            int? numFewShotExamples = default,
            bool? extendOnly = false,
            global::System.Guid? addToAnnotationQueueId = default,
            global::System.Guid? addToDatasetId = default,
            bool? addToDatasetPreferCorrection = false,
            global::System.Collections.Generic.IList<global::G.EvaluatorTopLevel>? evaluators = default,
            global::System.Collections.Generic.IList<global::G.CodeEvaluatorTopLevel>? codeEvaluators = default,
            global::System.Collections.Generic.IList<global::G.RunRulesPagerdutyAlertSchema>? alerts = default,
            global::System.Collections.Generic.IList<global::G.RunRulesWebhookSchema>? webhooks = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.RunRulesCreateSchema
            {
                DisplayName = displayName,
                SessionId = sessionId,
                IsEnabled = isEnabled,
                DatasetId = datasetId,
                SamplingRate = samplingRate,
                Filter = filter,
                TraceFilter = traceFilter,
                TreeFilter = treeFilter,
                BackfillFrom = backfillFrom,
                UseCorrectionsDataset = useCorrectionsDataset,
                NumFewShotExamples = numFewShotExamples,
                ExtendOnly = extendOnly,
                AddToAnnotationQueueId = addToAnnotationQueueId,
                AddToDatasetId = addToDatasetId,
                AddToDatasetPreferCorrection = addToDatasetPreferCorrection,
                Evaluators = evaluators,
                CodeEvaluators = codeEvaluators,
                Alerts = alerts,
                Webhooks = webhooks,
            };

            return await CreateRuleAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}