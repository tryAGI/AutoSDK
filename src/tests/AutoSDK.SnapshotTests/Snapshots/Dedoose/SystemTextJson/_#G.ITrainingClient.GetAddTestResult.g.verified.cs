//HintName: G.ITrainingClient.GetAddTestResult.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// GetAddTestResult<br/>
        /// GetAddTestResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingTest> GetAddTestResultAsync(
            global::G.GetAddTestResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetAddTestResult<br/>
        /// GetAddTestResult
        /// </summary>
        /// <param name="addTestWorkerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingTest> GetAddTestResultAsync(
            string addTestWorkerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}