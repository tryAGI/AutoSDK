//HintName: G.IApi.CreateJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a new job
        /// </summary>
        /// <param name="xSmProcessingData"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// import { BatchClient } from "@speechmatics/batch-client";<br/>
        /// const client = new BatchClient({ apiKey: "YOUR_API_KEY" });<br/>
        /// // This is to get a File handle in NodeJS<br/>
        /// // In the browser, you can pass a File object from a form input, or similar<br/>
        /// const blob = await openAsBlob("PATH_TO_FILE");<br/>
        /// const file = new File([blob], "your_filename");<br/>
        /// const response = await client.createTranscriptionJob({<br/>
        ///   file,<br/>
        ///   config: {<br/>
        ///     type: "transcription",<br/>
        ///     transcription_config: {<br/>
        ///       operating_point: "enhanced",<br/>
        ///       language: "en",<br/>
        ///     },<br/>
        ///   },<br/>
        /// });<br/>
        /// const json = await response.json();<br/>
        /// console.log(json);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateJobResponse> CreateJobsAsync(

            global::G.CreateJobsRequest request,
            string? xSmProcessingData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new job
        /// </summary>
        /// <param name="xSmProcessingData"></param>
        /// <param name="config">
        /// JSON containing a [`JobConfig`](/speech-to-text/batch/input#jobconfig-schema) model indicating the type and parameters for the recognition job.
        /// </param>
        /// <param name="dataFile">
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </param>
        /// <param name="dataFilename">
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </param>
        /// <param name="textFile">
        /// For alignment jobs, the text file that the data file should be aligned to.
        /// </param>
        /// <param name="textFilename">
        /// For alignment jobs, the text file that the data file should be aligned to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateJobResponse> CreateJobsAsync(
            string config,
            string? xSmProcessingData = default,
            byte[]? dataFile = default,
            string? dataFilename = default,
            byte[]? textFile = default,
            string? textFilename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}