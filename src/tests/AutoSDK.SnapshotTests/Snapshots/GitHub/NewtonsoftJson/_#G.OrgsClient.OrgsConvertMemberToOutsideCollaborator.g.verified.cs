//HintName: G.OrgsClient.OrgsConvertMemberToOutsideCollaborator.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsConvertMemberToOutsideCollaboratorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string username,
            global::G.OrgsConvertMemberToOutsideCollaboratorRequest request);
        partial void PrepareOrgsConvertMemberToOutsideCollaboratorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string username,
            global::G.OrgsConvertMemberToOutsideCollaboratorRequest request);
        partial void ProcessOrgsConvertMemberToOutsideCollaboratorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsConvertMemberToOutsideCollaboratorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Convert an organization member to outside collaborator<br/>
        /// When an organization member is converted to an outside collaborator, they'll only have access to the repositories that their current team membership allows. The user will no longer be a member of the organization. For more information, see "[Converting an organization member to an outside collaborator](https://docs.github.com/articles/converting-an-organization-member-to-an-outside-collaborator/)". Converting an organization member to an outside collaborator may be restricted by enterprise administrators. For more information, see "[Enforcing repository management policies in your enterprise](https://docs.github.com/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrgsConvertMemberToOutsideCollaboratorResponse> OrgsConvertMemberToOutsideCollaboratorAsync(
            string org,
            string username,
            global::G.OrgsConvertMemberToOutsideCollaboratorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrgsConvertMemberToOutsideCollaboratorArguments(
                httpClient: HttpClient,
                org: ref org,
                username: ref username,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/outside_collaborators/{username}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsConvertMemberToOutsideCollaboratorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                username: username,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsConvertMemberToOutsideCollaboratorResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsConvertMemberToOutsideCollaboratorResponseContent(
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
                global::G.OrgsConvertMemberToOutsideCollaboratorResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Convert an organization member to outside collaborator<br/>
        /// When an organization member is converted to an outside collaborator, they'll only have access to the repositories that their current team membership allows. The user will no longer be a member of the organization. For more information, see "[Converting an organization member to an outside collaborator](https://docs.github.com/articles/converting-an-organization-member-to-an-outside-collaborator/)". Converting an organization member to an outside collaborator may be restricted by enterprise administrators. For more information, see "[Enforcing repository management policies in your enterprise](https://docs.github.com/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="async">
        /// When set to `true`, the request will be performed asynchronously. Returns a 202 status code when the job is successfully queued.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrgsConvertMemberToOutsideCollaboratorResponse> OrgsConvertMemberToOutsideCollaboratorAsync(
            string org,
            string username,
            bool? async = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OrgsConvertMemberToOutsideCollaboratorRequest
            {
                Async = async,
            };

            return await OrgsConvertMemberToOutsideCollaboratorAsync(
                org: org,
                username: username,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}