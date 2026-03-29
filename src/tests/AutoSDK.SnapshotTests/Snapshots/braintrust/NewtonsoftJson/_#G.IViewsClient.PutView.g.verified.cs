//HintName: G.IViewsClient.PutView.g.cs
#nullable enable

namespace G
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Create or replace view<br/>
        /// Create or replace view. If there is an existing view with the same name as the one specified in the request, will replace the existing view with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.View> PutViewAsync(

            global::G.CreateView request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace view<br/>
        /// Create or replace view. If there is an existing view with the same name as the one specified in the request, will replace the existing view with the provided fields
        /// </summary>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the view applies to
        /// </param>
        /// <param name="viewType">
        /// Type of object that the view corresponds to.
        /// </param>
        /// <param name="name">
        /// Name of the view
        /// </param>
        /// <param name="viewData">
        /// The view definition
        /// </param>
        /// <param name="options">
        /// Options for the view in the app
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the view
        /// </param>
        /// <param name="deletedAt">
        /// Date of role deletion, or null if the role is still active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.View> PutViewAsync(
            global::G.AclObjectType objectType,
            global::System.Guid objectId,
            global::G.CreateViewViewType viewType,
            string name,
            global::G.ViewData? viewData = default,
            global::G.ViewOptions? options = default,
            global::System.Guid? userId = default,
            global::System.DateTime? deletedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}