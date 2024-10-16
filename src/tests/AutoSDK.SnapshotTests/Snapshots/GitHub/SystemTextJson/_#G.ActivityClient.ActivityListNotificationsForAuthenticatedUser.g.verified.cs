﻿//HintName: G.ActivityClient.ActivityListNotificationsForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        partial void PrepareActivityListNotificationsForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? all,
            ref bool? participating,
            ref global::System.DateTime? since,
            ref global::System.DateTime? before,
            ref int? page,
            ref int? perPage);
        partial void PrepareActivityListNotificationsForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? all,
            bool? participating,
            global::System.DateTime? since,
            global::System.DateTime? before,
            int? page,
            int? perPage);
        partial void ProcessActivityListNotificationsForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActivityListNotificationsForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List notifications for the authenticated user<br/>
        /// List all notifications for the current user, sorted by most recently updated.
        /// </summary>
        /// <param name="all">
        /// Default Value: false
        /// </param>
        /// <param name="participating">
        /// Default Value: false
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Thread>> ActivityListNotificationsForAuthenticatedUserAsync(
            bool? all = false,
            bool? participating = false,
            global::System.DateTime? since = default,
            global::System.DateTime? before = default,
            int? page = 1,
            int? perPage = 50,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActivityListNotificationsForAuthenticatedUserArguments(
                httpClient: _httpClient,
                all: ref all,
                participating: ref participating,
                since: ref since,
                before: ref before,
                page: ref page,
                perPage: ref perPage);

            var __pathBuilder = new PathBuilder(
                path: "/notifications",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("all", all?.ToString()) 
                .AddOptionalParameter("participating", participating?.ToString()) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("before", before?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActivityListNotificationsForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                all: all,
                participating: participating,
                since: since,
                before: before,
                page: page,
                perPage: perPage);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActivityListNotificationsForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActivityListNotificationsForAuthenticatedUserResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Thread>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}