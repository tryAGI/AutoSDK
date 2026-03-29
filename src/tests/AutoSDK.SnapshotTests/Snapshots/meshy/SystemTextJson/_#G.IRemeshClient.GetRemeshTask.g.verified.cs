//HintName: G.IRemeshClient.GetRemeshTask.g.cs
#nullable enable

namespace G
{
    public partial interface IRemeshClient
    {
        /// <summary>
        /// Retrieve a Remesh task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RemeshTask> GetRemeshTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}