//HintName: G.ParsingClient.ScreenshotApiV1ParsingScreenshotPost.g.cs

#nullable enable

namespace G
{
    public partial class ParsingClient
    {
        partial void PrepareScreenshotApiV1ParsingScreenshotPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Guid? organizationId,
            global::System.Guid? projectId,
            ref string? session,
            global::G.BodyScreenshotApiV1ParsingScreenshotPost request);
        partial void PrepareScreenshotApiV1ParsingScreenshotPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? organizationId,
            global::System.Guid? projectId,
            string? session,
            global::G.BodyScreenshotApiV1ParsingScreenshotPost request);
        partial void ProcessScreenshotApiV1ParsingScreenshotPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessScreenshotApiV1ParsingScreenshotPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Screenshot
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ParsingJob> ScreenshotApiV1ParsingScreenshotPostAsync(

            global::G.BodyScreenshotApiV1ParsingScreenshotPost request,
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareScreenshotApiV1ParsingScreenshotPostArguments(
                httpClient: HttpClient,
                organizationId: organizationId,
                projectId: projectId,
                session: ref session,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v1/parsing/screenshot",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("organization_id", organizationId?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString()) 
                ; 
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (organizationId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{organizationId}"),
                    name: "\"organization_id\"");
            } 
            if (projectId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{projectId}"),
                    name: "\"project_id\"");
            } 
            if (session != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{session}"),
                    name: "\"session\"");
            } 
            if (request.File != default)
            {

                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentFile,
                    name: "\"file\"",
                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                if (__contentFile.Headers.ContentDisposition != null)
                {
                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.DoNotCache != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoNotCache}"),
                    name: "\"do_not_cache\"");
            } 
            if (request.HttpProxy != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HttpProxy}"),
                    name: "\"http_proxy\"");
            } 
            if (request.InputS3Path != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InputS3Path}"),
                    name: "\"input_s3_path\"");
            } 
            if (request.InputS3Region != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InputS3Region}"),
                    name: "\"input_s3_region\"");
            } 
            if (request.InputUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InputUrl}"),
                    name: "\"input_url\"");
            } 
            if (request.InvalidateCache != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InvalidateCache}"),
                    name: "\"invalidate_cache\"");
            } 
            if (request.MaxPages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MaxPages}"),
                    name: "\"max_pages\"");
            } 
            if (request.OutputS3PathPrefix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputS3PathPrefix}"),
                    name: "\"output_s3_path_prefix\"");
            } 
            if (request.OutputS3Region != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputS3Region}"),
                    name: "\"output_s3_region\"");
            } 
            if (request.TargetPages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TargetPages}"),
                    name: "\"target_pages\"");
            } 
            if (request.WebhookUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.WebhookUrl}"),
                    name: "\"webhook_url\"");
            } 
            if (request.WebhookConfigurations != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.WebhookConfigurations}"),
                    name: "\"webhook_configurations\"");
            } 
            if (request.JobTimeoutInSeconds != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.JobTimeoutInSeconds}"),
                    name: "\"job_timeout_in_seconds\"");
            } 
            if (request.JobTimeoutExtraTimePerPageInSeconds != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.JobTimeoutExtraTimePerPageInSeconds}"),
                    name: "\"job_timeout_extra_time_per_page_in_seconds\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareScreenshotApiV1ParsingScreenshotPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                organizationId: organizationId,
                projectId: projectId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessScreenshotApiV1ParsingScreenshotPostResponse(
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
                ProcessScreenshotApiV1ParsingScreenshotPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ParsingJob.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ParsingJob.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Screenshot
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="doNotCache">
        /// Default Value: false
        /// </param>
        /// <param name="httpProxy"></param>
        /// <param name="inputS3Path"></param>
        /// <param name="inputS3Region"></param>
        /// <param name="inputUrl"></param>
        /// <param name="invalidateCache">
        /// Default Value: false
        /// </param>
        /// <param name="maxPages"></param>
        /// <param name="outputS3PathPrefix"></param>
        /// <param name="outputS3Region"></param>
        /// <param name="targetPages"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookConfigurations"></param>
        /// <param name="jobTimeoutInSeconds"></param>
        /// <param name="jobTimeoutExtraTimePerPageInSeconds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ParsingJob> ScreenshotApiV1ParsingScreenshotPostAsync(
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            byte[]? file = default,
            string? filename = default,
            bool? doNotCache = default,
            string? httpProxy = default,
            string? inputS3Path = default,
            string? inputS3Region = default,
            string? inputUrl = default,
            bool? invalidateCache = default,
            int? maxPages = default,
            string? outputS3PathPrefix = default,
            string? outputS3Region = default,
            string? targetPages = default,
            string? webhookUrl = default,
            string? webhookConfigurations = default,
            double? jobTimeoutInSeconds = default,
            double? jobTimeoutExtraTimePerPageInSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyScreenshotApiV1ParsingScreenshotPost
            {
                File = file,
                Filename = filename,
                DoNotCache = doNotCache,
                HttpProxy = httpProxy,
                InputS3Path = inputS3Path,
                InputS3Region = inputS3Region,
                InputUrl = inputUrl,
                InvalidateCache = invalidateCache,
                MaxPages = maxPages,
                OutputS3PathPrefix = outputS3PathPrefix,
                OutputS3Region = outputS3Region,
                TargetPages = targetPages,
                WebhookUrl = webhookUrl,
                WebhookConfigurations = webhookConfigurations,
                JobTimeoutInSeconds = jobTimeoutInSeconds,
                JobTimeoutExtraTimePerPageInSeconds = jobTimeoutExtraTimePerPageInSeconds,
            };

            return await ScreenshotApiV1ParsingScreenshotPostAsync(
                organizationId: organizationId,
                projectId: projectId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}