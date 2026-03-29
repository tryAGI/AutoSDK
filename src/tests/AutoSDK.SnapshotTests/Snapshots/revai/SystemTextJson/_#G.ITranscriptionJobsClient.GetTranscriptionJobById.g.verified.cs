//HintName: G.ITranscriptionJobsClient.GetTranscriptionJobById.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptionJobsClient
    {
        /// <summary>
        /// Get Transcription Job By Id<br/>
        /// Returns information about a transcription job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptionJob> GetTranscriptionJobByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}