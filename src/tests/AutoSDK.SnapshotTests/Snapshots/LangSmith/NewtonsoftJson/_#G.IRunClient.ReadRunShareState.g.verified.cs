//HintName: G.IRunClient.ReadRunShareState.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Read Run Share State<br/>
        /// Get the state of sharing of a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunShareSchema> ReadRunShareStateAsync(
            global::System.Guid runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}