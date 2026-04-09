//HintName: G.BetaClient.CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPost.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HTTPBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostSecurityRequirement0,
            };
        partial void PrepareCancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string jobId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? temporalNamespace,
            ref string? session,
            global::G.BatchJobCancelRequest request);
        partial void PrepareCancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string jobId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? temporalNamespace,
            string? session,
            global::G.BatchJobCancelRequest request);
        partial void ProcessCancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Cancel Batch Job<br/>
        /// Cancel a running batch processing job.<br/>
        /// Stops processing and marks pending items as cancelled.<br/>
        /// Items currently being processed may still complete.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="temporalNamespace"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchJobCancelResponse> CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostAsync(
            string jobId,

            global::G.BatchJobCancelRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? temporalNamespace = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostArguments(
                httpClient: HttpClient,
                jobId: ref jobId,
                projectId: projectId,
                organizationId: organizationId,
                temporalNamespace: ref temporalNamespace,
                session: ref session,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostSecurityRequirements,
                operationName: "CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/beta/batch-processing/{jobId}/cancel",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            if (temporalNamespace != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("temporal-namespace", temporalNamespace.ToString());
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
            PrepareCancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                jobId: jobId,
                projectId: projectId,
                organizationId: organizationId,
                temporalNamespace: temporalNamespace,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.BatchJobCancelResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.BatchJobCancelResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Cancel Batch Job<br/>
        /// Cancel a running batch processing job.<br/>
        /// Stops processing and marks pending items as cancelled.<br/>
        /// Items currently being processed may still complete.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="temporalNamespace"></param>
        /// <param name="session"></param>
        /// <param name="reason">
        /// Optional reason for cancelling the job
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchJobCancelResponse> CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? temporalNamespace = default,
            string? session = default,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BatchJobCancelRequest
            {
                Reason = reason,
            };

            return await CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostAsync(
                jobId: jobId,
                projectId: projectId,
                organizationId: organizationId,
                temporalNamespace: temporalNamespace,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}