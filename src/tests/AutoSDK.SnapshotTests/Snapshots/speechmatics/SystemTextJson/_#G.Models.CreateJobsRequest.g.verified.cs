//HintName: G.Models.CreateJobsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateJobsRequest
    {
        /// <summary>
        /// JSON containing a [`JobConfig`](/speech-to-text/batch/input#jobconfig-schema) model indicating the type and parameters for the recognition job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Config { get; set; }

        /// <summary>
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_file")]
        public byte[]? DataFile { get; set; }

        /// <summary>
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_filename")]
        public string? DataFilename { get; set; }

        /// <summary>
        /// For alignment jobs, the text file that the data file should be aligned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_file")]
        public byte[]? TextFile { get; set; }

        /// <summary>
        /// For alignment jobs, the text file that the data file should be aligned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_filename")]
        public string? TextFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobsRequest(
            string config,
            byte[]? dataFile,
            string? dataFilename,
            byte[]? textFile,
            string? textFilename)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.DataFile = dataFile;
            this.DataFilename = dataFilename;
            this.TextFile = textFile;
            this.TextFilename = textFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsRequest" /> class.
        /// </summary>
        public CreateJobsRequest()
        {
        }
    }
}