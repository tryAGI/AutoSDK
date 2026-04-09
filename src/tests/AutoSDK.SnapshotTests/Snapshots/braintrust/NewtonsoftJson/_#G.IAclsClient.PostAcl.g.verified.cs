//HintName: G.IAclsClient.PostAcl.g.cs
#nullable enable

namespace G
{
    public partial interface IAclsClient
    {
        /// <summary>
        /// Create acl<br/>
        /// Create a new acl. If there is an existing acl with the same contents as the one specified in the request, will return the existing acl unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Acl> PostAclAsync(

            global::G.AclItem request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create acl<br/>
        /// Create a new acl. If there is an existing acl with the same contents as the one specified in the request, will return the existing acl unmodified
        /// </summary>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the ACL applies to
        /// </param>
        /// <param name="userId">
        /// Id of the user the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </param>
        /// <param name="groupId">
        /// Id of the group the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </param>
        /// <param name="permission">
        /// Each permission permits a certain type of operation on an object in the system<br/>
        /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
        /// </param>
        /// <param name="restrictObjectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="roleId">
        /// Id of the role the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Acl> PostAclAsync(
            global::G.AclObjectType objectType,
            global::System.Guid objectId,
            global::System.Guid? userId = default,
            global::System.Guid? groupId = default,
            global::G.Permission? permission = default,
            global::G.AclObjectType? restrictObjectType = default,
            global::System.Guid? roleId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}