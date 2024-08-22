//HintName: G.RunClient.UpdateRule.g.cs

#nullable enable

namespace G
{
    public partial class RunClient
    {
        partial void PrepareUpdateRuleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ruleId,
            global::G.RunRulesCreateSchema request);
        partial void PrepareUpdateRuleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ruleId,
            global::G.RunRulesCreateSchema request);
        partial void ProcessUpdateRuleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateRuleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Rule<br/>
        /// Update a run rule.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunRulesSchema> UpdateRuleAsync(
            string ruleId,
            global::G.RunRulesCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateRuleArguments(
                httpClient: _httpClient,
                ruleId: ref ruleId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/runs/rules/{ruleId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateRuleRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ruleId: ruleId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateRuleResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateRuleResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunRulesSchema?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Rule<br/>
        /// Update a run rule.
        /// </summary>
        /// <param name="ruleId"></param>
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
        /// <param name="alerts"></param>
        /// <param name="webhooks"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunRulesSchema> UpdateRuleAsync(
            string ruleId,
            string displayName,
            double samplingRate,
            global::System.AnyOf<string, object>? sessionId = default,
            bool isEnabled = true,
            global::System.AnyOf<string, object>? datasetId = default,
            global::System.AnyOf<string?, object>? filter = default,
            global::System.AnyOf<string?, object>? traceFilter = default,
            global::System.AnyOf<string?, object>? treeFilter = default,
            global::System.AnyOf<global::System.DateTime?, object>? backfillFrom = default,
            bool useCorrectionsDataset = false,
            global::System.AnyOf<int?, object>? numFewShotExamples = default,
            bool extendOnly = false,
            global::System.AnyOf<string, object>? addToAnnotationQueueId = default,
            global::System.AnyOf<string, object>? addToDatasetId = default,
            bool addToDatasetPreferCorrection = false,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::G.EvaluatorTopLevel>, object>? evaluators = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::G.RunRulesPagerdutyAlertSchema>, object>? alerts = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::G.RunRulesWebhookSchema>, object>? webhooks = default,
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
                Alerts = alerts,
                Webhooks = webhooks,
            };

            return await UpdateRuleAsync(
                ruleId: ruleId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}