//HintName: G.RunClient.UpdateRule.g.cs

#nullable enable

namespace G
{
    public partial class RunClient
    {
        partial void PrepareUpdateRuleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid ruleId,
            global::G.RunRulesCreateSchema request);
        partial void PrepareUpdateRuleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid ruleId,
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
            global::System.Guid ruleId,
            global::G.RunRulesCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateRuleArguments(
                httpClient: HttpClient,
                ruleId: ref ruleId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/runs/rules/{ruleId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateRuleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                ruleId: ruleId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateRuleResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateRuleResponseContent(
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

            return
                global::G.RunRulesSchema.FromJson(__content, JsonSerializerOptions) ??
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
        /// <param name="codeEvaluators"></param>
        /// <param name="alerts"></param>
        /// <param name="webhooks"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunRulesSchema> UpdateRuleAsync(
            global::System.Guid ruleId,
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
            var __request = new global::G.RunRulesCreateSchema
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

            return await UpdateRuleAsync(
                ruleId: ruleId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}