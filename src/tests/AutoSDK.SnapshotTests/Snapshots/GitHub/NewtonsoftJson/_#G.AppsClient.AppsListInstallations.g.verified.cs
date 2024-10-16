﻿//HintName: G.AppsClient.AppsListInstallations.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        partial void PrepareAppsListInstallationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? perPage,
            ref int? page,
            ref global::System.DateTime? since,
            ref string? outdated);
        partial void PrepareAppsListInstallationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? perPage,
            int? page,
            global::System.DateTime? since,
            string? outdated);
        partial void ProcessAppsListInstallationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppsListInstallationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List installations for the authenticated app<br/>
        /// The permissions the installation has are included under the `permissions` key.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="since"></param>
        /// <param name="outdated"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Installation>> AppsListInstallationsAsync(
            int? perPage = 30,
            int? page = 1,
            global::System.DateTime? since = default,
            string? outdated = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAppsListInstallationsArguments(
                httpClient: _httpClient,
                perPage: ref perPage,
                page: ref page,
                since: ref since,
                outdated: ref outdated);

            var __pathBuilder = new PathBuilder(
                path: "/app/installations",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("outdated", outdated) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAppsListInstallationsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                perPage: perPage,
                page: page,
                since: since,
                outdated: outdated);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAppsListInstallationsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAppsListInstallationsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Installation>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}