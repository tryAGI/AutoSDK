﻿//HintName: G.ReposClient.ReposListForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposListForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.ReposListForAuthenticatedUserVisibility? visibility,
            ref string? affiliation,
            ref global::G.ReposListForAuthenticatedUserType? type,
            ref global::G.ReposListForAuthenticatedUserSort? sort,
            ref global::G.ReposListForAuthenticatedUserDirection? direction,
            ref int? perPage,
            ref int? page,
            ref global::System.DateTime? since,
            ref global::System.DateTime? before);
        partial void PrepareReposListForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ReposListForAuthenticatedUserVisibility? visibility,
            string? affiliation,
            global::G.ReposListForAuthenticatedUserType? type,
            global::G.ReposListForAuthenticatedUserSort? sort,
            global::G.ReposListForAuthenticatedUserDirection? direction,
            int? perPage,
            int? page,
            global::System.DateTime? since,
            global::System.DateTime? before);
        partial void ProcessReposListForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repositories for the authenticated user<br/>
        /// Lists repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.<br/>
        /// The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.
        /// </summary>
        /// <param name="visibility">
        /// Default Value: all
        /// </param>
        /// <param name="affiliation">
        /// Default Value: owner,collaborator,organization_member
        /// </param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Repository>> ReposListForAuthenticatedUserAsync(
            global::G.ReposListForAuthenticatedUserVisibility? visibility = default,
            string? affiliation = default,
            global::G.ReposListForAuthenticatedUserType? type = default,
            global::G.ReposListForAuthenticatedUserSort? sort = default,
            global::G.ReposListForAuthenticatedUserDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.DateTime? since = default,
            global::System.DateTime? before = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposListForAuthenticatedUserArguments(
                httpClient: HttpClient,
                visibility: ref visibility,
                affiliation: ref affiliation,
                type: ref type,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page,
                since: ref since,
                before: ref before);

            var visibilityValue = visibility switch
            {
                global::G.ReposListForAuthenticatedUserVisibility.All => "all",
                global::G.ReposListForAuthenticatedUserVisibility.Public => "public",
                global::G.ReposListForAuthenticatedUserVisibility.Private => "private",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var typeValue = type switch
            {
                global::G.ReposListForAuthenticatedUserType.All => "all",
                global::G.ReposListForAuthenticatedUserType.Owner => "owner",
                global::G.ReposListForAuthenticatedUserType.Public => "public",
                global::G.ReposListForAuthenticatedUserType.Private => "private",
                global::G.ReposListForAuthenticatedUserType.Member => "member",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.ReposListForAuthenticatedUserSort.Created => "created",
                global::G.ReposListForAuthenticatedUserSort.Updated => "updated",
                global::G.ReposListForAuthenticatedUserSort.Pushed => "pushed",
                global::G.ReposListForAuthenticatedUserSort.FullName => "full_name",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.ReposListForAuthenticatedUserDirection.Asc => "asc",
                global::G.ReposListForAuthenticatedUserDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/user/repos",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("visibility", visibilityValue?.ToString()) 
                .AddOptionalParameter("affiliation", affiliation) 
                .AddOptionalParameter("type", typeValue?.ToString()) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("before", before?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposListForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                visibility: visibility,
                affiliation: affiliation,
                type: type,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page,
                since: since,
                before: before);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposListForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposListForAuthenticatedUserResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Repository>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}