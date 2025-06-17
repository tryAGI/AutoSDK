﻿//HintName: G.CodeScanningClient.CodeScanningListRecentAnalyses.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningListRecentAnalysesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? toolName,
            ref string? toolGuid,
            ref int? page,
            ref int? perPage,
            ref int? pr,
            ref string? @ref,
            ref string? sarifId,
            ref global::G.CodeScanningListRecentAnalysesDirection? direction,
            ref global::G.CodeScanningListRecentAnalysesSort? sort);
        partial void PrepareCodeScanningListRecentAnalysesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? toolName,
            string? toolGuid,
            int? page,
            int? perPage,
            int? pr,
            string? @ref,
            string? sarifId,
            global::G.CodeScanningListRecentAnalysesDirection? direction,
            global::G.CodeScanningListRecentAnalysesSort? sort);
        partial void ProcessCodeScanningListRecentAnalysesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningListRecentAnalysesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List code scanning analyses for a repository<br/>
        /// Lists the details of all code scanning analyses for a repository,<br/>
        /// starting with the most recent.<br/>
        /// The response is paginated and you can use the `page` and `per_page` parameters<br/>
        /// to list the analyses you're interested in.<br/>
        /// By default 30 analyses are listed per page.<br/>
        /// The `rules_count` field in the response give the number of rules<br/>
        /// that were run in the analysis.<br/>
        /// For very old analyses this data is not available,<br/>
        /// and `0` is returned in this field.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** The `tool_name` field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the `tool` field.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="toolName">
        /// The name of the tool used to generate the code scanning analysis.
        /// </param>
        /// <param name="toolGuid">
        /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="pr"></param>
        /// <param name="ref">
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </param>
        /// <param name="sarifId">
        /// An identifier for the upload.<br/>
        /// Example: 6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeScanningAnalysis>> CodeScanningListRecentAnalysesAsync(
            string owner,
            string repo,
            string? toolName = default,
            string? toolGuid = default,
            int? page = default,
            int? perPage = default,
            int? pr = default,
            string? @ref = default,
            string? sarifId = default,
            global::G.CodeScanningListRecentAnalysesDirection? direction = default,
            global::G.CodeScanningListRecentAnalysesSort? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCodeScanningListRecentAnalysesArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                toolName: ref toolName,
                toolGuid: ref toolGuid,
                page: ref page,
                perPage: ref perPage,
                pr: ref pr,
                @ref: ref @ref,
                sarifId: ref sarifId,
                direction: ref direction,
                sort: ref sort);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/repos/{owner}/{repo}/code-scanning/analyses",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("tool_name", toolName) 
                .AddOptionalParameter("tool_guid", toolGuid) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("pr", pr?.ToString()) 
                .AddOptionalParameter("ref", @ref) 
                .AddOptionalParameter("sarif_id", sarifId) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
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
            PrepareCodeScanningListRecentAnalysesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                toolName: toolName,
                toolGuid: toolGuid,
                page: page,
                perPage: perPage,
                pr: pr,
                @ref: @ref,
                sarifId: sarifId,
                direction: direction,
                sort: sort);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodeScanningListRecentAnalysesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Response if GitHub Advanced Security is not enabled for this repository
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
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
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
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
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
            // Service unavailable
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::G.CodeScanningListRecentAnalysesResponse? __value_503 = null;
                if (ReadResponseAsString)
                {
                    __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = global::G.CodeScanningListRecentAnalysesResponse.FromJson(__content_503, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = await global::G.CodeScanningListRecentAnalysesResponse.FromJsonStreamAsync(__contentStream_503, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CodeScanningListRecentAnalysesResponse>(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
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
                ProcessCodeScanningListRecentAnalysesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.CodeScanningAnalysis>?>(__content, JsonSerializerOptions) ??
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
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.IList<global::G.CodeScanningAnalysis>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
    }
}