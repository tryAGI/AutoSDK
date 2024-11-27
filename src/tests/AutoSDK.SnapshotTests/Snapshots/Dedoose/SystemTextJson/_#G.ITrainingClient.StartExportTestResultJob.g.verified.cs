//HintName: G.ITrainingClient.StartExportTestResultJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// StartExportTestResultJob<br/>
        /// StartExportTestResultJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportTestResultJobAsync(
            global::G.StartExportTestResultJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportTestResultJob<br/>
        /// StartExportTestResultJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testResultId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cryptoKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportTestResultJobAsync(
            global::System.Guid projectId,
            global::System.Guid testResultId,
            string fileExtension,
            string cryptoKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}