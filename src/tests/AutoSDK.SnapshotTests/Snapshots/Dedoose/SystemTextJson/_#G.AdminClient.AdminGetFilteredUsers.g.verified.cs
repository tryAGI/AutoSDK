﻿//HintName: G.AdminClient.AdminGetFilteredUsers.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminGetFilteredUsersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? filter,
            ref int? maxResults);
        partial void PrepareAdminGetFilteredUsersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? filter,
            int? maxResults);
        partial void ProcessAdminGetFilteredUsersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminGetFilteredUsersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetFilteredUsers.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> AdminGetFilteredUsersAsync(
            string? token = default,
            string? filter = default,
            int? maxResults = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAdminGetFilteredUsersArguments(
                httpClient: HttpClient,
                token: ref token,
                filter: ref filter,
                maxResults: ref maxResults);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/admin/getfilteredusers",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("maxResults", maxResults?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAdminGetFilteredUsersRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                filter: filter,
                maxResults: maxResults);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAdminGetFilteredUsersResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessAdminGetFilteredUsersResponseContent(
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

            return __content;
        }
    }
}