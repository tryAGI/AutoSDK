//HintName: G.AnnotationsClient.CreateBulk.g.cs

#nullable enable

namespace G
{
    public partial class AnnotationsClient
    {
        partial void PrepareCreateBulkArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.AnnotationBulkSerializerWithSelectedItemsRequest request);
        partial void PrepareCreateBulkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AnnotationBulkSerializerWithSelectedItemsRequest request);
        partial void ProcessCreateBulkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateBulkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Bulk create annotations<br/>
        /// Create multiple annotations at once
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ApiAnnotationsBulkCreateResponseItem>> CreateBulkAsync(

            global::G.AnnotationBulkSerializerWithSelectedItemsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateBulkArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/annotations/bulk/",
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
            PrepareCreateBulkRequest(
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
            ProcessCreateBulkResponse(
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
                ProcessCreateBulkResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.ApiAnnotationsBulkCreateResponseItem>?>(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.ApiAnnotationsBulkCreateResponseItem>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Bulk create annotations<br/>
        /// Create multiple annotations at once
        /// </summary>
        /// <param name="bulkCreated">
        /// Annotation was created in bulk mode
        /// </param>
        /// <param name="completedBy"></param>
        /// <param name="draftCreatedAt">
        /// Draft creation time
        /// </param>
        /// <param name="groundTruth">
        /// This annotation is a Ground Truth (ground_truth)
        /// </param>
        /// <param name="importId">
        /// Original annotation ID that was at the import step or NULL if this annotation wasn't imported
        /// </param>
        /// <param name="lastAction">
        /// Action which was performed in the last annotation history item<br/>
        /// * `prediction` - Created from prediction<br/>
        /// * `propagated_annotation` - Created from another annotation<br/>
        /// * `imported` - Imported<br/>
        /// * `submitted` - Submitted<br/>
        /// * `updated` - Updated<br/>
        /// * `skipped` - Skipped<br/>
        /// * `accepted` - Accepted<br/>
        /// * `rejected` - Rejected<br/>
        /// * `fixed_and_accepted` - Fixed and accepted<br/>
        /// * `deleted_review` - Deleted review
        /// </param>
        /// <param name="lastCreatedBy">
        /// User who created the last annotation history item
        /// </param>
        /// <param name="leadTime">
        /// How much time it took to annotate the task
        /// </param>
        /// <param name="parentAnnotation">
        /// Points to the parent annotation from which this annotation was created
        /// </param>
        /// <param name="parentPrediction">
        /// Points to the prediction from which this annotation was created
        /// </param>
        /// <param name="project">
        /// Project ID for this annotation
        /// </param>
        /// <param name="result">
        /// List of annotation results for the task
        /// </param>
        /// <param name="selectedItems"></param>
        /// <param name="task">
        /// Corresponding task for this annotation
        /// </param>
        /// <param name="tasks"></param>
        /// <param name="uniqueId">
        /// Included only in requests
        /// </param>
        /// <param name="updatedBy">
        /// Last user who updated this annotation
        /// </param>
        /// <param name="wasCancelled">
        /// User skipped the task
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ApiAnnotationsBulkCreateResponseItem>> CreateBulkAsync(
            string uniqueId,
            bool? bulkCreated = default,
            int? completedBy = default,
            global::System.DateTime? draftCreatedAt = default,
            bool? groundTruth = default,
            long? importId = default,
            global::G.LastActionEnum? lastAction = default,
            int? lastCreatedBy = default,
            double? leadTime = default,
            int? parentAnnotation = default,
            int? parentPrediction = default,
            int? project = default,
            global::System.Collections.Generic.IList<object>? result = default,
            global::G.SelectedItemsRequest? selectedItems = default,
            int? task = default,
            global::System.Collections.Generic.IList<int>? tasks = default,
            int? updatedBy = default,
            bool? wasCancelled = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.AnnotationBulkSerializerWithSelectedItemsRequest
            {
                BulkCreated = bulkCreated,
                CompletedBy = completedBy,
                DraftCreatedAt = draftCreatedAt,
                GroundTruth = groundTruth,
                ImportId = importId,
                LastAction = lastAction,
                LastCreatedBy = lastCreatedBy,
                LeadTime = leadTime,
                ParentAnnotation = parentAnnotation,
                ParentPrediction = parentPrediction,
                Project = project,
                Result = result,
                SelectedItems = selectedItems,
                Task = task,
                Tasks = tasks,
                UniqueId = uniqueId,
                UpdatedBy = updatedBy,
                WasCancelled = wasCancelled,
            };

            return await CreateBulkAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}