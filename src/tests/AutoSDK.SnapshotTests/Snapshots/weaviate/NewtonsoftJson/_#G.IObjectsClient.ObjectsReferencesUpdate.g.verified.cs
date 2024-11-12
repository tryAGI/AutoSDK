//HintName: G.IObjectsClient.ObjectsReferencesUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Replace cross-references.<br/>
        /// Replace all references in cross-reference property of an object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task ObjectsReferencesUpdateAsync(
            global::System.Guid id,
            string propertyName,
            global::System.Collections.Generic.IList<global::G.SingleRef> request,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}