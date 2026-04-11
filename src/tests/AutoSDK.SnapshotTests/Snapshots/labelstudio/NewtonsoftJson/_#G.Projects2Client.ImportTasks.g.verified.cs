//HintName: G.Projects2Client.ImportTasks.g.cs

#nullable enable

namespace G
{
    public partial class Projects2Client
    {


        private static readonly global::G.EndPointSecurityRequirement s_ImportTasksSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Token",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ImportTasksSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ImportTasksSecurityRequirement0,
            };
        partial void PrepareImportTasksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? commitToProject,
            ref int id,
            global::System.Collections.Generic.IList<string>? preannotatedFromFields,
            ref bool? returnTaskIds,
            global::System.Collections.Generic.IList<global::G.ImportApiRequest> request);
        partial void PrepareImportTasksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? commitToProject,
            int id,
            global::System.Collections.Generic.IList<string>? preannotatedFromFields,
            bool? returnTaskIds,
            global::System.Collections.Generic.IList<global::G.ImportApiRequest> request);
        partial void ProcessImportTasksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessImportTasksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Import tasks<br/>
        ///             Import data as labeling tasks in bulk using this API endpoint. You can use this API endpoint to import multiple tasks.<br/>
        ///             One POST request is limited at 250K tasks and 200 MB.<br/>
        ///             **Note:** Imported data is verified against a project *label_config* and must<br/>
        ///             include all variables that were used in the *label_config*. For example,<br/>
        ///             if the label configuration has a *$text* variable, then each item in a data object<br/>
        ///             must include a "text" field.<br/>
        ///             <br/>
        ///             ## Async Import Behavior<br/>
        ///             &lt;hr style="opacity:0.3"&gt;<br/>
        ///             **For non-Community editions, this endpoint processes imports asynchronously.**<br/>
        ///             <br/>
        ///             - The POST request **can fail** for invalid parameters, malformed request body, or other request-level validation errors.<br/>
        ///             - However, **data validation errors** that occur during import processing are handled asynchronously and will not cause the POST request to fail.<br/>
        ///             - Upon successful request validation, a response is returned: `{"import": &lt;import_id&gt;}`<br/>
        ///             - Use the returned `import_id` to poll the GET `/api/projects/{project_id}/imports/{import_id}` endpoint to check the import status and see any data validation errors.<br/>
        ///             - Data-level errors and import failures will only be visible in the GET request response.<br/>
        ///             For Community edition, imports are processed synchronously and return task counts immediately.<br/>
        ///             <br/>
        ///             ## POST requests<br/>
        ///             &lt;hr style="opacity:0.3"&gt;<br/>
        ///             There are three possible ways to import tasks with this endpoint:<br/>
        ///             ### 1. **POST with data**<br/>
        ///             Send JSON tasks as POST data. Only JSON is supported for POSTing files directly.<br/>
        ///             Update this example to specify your authorization token and Label Studio instance host, then run the following from<br/>
        ///             the command line.<br/>
        ///             ```bash<br/>
        ///             curl -H 'Content-Type: application/json' -H 'Authorization: Token abc123' \<br/>
        ///             -X POST 'http://localhost:8000/api/projects/1/import' --data '[{"text": "Some text 1"}, {"text": "Some text 2"}]'<br/>
        ///             ```<br/>
        ///             ### 2. **POST with files**<br/>
        ///             Send tasks as files. You can attach multiple files with different names.<br/>
        ///             - **JSON**: text files in JavaScript object notation format<br/>
        ///             - **CSV**: text files with tables in Comma Separated Values format<br/>
        ///             - **TSV**: text files with tables in Tab Separated Value format<br/>
        ///             - **TXT**: simple text files are similar to CSV with one column and no header, supported for projects with one source only<br/>
        ///             Update this example to specify your authorization token, Label Studio instance host, and file name and path,<br/>
        ///             then run the following from the command line:<br/>
        ///             ```bash<br/>
        ///             curl -H 'Authorization: Token abc123' \<br/>
        ///             -X POST 'http://localhost:8000/api/projects/1/import' -F 'file=@path/to/my_file.csv'<br/>
        ///             ```<br/>
        ///             ### 3. **POST with URL**<br/>
        ///             You can also provide a URL to a file with labeling tasks. Supported file formats are the same as in option 2.<br/>
        ///             ```bash<br/>
        ///             curl -H 'Content-Type: application/json' -H 'Authorization: Token abc123' \<br/>
        ///             -X POST 'http://localhost:8000/api/projects/1/import' \<br/>
        ///             --data '[{"url": "http://example.com/test1.csv"}, {"url": "http://example.com/test2.csv"}]'<br/>
        ///             ```<br/>
        ///             <br/>
        ///         
        /// </summary>
        /// <param name="commitToProject">
        /// Default Value: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="preannotatedFromFields"></param>
        /// <param name="returnTaskIds">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ApiProjectsImportCreateResponse> ImportTasksAsync(
            int id,

            global::System.Collections.Generic.IList<global::G.ImportApiRequest> request,
            bool? commitToProject = default,
            global::System.Collections.Generic.IList<string>? preannotatedFromFields = default,
            bool? returnTaskIds = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareImportTasksArguments(
                httpClient: HttpClient,
                commitToProject: ref commitToProject,
                id: ref id,
                preannotatedFromFields: preannotatedFromFields,
                returnTaskIds: ref returnTaskIds,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ImportTasksSecurityRequirements,
                operationName: "ImportTasksAsync");

            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::G.PathBuilder(
                                path: $"/api/projects/{id}/import",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("commit_to_project", commitToProject?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("preannotated_from_fields", preannotatedFromFields, delimiter: ",", explode: true)
                                .AddOptionalParameter("return_task_ids", returnTaskIds?.ToString().ToLowerInvariant()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareImportTasksRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    commitToProject: commitToProject,
                    id: id,
                    preannotatedFromFields: preannotatedFromFields,
                    returnTaskIds: returnTaskIds,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ImportTasks",
                                methodName: "ImportTasksAsync",
                                pathTemplate: "$\"/api/projects/{id}/import\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ImportTasks",
                                methodName: "ImportTasksAsync",
                                pathTemplate: "$\"/api/projects/{id}/import\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ImportTasks",
                                methodName: "ImportTasksAsync",
                                pathTemplate: "$\"/api/projects/{id}/import\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessImportTasksResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ImportTasks",
                                methodName: "ImportTasksAsync",
                                pathTemplate: "$\"/api/projects/{id}/import\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ImportTasks",
                                methodName: "ImportTasksAsync",
                                pathTemplate: "$\"/api/projects/{id}/import\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad Request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                string? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_400, JsonSerializerOptions);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_400, JsonSerializerOptions);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::G.ApiException<string>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessImportTasksResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.ApiProjectsImportCreateResponse.FromJson(__content, JsonSerializerOptions) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::G.ApiProjectsImportCreateResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}