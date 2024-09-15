//HintName: G.ITrainingClient.TrainingStartExportTestResultJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// StartExportTestResultJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="testResultId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cryptoKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TrainingStartExportTestResultJobAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid testResultId = default,
            string? fileExtension = default,
            string? cryptoKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}