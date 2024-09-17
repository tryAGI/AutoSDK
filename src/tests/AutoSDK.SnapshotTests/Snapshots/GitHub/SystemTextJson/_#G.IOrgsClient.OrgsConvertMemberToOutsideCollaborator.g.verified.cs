//HintName: G.IOrgsClient.OrgsConvertMemberToOutsideCollaborator.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Convert an organization member to outside collaborator<br/>
        /// When an organization member is converted to an outside collaborator, they'll only have access to the repositories that their current team membership allows. The user will no longer be a member of the organization. For more information, see "[Converting an organization member to an outside collaborator](https://docs.github.com/articles/converting-an-organization-member-to-an-outside-collaborator/)". Converting an organization member to an outside collaborator may be restricted by enterprise administrators. For more information, see "[Enforcing repository management policies in your enterprise](https://docs.github.com/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgsConvertMemberToOutsideCollaboratorResponse> OrgsConvertMemberToOutsideCollaboratorAsync(
            string org,
            string username,
            global::G.OrgsConvertMemberToOutsideCollaboratorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task<global::G.OrgsConvertMemberToOutsideCollaboratorResponse> OrgsConvertMemberToOutsideCollaboratorAsync(
            string org,
            string username,
            bool? async = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}