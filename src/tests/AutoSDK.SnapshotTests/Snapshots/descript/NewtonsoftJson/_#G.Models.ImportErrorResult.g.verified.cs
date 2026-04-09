//HintName: G.Models.ImportErrorResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result when job failed completely
    /// </summary>
    public sealed partial class ImportErrorResult
    {
        /// <summary>
        /// Job failed completely<br/>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ImportErrorResultStatusJsonConverter))]
        public global::G.ImportErrorResultStatus Status { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Failed to import media files
        /// </summary>
        /// <example>Failed to import media files</example>
        [global::Newtonsoft.Json.JsonProperty("error_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorMessage { get; set; } = default!;

        /// <summary>
        /// Machine-readable error code<br/>
        /// Example: import_failed
        /// </summary>
        /// <example>import_failed</example>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportErrorResult" /> class.
        /// </summary>
        /// <param name="errorMessage">
        /// Human-readable error message<br/>
        /// Example: Failed to import media files
        /// </param>
        /// <param name="status">
        /// Job failed completely<br/>
        /// Example: error
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code<br/>
        /// Example: import_failed
        /// </param>
        public ImportErrorResult(
            string errorMessage,
            global::G.ImportErrorResultStatus status,
            string? errorCode)
        {
            this.Status = status;
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportErrorResult" /> class.
        /// </summary>
        public ImportErrorResult()
        {
        }
    }
}