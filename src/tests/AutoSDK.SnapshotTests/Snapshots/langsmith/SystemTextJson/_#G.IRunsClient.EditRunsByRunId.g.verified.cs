//HintName: G.IRunsClient.EditRunsByRunId.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Update a Run<br/>
        /// Updates a run identified by its ID. The body should contain only the fields to be changed; unknown fields are ignored.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EditRunsByRunIdAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}