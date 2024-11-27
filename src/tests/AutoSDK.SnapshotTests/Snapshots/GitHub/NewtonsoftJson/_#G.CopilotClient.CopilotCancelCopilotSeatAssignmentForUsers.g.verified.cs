//HintName: G.CopilotClient.CopilotCancelCopilotSeatAssignmentForUsers.g.cs

#nullable enable

namespace G
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotCancelCopilotSeatAssignmentForUsersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.CopilotCancelCopilotSeatAssignmentForUsersRequest request);
        partial void PrepareCopilotCancelCopilotSeatAssignmentForUsersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.CopilotCancelCopilotSeatAssignmentForUsersRequest request);
        partial void ProcessCopilotCancelCopilotSeatAssignmentForUsersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotCancelCopilotSeatAssignmentForUsersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove users from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in beta and is subject to change.<br/>
        /// Cancels the Copilot seat assignment for each user specified.<br/>
        /// This will cause the specified users to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.<br/>
        /// For more information about Copilot pricing, see "[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)".<br/>
        /// For more information about disabling access to Copilot Business or Enterprise, see "[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)".<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CopilotCancelCopilotSeatAssignmentForUsersResponse> CopilotCancelCopilotSeatAssignmentForUsersAsync(
            string org,
            global::G.CopilotCancelCopilotSeatAssignmentForUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCopilotCancelCopilotSeatAssignmentForUsersArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/copilot/billing/selected_users",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCopilotCancelCopilotSeatAssignmentForUsersRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCopilotCancelCopilotSeatAssignmentForUsersResponse(
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
            // Requires authentication
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::G.BasicError? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::G.BasicError.FromJson(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
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
            // 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
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
                ProcessCopilotCancelCopilotSeatAssignmentForUsersResponseContent(
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
                    global::G.CopilotCancelCopilotSeatAssignmentForUsersResponse.FromJson(__content, JsonSerializerOptions) ??
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
                    await global::G.CopilotCancelCopilotSeatAssignmentForUsersResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Remove users from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in beta and is subject to change.<br/>
        /// Cancels the Copilot seat assignment for each user specified.<br/>
        /// This will cause the specified users to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.<br/>
        /// For more information about Copilot pricing, see "[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)".<br/>
        /// For more information about disabling access to Copilot Business or Enterprise, see "[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)".<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members for which to revoke access to GitHub Copilot.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CopilotCancelCopilotSeatAssignmentForUsersResponse> CopilotCancelCopilotSeatAssignmentForUsersAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedUsernames,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CopilotCancelCopilotSeatAssignmentForUsersRequest
            {
                SelectedUsernames = selectedUsernames,
            };

            return await CopilotCancelCopilotSeatAssignmentForUsersAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}