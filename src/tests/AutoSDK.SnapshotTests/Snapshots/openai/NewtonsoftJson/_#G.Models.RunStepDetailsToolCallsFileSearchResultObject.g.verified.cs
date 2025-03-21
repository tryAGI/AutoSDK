//HintName: G.Models.RunStepDetailsToolCallsFileSearchResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A result instance of the file search.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchResultObject
    {
        /// <summary>
        /// The content of the result that was found. The content is only included if requested via the include query parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? Content { get; set; }

        /// <summary>
        /// The ID of the file that result was found in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The name of the file that result was found in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// The score of the result. All values must be a floating point number between 0 and 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchResultObject" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the result that was found. The content is only included if requested via the include query parameter.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file that result was found in.
        /// </param>
        /// <param name="fileName">
        /// The name of the file that result was found in.
        /// </param>
        /// <param name="score">
        /// The score of the result. All values must be a floating point number between 0 and 1.
        /// </param>
        public RunStepDetailsToolCallsFileSearchResultObject(
            string fileId,
            string fileName,
            double score,
            global::System.Collections.Generic.IList<global::G.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? content)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.Score = score;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchResultObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFileSearchResultObject()
        {
        }
    }
}