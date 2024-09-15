//HintName: G.IReposClient.ReposGetCustomPropertiesValues.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get all custom property values for a repository<br/>
        /// Gets all custom property values that are set for a repository.<br/>
        /// Users with read access to the repository can use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CustomPropertyValue>> ReposGetCustomPropertiesValuesAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}