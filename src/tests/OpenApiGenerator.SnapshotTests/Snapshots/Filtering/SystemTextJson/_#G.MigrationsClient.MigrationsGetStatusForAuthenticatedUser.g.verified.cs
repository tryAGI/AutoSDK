//HintName: G.MigrationsClient.MigrationsGetStatusForAuthenticatedUser.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        /// <summary>
        /// Get a user migration status<br/>
        /// Fetches a single user migration. The response includes the `state` of the migration, which can be one of the following values:<br/>
        /// *   `pending` - the migration hasn't started yet.<br/>
        /// *   `exporting` - the migration is in progress.<br/>
        /// *   `exported` - the migration finished successfully.<br/>
        /// *   `failed` - the migration failed.<br/>
        /// Once the migration has been `exported` you can [download the migration archive](https://docs.github.com/rest/migrations/users#download-a-user-migration-archive).
        /// </summary>
        /// <param name="migrationId"></param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Migration> MigrationsGetStatusForAuthenticatedUserAsync(
            int migrationId,
            global::System.Collections.Generic.IList<string> exclude,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/migrations/{migrationId}?{string.Join("&", exclude.Select(static x => $"exclude={x}"))}", global::System.UriKind.RelativeOrAbsolute));

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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Migration?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}