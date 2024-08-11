//HintName: G.MigrationsClient.MigrationsListForOrg.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsListForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int perPage,
            ref int page,
            global::System.Collections.Generic.IList<global::G.MigrationsListForOrgExcludeItem>? exclude);
        partial void PrepareMigrationsListForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int perPage,
            int page,
            global::System.Collections.Generic.IList<global::G.MigrationsListForOrgExcludeItem>? exclude);
        partial void ProcessMigrationsListForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsListForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organization migrations<br/>
        /// Lists the most recent migrations, including both exports (which can be started through the REST API) and imports (which cannot be started using the REST API).<br/>
        /// A list of `repositories` is only returned for export migrations.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Migration>> MigrationsListForOrgAsync(
            string org,
            int perPage,
            int page,
            global::System.Collections.Generic.IList<global::G.MigrationsListForOrgExcludeItem>? exclude,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMigrationsListForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                perPage: ref perPage,
                page: ref page,
                exclude: exclude);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/migrations?per_page={perPage}&page={page}&{string.Join("&", exclude?.Select(static x => $"exclude={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMigrationsListForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                perPage: perPage,
                page: page,
                exclude: exclude);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMigrationsListForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMigrationsListForOrgResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Migration>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}