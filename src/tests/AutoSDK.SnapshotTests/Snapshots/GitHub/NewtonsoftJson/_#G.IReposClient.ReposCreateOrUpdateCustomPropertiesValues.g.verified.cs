//HintName: G.IReposClient.ReposCreateOrUpdateCustomPropertiesValues.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create or update custom property values for a repository<br/>
        /// Create new or update existing custom property values for a repository.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// Repository admins and other users with the repository-level "edit custom property values" fine-grained permission can use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> ReposCreateOrUpdateCustomPropertiesValuesAsync(
            string owner,
            string repo,
            global::G.ReposCreateOrUpdateCustomPropertiesValuesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create or update custom property values for a repository<br/>
        /// Create new or update existing custom property values for a repository.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// Repository admins and other users with the repository-level "edit custom property values" fine-grained permission can use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="properties">
        /// A list of custom property names and associated values to apply to the repositories.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> ReposCreateOrUpdateCustomPropertiesValuesAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}