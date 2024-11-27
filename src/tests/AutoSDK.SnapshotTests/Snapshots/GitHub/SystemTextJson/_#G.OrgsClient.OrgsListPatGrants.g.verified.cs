//HintName: G.OrgsClient.OrgsListPatGrants.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListPatGrantsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int? perPage,
            ref int? page,
            ref global::G.OrgsListPatGrantsSort? sort,
            ref global::G.OrgsListPatGrantsDirection? direction,
            global::System.Collections.Generic.IList<string>? owner,
            ref string? repository,
            ref string? permission,
            ref global::System.DateTime? lastUsedBefore,
            ref global::System.DateTime? lastUsedAfter);
        partial void PrepareOrgsListPatGrantsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int? perPage,
            int? page,
            global::G.OrgsListPatGrantsSort? sort,
            global::G.OrgsListPatGrantsDirection? direction,
            global::System.Collections.Generic.IList<string>? owner,
            string? repository,
            string? permission,
            global::System.DateTime? lastUsedBefore,
            global::System.DateTime? lastUsedAfter);
        partial void ProcessOrgsListPatGrantsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListPatGrantsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List fine-grained personal access tokens with access to organization resources<br/>
        /// Lists approved fine-grained personal access tokens owned by organization members that can access organization resources.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="owner">
        /// Example: owner[]=octocat1,owner[]=octocat2
        /// </param>
        /// <param name="repository">
        /// Example: Hello-World
        /// </param>
        /// <param name="permission">
        /// Example: issues_read
        /// </param>
        /// <param name="lastUsedBefore"></param>
        /// <param name="lastUsedAfter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationProgrammaticAccessGrant>> OrgsListPatGrantsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::G.OrgsListPatGrantsSort? sort = default,
            global::G.OrgsListPatGrantsDirection? direction = default,
            global::System.Collections.Generic.IList<string>? owner = default,
            string? repository = default,
            string? permission = default,
            global::System.DateTime? lastUsedBefore = default,
            global::System.DateTime? lastUsedAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsListPatGrantsArguments(
                httpClient: HttpClient,
                org: ref org,
                perPage: ref perPage,
                page: ref page,
                sort: ref sort,
                direction: ref direction,
                owner: owner,
                repository: ref repository,
                permission: ref permission,
                lastUsedBefore: ref lastUsedBefore,
                lastUsedAfter: ref lastUsedAfter);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/personal-access-tokens",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("owner", owner, delimiter: ",", explode: true) 
                .AddOptionalParameter("repository", repository) 
                .AddOptionalParameter("permission", permission) 
                .AddOptionalParameter("last_used_before", lastUsedBefore?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("last_used_after", lastUsedAfter?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
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
            PrepareOrgsListPatGrantsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                perPage: perPage,
                page: page,
                sort: sort,
                direction: direction,
                owner: owner,
                repository: repository,
                permission: permission,
                lastUsedBefore: lastUsedBefore,
                lastUsedAfter: lastUsedAfter);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsListPatGrantsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Internal Error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::G.BasicError? __value_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = global::G.BasicError.FromJson(__content_500, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_500, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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
                global::G.ValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.ValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.ValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ValidationError>(
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessOrgsListPatGrantsResponseContent(
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
                    global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.OrganizationProgrammaticAccessGrant>?>(__content, JsonSerializerOptions) ??
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
                    await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.IList<global::G.OrganizationProgrammaticAccessGrant>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}