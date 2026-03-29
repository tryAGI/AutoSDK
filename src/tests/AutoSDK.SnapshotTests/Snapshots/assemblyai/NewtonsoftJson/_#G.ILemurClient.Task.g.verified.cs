//HintName: G.ILemurClient.Task.g.cs
#nullable enable

namespace G
{
    public partial interface ILemurClient
    {
        /// <summary>
        /// Run a task using LeMUR<br/>
        /// Use the LeMUR task endpoint to input your own LLM prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurTaskResponse> TaskAsync(

            global::G.LemurTaskParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a task using LeMUR<br/>
        /// Use the LeMUR task endpoint to input your own LLM prompt.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurTaskResponse> TaskAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}