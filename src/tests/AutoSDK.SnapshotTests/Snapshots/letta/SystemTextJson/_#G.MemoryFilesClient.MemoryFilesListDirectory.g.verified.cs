//HintName: G.MemoryFilesClient.MemoryFilesListDirectory.g.cs

#nullable enable

namespace G
{
    public partial class MemoryFilesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_MemoryFilesListDirectorySecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_MemoryFilesListDirectorySecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_MemoryFilesListDirectorySecurityRequirement0,
            };
        partial void PrepareMemoryFilesListDirectoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            ref string? path,
            ref double? depth,
            ref string? @ref);
        partial void PrepareMemoryFilesListDirectoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            string? path,
            double? depth,
            string? @ref);
        partial void ProcessMemoryFilesListDirectoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoryFilesListDirectoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Directory<br/>
        /// List immediate children of a directory in the agent memory repo (single level).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="path"></param>
        /// <param name="depth"></param>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MemoryFilesListDirectoryResponse> MemoryFilesListDirectoryAsync(
            string agentId,
            string? path = default,
            double? depth = default,
            string? @ref = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareMemoryFilesListDirectoryArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                path: ref path,
                depth: ref depth,
                @ref: ref @ref);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MemoryFilesListDirectorySecurityRequirements,
                operationName: "MemoryFilesListDirectoryAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/agents/{agentId}/memory-files/directory",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("path", path)
                .AddOptionalParameter("depth", depth?.ToString())
                .AddOptionalParameter("ref", @ref) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMemoryFilesListDirectoryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                path: path,
                depth: depth,
                @ref: @ref);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMemoryFilesListDirectoryResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 404
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.MemoryFilesListDirectoryResponse2? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.MemoryFilesListDirectoryResponse2.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.MemoryFilesListDirectoryResponse2.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.MemoryFilesListDirectoryResponse2>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 501
            if ((int)__response.StatusCode == 501)
            {
                string? __content_501 = null;
                global::System.Exception? __exception_501 = null;
                global::G.MemoryFilesListDirectoryResponse3? __value_501 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_501 = global::G.MemoryFilesListDirectoryResponse3.FromJson(__content_501, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_501 = global::G.MemoryFilesListDirectoryResponse3.FromJson(__content_501, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_501 = __ex;
                }

                throw new global::G.ApiException<global::G.MemoryFilesListDirectoryResponse3>(
                    message: __content_501 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_501,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_501,
                    ResponseObject = __value_501,
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
                ProcessMemoryFilesListDirectoryResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.MemoryFilesListDirectoryResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.MemoryFilesListDirectoryResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}