//HintName: G.IExamplesClient.DeleteExample.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Delete Example<br/>
        /// Delete a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteExampleAsync(
            global::System.Guid exampleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}