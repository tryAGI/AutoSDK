//HintName: G.ActivityClient.ActivityListNotificationsForAuthenticatedUser.g.cs

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
            bool? all = default,
            bool? participating = default,
            global::System.DateTime? since = default,
            global::System.DateTime? before = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActivityListNotificationsForAuthenticatedUserArguments(
                httpClient: HttpClient,
                all: ref all,
                participating: ref participating,
                since: ref since,
                before: ref before,
                page: ref page,
                perPage: ref perPage);

            var __pathBuilder = new PathBuilder(
                path: "/notifications",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("all", all?.ToString()) 
                .AddOptionalParameter("participating", participating?.ToString()) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("before", before?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActivityListNotificationsForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                all: all,
                participating: participating,
                since: since,
                before: before,
                page: page,
                perPage: perPage);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActivityListNotificationsForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessActivityListNotificationsForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Thread>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}