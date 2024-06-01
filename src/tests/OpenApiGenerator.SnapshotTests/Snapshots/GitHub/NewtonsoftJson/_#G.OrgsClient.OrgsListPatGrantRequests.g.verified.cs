//HintName: G.OrgsClient.OrgsListPatGrantRequests.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// List requests to access organization resources with fine-grained personal access tokens
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
        public async global::System.Threading.Tasks.Task<BasicError> OrgsListPatGrantRequestsAsync(
            string org,
            int perPage,
            int page,
            OrgsListPatGrantRequestsSort sort,
            OrgsListPatGrantRequestsDirection direction,
            global::System.Collections.Generic.IList<string> owner,
            string repository,
            string permission,
            global::System.DateTime lastUsedBefore,
            global::System.DateTime lastUsedAfter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sortValue = sort switch
            {
                OrgsListPatGrantRequestsSort.CreatedAt => "created_at",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                OrgsListPatGrantRequestsDirection.Asc => "asc",
                OrgsListPatGrantRequestsDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/personal-access-token-requests?per_page={perPage}&page={page}&sort={sortValue}&direction={directionValue}&{string.Join("&", owner.Select(static x => $"owner={x}"))}&repository={repository}&permission={permission}&last_used_before={lastUsedBefore}&last_used_after={lastUsedAfter}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<BasicError?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}