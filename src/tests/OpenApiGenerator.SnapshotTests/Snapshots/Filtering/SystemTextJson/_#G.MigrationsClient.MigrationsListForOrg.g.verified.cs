//HintName: G.MigrationsClient.MigrationsListForOrg.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        /// <summary>
        /// List organization migrations<br/>
        /// Lists the most recent migrations, including both exports (which can be started through the REST API) and imports (which cannot be started using the REST API).<br/>
        /// A list of `repositories` is only returned for export migrations.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Migration>> MigrationsListForOrgAsync(
            string org,
            int perPage,
            int page,
            global::System.Collections.Generic.IList<global::G.MigrationsListForOrgExclude> exclude,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/orgs/{org}/migrations?per_page={perPage}&page={page}&{string.Join("&", exclude.Select(static x => $"exclude={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Migration>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}