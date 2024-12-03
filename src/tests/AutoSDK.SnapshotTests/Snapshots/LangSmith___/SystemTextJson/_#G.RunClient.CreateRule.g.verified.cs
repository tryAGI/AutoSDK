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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunRulesSchema> CreateRuleAsync(
            global::G.RunRulesCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRuleArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/runs/rules",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            PrepareCreateRuleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateRuleResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateRuleResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.RunRulesSchema.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.RunRulesSchema.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
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
            bool? isEnabled = default,
            global::System.Guid? datasetId = default,
            string? filter = default,
            string? traceFilter = default,
            string? treeFilter = default,
            global::System.DateTime? backfillFrom = default,
            bool? useCorrectionsDataset = default,
            int? numFewShotExamples = default,
            bool? extendOnly = default,
            global::System.Guid? addToAnnotationQueueId = default,
            global::System.Guid? addToDatasetId = default,
            bool? addToDatasetPreferCorrection = default,
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

            return await CreateRuleAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}