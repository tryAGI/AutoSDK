﻿//HintName: G.OrgsClient.OrgsListPatGrants.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// List fine-grained personal access tokens with access to organization resources
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="owner"></param>
        /// <param name="repository"></param>
        /// <param name="permission"></param>
        /// <param name="lastUsedBefore"></param>
        /// <param name="lastUsedAfter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<BasicError> OrgsListPatGrantsAsync(
            string org,
            int perPage,
            int page,
            string sort,
            string direction,
            global::System.Collections.Generic.IList<string> owner,
            string repository,
            string permission,
            global::System.DateTime lastUsedBefore,
            global::System.DateTime lastUsedAfter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/personal-access-tokens?per_page={perPage}&page={page}&sort={sort}&direction={direction}&{string.Join("&", owner.Select(static x => $"owner={x}"))}&repository={repository}&permission={permission}&last_used_before={lastUsedBefore}&last_used_after={lastUsedAfter}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<BasicError>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}