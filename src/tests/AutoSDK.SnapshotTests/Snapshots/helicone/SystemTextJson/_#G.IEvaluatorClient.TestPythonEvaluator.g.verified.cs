//HintName: G.IEvaluatorClient.TestPythonEvaluator.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluatorClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultOutputStringTracesStringArrayStatusCode63NumberString> TestPythonEvaluatorAsync(

            global::G.TestPythonEvaluatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="testInput"></param>
        /// <param name="code"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultOutputStringTracesStringArrayStatusCode63NumberString> TestPythonEvaluatorAsync(
            global::G.TestInput testInput,
            string code,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}