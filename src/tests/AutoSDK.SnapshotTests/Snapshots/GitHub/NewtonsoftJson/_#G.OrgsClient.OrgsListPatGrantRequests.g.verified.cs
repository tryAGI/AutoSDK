﻿//HintName: G.OrgsClient.OrgsListPatGrantRequests.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListPatGrantRequestsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int? perPage,
            ref int? page,
            ref global::G.OrgsListPatGrantRequestsSort? sort,
            ref global::G.OrgsListPatGrantRequestsDirection? direction,
            global::System.Collections.Generic.IList<string>? owner,
            ref string? repository,
            ref string? permission,
            ref global::System.DateTime? lastUsedBefore,
            ref global::System.DateTime? lastUsedAfter);
        partial void PrepareOrgsListPatGrantRequestsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int? perPage,
            int? page,
            global::G.OrgsListPatGrantRequestsSort? sort,
            global::G.OrgsListPatGrantRequestsDirection? direction,
            global::System.Collections.Generic.IList<string>? owner,
            string? repository,
            string? permission,
            global::System.DateTime? lastUsedBefore,
            global::System.DateTime? lastUsedAfter);
        partial void ProcessOrgsListPatGrantRequestsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListPatGrantRequestsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List requests to access organization resources with fine-grained personal access tokens<br/>
        /// Lists requests from organization members to access organization resources with a fine-grained personal access token.<br/>
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsListPatGrantRequestsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::G.OrgsListPatGrantRequestsSort? sort = default,
            global::G.OrgsListPatGrantRequestsDirection? direction = default,
            global::System.Collections.Generic.IList<string>? owner = default,
            string? repository = default,
            string? permission = default,
            global::System.DateTime? lastUsedBefore = default,
            global::System.DateTime? lastUsedAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsListPatGrantRequestsArguments(
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

            var sortValue = sort switch
            {
                global::G.OrgsListPatGrantRequestsSort.CreatedAt => "created_at",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.OrgsListPatGrantRequestsDirection.Asc => "asc",
                global::G.OrgsListPatGrantRequestsDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/personal-access-token-requests",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsListPatGrantRequestsRequest(
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
            ProcessOrgsListPatGrantRequestsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsListPatGrantRequestsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.BasicError.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}