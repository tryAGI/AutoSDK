﻿//HintName: G.MigrationsClient.MigrationsListForOrg.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        /// <summary>
        /// List organization migrations
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task MigrationsListForOrgAsync(
            string org,
            int perPage,
            int page,
            global::System.Collections.Generic.IList<string> exclude,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/migrations?per_page={perPage}&page={page}&{string.Join("&", exclude.Select(static x => $"exclude={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}