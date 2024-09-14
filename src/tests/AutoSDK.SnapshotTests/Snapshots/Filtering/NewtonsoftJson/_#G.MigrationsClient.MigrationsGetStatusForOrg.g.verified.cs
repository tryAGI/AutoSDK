//HintName: G.MigrationsClient.MigrationsGetStatusForOrg.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsGetStatusForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int migrationId,
            global::System.Collections.Generic.IList<global::G.MigrationsGetStatusForOrgExcludeItem>? exclude);
        partial void PrepareMigrationsGetStatusForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int migrationId,
            global::System.Collections.Generic.IList<global::G.MigrationsGetStatusForOrgExcludeItem>? exclude);
        partial void ProcessMigrationsGetStatusForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsGetStatusForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get an organization migration status<br/>
        /// Fetches the status of a migration.<br/>
        /// The `state` of a migration can be one of the following values:<br/>
        /// *   `pending`, which means the migration hasn't started yet.<br/>
        /// *   `exporting`, which means the migration is in progress.<br/>
        /// *   `exported`, which means the migration finished successfully.<br/>
        /// *   `failed`, which means the migration failed.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="migrationId"></param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Migration> MigrationsGetStatusForOrgAsync(
            string org,
            int migrationId,
            global::System.Collections.Generic.IList<global::G.MigrationsGetStatusForOrgExcludeItem>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMigrationsGetStatusForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                migrationId: ref migrationId,
                exclude: exclude);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/migrations/{migrationId}?{string.Join("&", exclude?.Select(static x => $"exclude={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMigrationsGetStatusForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                migrationId: migrationId,
                exclude: exclude);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMigrationsGetStatusForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMigrationsGetStatusForOrgResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Migration?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}