//HintName: G.IParsingClient.CreateParsingJob.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Start a parse job<br/>
        /// Start a parse job for the provided file.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating a parse job.<br/>
        /// Returns:<br/>
        ///     The created parsing job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsingJob> CreateParsingJobAsync(

            global::G.ParsingJobCreateParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a parse job<br/>
        /// Start a parse job for the provided file.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating a parse job.<br/>
        /// Returns:<br/>
        ///     The created parsing job.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to parse
        /// </param>
        /// <param name="elementTypes">
        /// The elements to extract from the document
        /// </param>
        /// <param name="chunkingStrategy">
        /// The strategy to use for chunking the content<br/>
        /// Default Value: page
        /// </param>
        /// <param name="returnFormat">
        /// The format of the returned content<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="mode">
        /// The strategy to use for OCR<br/>
        /// Default Value: high_quality
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsingJob> CreateParsingJobAsync(
            string fileId,
            global::System.Collections.Generic.IList<global::G.ElementType>? elementTypes = default,
            global::G.ChunkingStrategy? chunkingStrategy = default,
            global::G.ReturnFormat? returnFormat = default,
            global::G.Mode? mode = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}