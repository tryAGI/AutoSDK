//HintName: G.IForcedAlignmentClient.CreateForcedAlignment.g.cs
#nullable enable

namespace G
{
    public partial interface IForcedAlignmentClient
    {
        /// <summary>
        /// Create Forced Alignment<br/>
        /// Force align an audio file to text. Use this endpoint to get the timing information for each character and word in an audio file based on a provided text transcript.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ForcedAlignmentResponseModel> CreateForcedAlignmentAsync(
            global::G.BodyCreateForcedAlignmentV1ForcedAlignmentPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Forced Alignment<br/>
        /// Force align an audio file to text. Use this endpoint to get the timing information for each character and word in an audio file based on a provided text transcript.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="file">
        /// The file to align. All major audio formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="filename">
        /// The file to align. All major audio formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="text">
        /// The text to align with the audio. The input text can be in any format, however diarization is not supported at this time.
        /// </param>
        /// <param name="enabledSpooledFile">
        /// If true, the file will be streamed to the server and processed in chunks. This is useful for large files that cannot be loaded into memory. The default is false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ForcedAlignmentResponseModel> CreateForcedAlignmentAsync(
            byte[] file,
            string filename,
            string text,
            string? xiApiKey = default,
            bool? enabledSpooledFile = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}