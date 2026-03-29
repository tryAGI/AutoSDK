//HintName: G.IDataManagerClient.ApiDmProjectRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDataManagerClient
    {
        /// <summary>
        /// Get project state<br/>
        /// Retrieve the project state for the data manager.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDmProjectRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}