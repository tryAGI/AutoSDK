//HintName: G.OrganizationsClient.Assign.g.cs

#nullable enable

namespace G
{
    public partial class OrganizationsClient
    {
        partial void PrepareAssignArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref double? excludeProjectId,
            ref double? excludeWorkspaceId,
            ref int id,
            ref bool? isDeleted,
            ref string? role,
            ref string? tags,
            ref string? userLastActivityGte,
            ref string? userLastActivityLte,
            global::G.BulkOrganizationMemberTagAssignmentRequest request);
        partial void PrepareAssignRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            double? excludeProjectId,
            double? excludeWorkspaceId,
            int id,
            bool? isDeleted,
            string? role,
            string? tags,
            string? userLastActivityGte,
            string? userLastActivityLte,
            global::G.BulkOrganizationMemberTagAssignmentRequest request);
        partial void ProcessAssignResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAssignResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ✨ Bulk assign tags to organization members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Assign tags to multiple organization members in bulk.
        /// </summary>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="role"></param>
        /// <param name="tags"></param>
        /// <param name="userLastActivityGte"></param>
        /// <param name="userLastActivityLte"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ApiOrganizationsMemberTagsAssignmentsCreateResponse> AssignAsync(
            int id,

            global::G.BulkOrganizationMemberTagAssignmentRequest request,
            double? excludeProjectId = default,
            double? excludeWorkspaceId = default,
            bool? isDeleted = default,
            string? role = default,
            string? tags = default,
            string? userLastActivityGte = default,
            string? userLastActivityLte = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAssignArguments(
                httpClient: HttpClient,
                excludeProjectId: ref excludeProjectId,
                excludeWorkspaceId: ref excludeWorkspaceId,
                id: ref id,
                isDeleted: ref isDeleted,
                role: ref role,
                tags: ref tags,
                userLastActivityGte: ref userLastActivityGte,
                userLastActivityLte: ref userLastActivityLte,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/organizations/{id}/member-tags/assignments",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("exclude_project_id", excludeProjectId?.ToString())
                .AddOptionalParameter("exclude_workspace_id", excludeWorkspaceId?.ToString())
                .AddOptionalParameter("is_deleted", isDeleted?.ToString().ToLowerInvariant())
                .AddOptionalParameter("role", role)
                .AddOptionalParameter("tags", tags)
                .AddOptionalParameter("user__last_activity__gte", userLastActivityGte)
                .AddOptionalParameter("user__last_activity__lte", userLastActivityLte) 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAssignRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                excludeProjectId: excludeProjectId,
                excludeWorkspaceId: excludeWorkspaceId,
                id: id,
                isDeleted: isDeleted,
                role: role,
                tags: tags,
                userLastActivityGte: userLastActivityGte,
                userLastActivityLte: userLastActivityLte,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAssignResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
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
                ProcessAssignResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ApiOrganizationsMemberTagsAssignmentsCreateResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ApiOrganizationsMemberTagsAssignmentsCreateResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// ✨ Bulk assign tags to organization members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Assign tags to multiple organization members in bulk.
        /// </summary>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="role"></param>
        /// <param name="tags"></param>
        /// <param name="userLastActivityGte"></param>
        /// <param name="userLastActivityLte"></param>
        /// <param name="all">
        /// If true, assign tags to all organization members. If false, assign tags to the provided users.
        /// </param>
        /// <param name="excluded">
        /// List of user IDs to exclude from the assignment.
        /// </param>
        /// <param name="included">
        /// List of user IDs to include in the assignment.
        /// </param>
        /// <param name="overwrite">
        /// If true, replace all existing tag assignments for each user with the provided ones. If false, only add new assignments.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestTags">
        /// List of tag IDs to assign.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ApiOrganizationsMemberTagsAssignmentsCreateResponse> AssignAsync(
            int id,
            bool all,
            double? excludeProjectId = default,
            double? excludeWorkspaceId = default,
            bool? isDeleted = default,
            string? role = default,
            string? tags = default,
            string? userLastActivityGte = default,
            string? userLastActivityLte = default,
            global::System.Collections.Generic.IList<int>? excluded = default,
            global::System.Collections.Generic.IList<int>? included = default,
            bool? overwrite = default,
            global::System.Collections.Generic.IList<int>? requestTags = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BulkOrganizationMemberTagAssignmentRequest
            {
                All = all,
                Excluded = excluded,
                Included = included,
                Overwrite = overwrite,
                Tags = requestTags,
            };

            return await AssignAsync(
                excludeProjectId: excludeProjectId,
                excludeWorkspaceId: excludeWorkspaceId,
                id: id,
                isDeleted: isDeleted,
                role: role,
                tags: tags,
                userLastActivityGte: userLastActivityGte,
                userLastActivityLte: userLastActivityLte,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}