//HintName: G.AnnotationsClient.Create.g.cs

#nullable enable

namespace G
{
    public partial class AnnotationsClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            global::G.ApiTasksAnnotationsCreateRequest request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            global::G.ApiTasksAnnotationsCreateRequest request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create annotation<br/>
        ///         Add annotations to a task like an annotator does. The content of the result field depends on your<br/>
        ///         labeling configuration. For example, send the following data as part of your POST<br/>
        ///         request to send an empty annotation with the ID of the user who completed the task:<br/>
        ///         ```json<br/>
        ///         {<br/>
        ///         "result": {},<br/>
        ///         "was_cancelled": true,<br/>
        ///         "ground_truth": true,<br/>
        ///         "lead_time": 0,<br/>
        ///         "task": 0<br/>
        ///         "completed_by": 123<br/>
        ///         }<br/>
        ///         ```<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Annotation> CreateAsync(
            int id,

            global::G.ApiTasksAnnotationsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/tasks/{id}/annotations/",
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
            PrepareCreateRequest(
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
            ProcessCreateResponse(
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
                ProcessCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Annotation.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Annotation.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create annotation<br/>
        ///         Add annotations to a task like an annotator does. The content of the result field depends on your<br/>
        ///         labeling configuration. For example, send the following data as part of your POST<br/>
        ///         request to send an empty annotation with the ID of the user who completed the task:<br/>
        ///         ```json<br/>
        ///         {<br/>
        ///         "result": {},<br/>
        ///         "was_cancelled": true,<br/>
        ///         "ground_truth": true,<br/>
        ///         "lead_time": 0,<br/>
        ///         "task": 0<br/>
        ///         "completed_by": 123<br/>
        ///         }<br/>
        ///         ```<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="completedBy">
        /// User ID of the person who created this annotation
        /// </param>
        /// <param name="groundTruth">
        /// This annotation is a Ground Truth
        /// </param>
        /// <param name="leadTime">
        /// How much time it took to annotate the task (in seconds)<br/>
        /// Example: 100.5
        /// </param>
        /// <param name="project">
        /// Project ID for this annotation
        /// </param>
        /// <param name="result">
        /// Labeling result in JSON format. Read more about the format in [the Label Studio documentation.](https://labelstud.io/guide/task_format)<br/>
        /// Example: [{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}]
        /// </param>
        /// <param name="task">
        /// Corresponding task for this annotation
        /// </param>
        /// <param name="updatedBy">
        /// Last user who updated this annotation
        /// </param>
        /// <param name="wasCancelled">
        /// User skipped the task
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Annotation> CreateAsync(
            int id,
            int? completedBy = default,
            bool? groundTruth = default,
            double? leadTime = default,
            int? project = default,
            global::System.Collections.Generic.IList<object>? result = default,
            int? task = default,
            int? updatedBy = default,
            bool? wasCancelled = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ApiTasksAnnotationsCreateRequest
            {
                CompletedBy = completedBy,
                GroundTruth = groundTruth,
                LeadTime = leadTime,
                Project = project,
                Result = result,
                Task = task,
                UpdatedBy = updatedBy,
                WasCancelled = wasCancelled,
            };

            return await CreateAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}