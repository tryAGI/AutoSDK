//HintName: G.ITranscriptionJobsClient.GetListOfTranscriptionJobs.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptionJobsClient
    {
        /// <summary>
        /// Get List of Transcription Jobs<br/>
        /// Gets a list of transcription jobs submitted within the last 30 days in reverse chronological order up to the provided limit number of jobs per call.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TranscriptionJob>> GetListOfTranscriptionJobsAsync(
            int? limit = default,
            string? startingAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}