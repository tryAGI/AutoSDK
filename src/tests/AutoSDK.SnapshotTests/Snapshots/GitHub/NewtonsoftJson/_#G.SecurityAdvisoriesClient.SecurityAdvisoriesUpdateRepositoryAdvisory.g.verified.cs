//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesUpdateRepositoryAdvisory.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        partial void PrepareSecurityAdvisoriesUpdateRepositoryAdvisoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string ghsaId,
            global::G.RepositoryAdvisoryUpdate request);
        partial void PrepareSecurityAdvisoriesUpdateRepositoryAdvisoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string ghsaId,
            global::G.RepositoryAdvisoryUpdate request);
        partial void ProcessSecurityAdvisoriesUpdateRepositoryAdvisoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityAdvisoriesUpdateRepositoryAdvisoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a repository security advisory<br/>
        /// Update a repository security advisory using its GitHub Security Advisory (GHSA) identifier.<br/>
        /// In order to update any security advisory, the authenticated user must be a security manager or administrator of that repository,<br/>
        /// or a collaborator on the repository security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            global::G.RepositoryAdvisoryUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSecurityAdvisoriesUpdateRepositoryAdvisoryArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                ghsaId: ref ghsaId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/security-advisories/{ghsaId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSecurityAdvisoriesUpdateRepositoryAdvisoryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                ghsaId: ghsaId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSecurityAdvisoriesUpdateRepositoryAdvisoryResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessSecurityAdvisoriesUpdateRepositoryAdvisoryResponseContent(
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
                    global::G.RepositoryAdvisory.FromJson(__content, JsonSerializerOptions) ??
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
                    await global::G.RepositoryAdvisory.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update a repository security advisory<br/>
        /// Update a repository security advisory using its GitHub Security Advisory (GHSA) identifier.<br/>
        /// In order to update any security advisory, the authenticated user must be a security manager or administrator of that repository,<br/>
        /// or a collaborator on the repository security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="summary">
        /// A short summary of the advisory.
        /// </param>
        /// <param name="description">
        /// A detailed description of what the advisory impacts.
        /// </param>
        /// <param name="cveId">
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </param>
        /// <param name="vulnerabilities">
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </param>
        /// <param name="cweIds">
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </param>
        /// <param name="credits">
        /// A list of users receiving credit for their participation in the security advisory.
        /// </param>
        /// <param name="severity">
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </param>
        /// <param name="cvssVectorString">
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </param>
        /// <param name="state">
        /// The state of the advisory.
        /// </param>
        /// <param name="collaboratingUsers">
        /// A list of usernames who have been granted write access to the advisory.
        /// </param>
        /// <param name="collaboratingTeams">
        /// A list of team slugs which have been granted write access to the advisory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            string? summary = default,
            string? description = default,
            string? cveId = default,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateVulnerabilitie>? vulnerabilities = default,
            global::System.Collections.Generic.IList<string>? cweIds = default,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateCredit>? credits = default,
            global::G.RepositoryAdvisoryUpdateSeverity? severity = default,
            string? cvssVectorString = default,
            global::G.RepositoryAdvisoryUpdateState? state = default,
            global::System.Collections.Generic.IList<string>? collaboratingUsers = default,
            global::System.Collections.Generic.IList<string>? collaboratingTeams = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.RepositoryAdvisoryUpdate
            {
                Summary = summary,
                Description = description,
                CveId = cveId,
                Vulnerabilities = vulnerabilities,
                CweIds = cweIds,
                Credits = credits,
                Severity = severity,
                CvssVectorString = cvssVectorString,
                State = state,
                CollaboratingUsers = collaboratingUsers,
                CollaboratingTeams = collaboratingTeams,
            };

            return await SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
                owner: owner,
                repo: repo,
                ghsaId: ghsaId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}