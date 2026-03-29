//HintName: G.ITranscriptionJobsClient.DeleteTranscriptionJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptionJobsClient
    {
        /// <summary>
        /// Delete Transcription Job<br/>
        /// Deletes a transcription job. All data related to the job will be permanently deleted. A job can only be deleted once it's completed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTranscriptionJobAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}