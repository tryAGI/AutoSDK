﻿//HintName: G.ProjectsClient.ProjectsListCollaborators.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        /// <summary>
        /// List project collaborators
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="affiliation"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ProjectsListCollaboratorsAsync(
            int projectId,
            ProjectsListCollaboratorsAffiliation affiliation,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var affiliationValue = affiliation switch
            {
                ProjectsListCollaboratorsAffiliation.Outside => "outside",
                ProjectsListCollaboratorsAffiliation.Direct => "direct",
                ProjectsListCollaboratorsAffiliation.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/projects/{projectId}/collaborators?affiliation={affiliationValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}