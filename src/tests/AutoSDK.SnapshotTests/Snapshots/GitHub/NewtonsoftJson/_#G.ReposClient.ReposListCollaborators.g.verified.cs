//HintName: G.ReposClient.ReposListCollaborators.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposListCollaboratorsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::G.ReposListCollaboratorsAffiliation? affiliation,
            ref global::G.ReposListCollaboratorsPermission? permission,
            ref int? perPage,
            ref int? page);
        partial void PrepareReposListCollaboratorsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ReposListCollaboratorsAffiliation? affiliation,
            global::G.ReposListCollaboratorsPermission? permission,
            int? perPage,
            int? page);
        partial void ProcessReposListCollaboratorsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListCollaboratorsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repository collaborators<br/>
        /// For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.<br/>
        /// Organization members with write, maintain, or admin privileges on the organization-owned repository can use this endpoint.<br/>
        /// Team members will include the members of child teams.<br/>
        /// The authenticated user must have push access to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` and `repo` scopes to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="affiliation">
        /// Default Value: all
        /// </param>
        /// <param name="permission"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Collaborator>> ReposListCollaboratorsAsync(
            string owner,
            string repo,
            global::G.ReposListCollaboratorsAffiliation? affiliation = default,
            global::G.ReposListCollaboratorsPermission? permission = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposListCollaboratorsArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                affiliation: ref affiliation,
                permission: ref permission,
                perPage: ref perPage,
                page: ref page);

            var affiliationValue = affiliation switch
            {
                global::G.ReposListCollaboratorsAffiliation.Outside => "outside",
                global::G.ReposListCollaboratorsAffiliation.Direct => "direct",
                global::G.ReposListCollaboratorsAffiliation.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var permissionValue = permission switch
            {
                global::G.ReposListCollaboratorsPermission.Pull => "pull",
                global::G.ReposListCollaboratorsPermission.Triage => "triage",
                global::G.ReposListCollaboratorsPermission.Push => "push",
                global::G.ReposListCollaboratorsPermission.Maintain => "maintain",
                global::G.ReposListCollaboratorsPermission.Admin => "admin",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/collaborators",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("affiliation", affiliationValue?.ToString()) 
                .AddOptionalParameter("permission", permissionValue?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposListCollaboratorsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                affiliation: affiliation,
                permission: permission,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposListCollaboratorsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposListCollaboratorsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Collaborator>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}