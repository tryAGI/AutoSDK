//HintName: G.DependabotClient.DependabotListAlertsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotListAlertsForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? state,
            ref string? severity,
            ref string? ecosystem,
            ref string? package,
            ref string? manifest,
            ref global::G.DependabotListAlertsForRepoScope? scope,
            ref global::G.DependabotListAlertsForRepoSort? sort,
            ref global::G.DependabotListAlertsForRepoDirection? direction,
            ref int? page,
            ref int? perPage,
            ref string? before,
            ref string? after,
            ref int? first,
            ref int? last);
        partial void PrepareDependabotListAlertsForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            string? manifest,
            global::G.DependabotListAlertsForRepoScope? scope,
            global::G.DependabotListAlertsForRepoSort? sort,
            global::G.DependabotListAlertsForRepoDirection? direction,
            int? page,
            int? perPage,
            string? before,
            string? after,
            int? first,
            int? last);
        partial void ProcessDependabotListAlertsForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependabotListAlertsForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Dependabot alerts for a repository<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="manifest"></param>
        /// <param name="scope"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="first">
        /// Default Value: 30
        /// </param>
        /// <param name="last"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DependabotAlert>> DependabotListAlertsForRepoAsync(
            string owner,
            string repo,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? manifest = default,
            global::G.DependabotListAlertsForRepoScope? scope = default,
            global::G.DependabotListAlertsForRepoSort? sort = default,
            global::G.DependabotListAlertsForRepoDirection? direction = default,
            int? page = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            int? first = default,
            int? last = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDependabotListAlertsForRepoArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                state: ref state,
                severity: ref severity,
                ecosystem: ref ecosystem,
                package: ref package,
                manifest: ref manifest,
                scope: ref scope,
                sort: ref sort,
                direction: ref direction,
                page: ref page,
                perPage: ref perPage,
                before: ref before,
                after: ref after,
                first: ref first,
                last: ref last);

            var scopeValue = scope switch
            {
                global::G.DependabotListAlertsForRepoScope.Development => "development",
                global::G.DependabotListAlertsForRepoScope.Runtime => "runtime",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.DependabotListAlertsForRepoSort.Created => "created",
                global::G.DependabotListAlertsForRepoSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.DependabotListAlertsForRepoDirection.Asc => "asc",
                global::G.DependabotListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/dependabot/alerts",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("state", state) 
                .AddOptionalParameter("severity", severity) 
                .AddOptionalParameter("ecosystem", ecosystem) 
                .AddOptionalParameter("package", package) 
                .AddOptionalParameter("manifest", manifest) 
                .AddOptionalParameter("scope", scopeValue?.ToString()) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("first", first?.ToString()) 
                .AddOptionalParameter("last", last?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDependabotListAlertsForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                manifest: manifest,
                scope: scope,
                sort: sort,
                direction: direction,
                page: page,
                perPage: perPage,
                before: before,
                after: after,
                first: first,
                last: last);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDependabotListAlertsForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 304)
            {
                string? __content_304 = null;
                if (ReadResponseAsString)
                {
                    __content_304 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_304 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_304,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::G.BasicError? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::G.BasicError.FromJson(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.BasicError? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.BasicError.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Resource not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.BasicError? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.BasicError.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
            // Validation failed, or the endpoint has been spammed.
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.ValidationErrorSimple? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.ValidationErrorSimple.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.ValidationErrorSimple.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ValidationErrorSimple>(
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
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessDependabotListAlertsForRepoResponseContent(
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
                    global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.DependabotAlert>?>(__content, JsonSerializerOptions) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.DependabotAlert>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}