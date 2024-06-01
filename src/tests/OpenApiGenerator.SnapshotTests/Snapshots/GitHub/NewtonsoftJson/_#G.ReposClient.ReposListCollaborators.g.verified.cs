//HintName: G.ReposClient.ReposListCollaborators.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List repository collaborators
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="affiliation"></param>
        /// <param name="permission"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<Collaborator>> ReposListCollaboratorsAsync(
            string owner,
            string repo,
            ReposListCollaboratorsAffiliation affiliation,
            ReposListCollaboratorsPermission permission,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var affiliationValue = affiliation switch
            {
                ReposListCollaboratorsAffiliation.Outside => "outside",
                ReposListCollaboratorsAffiliation.Direct => "direct",
                ReposListCollaboratorsAffiliation.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var permissionValue = permission switch
            {
                ReposListCollaboratorsPermission.Pull => "pull",
                ReposListCollaboratorsPermission.Triage => "triage",
                ReposListCollaboratorsPermission.Push => "push",
                ReposListCollaboratorsPermission.Maintain => "maintain",
                ReposListCollaboratorsPermission.Admin => "admin",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/collaborators?affiliation={affiliationValue}&permission={permissionValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<Collaborator>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}