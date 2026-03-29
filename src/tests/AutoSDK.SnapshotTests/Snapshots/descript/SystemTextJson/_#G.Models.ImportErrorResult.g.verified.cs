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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImportErrorResultStatusJsonConverter))]
        public global::G.ImportErrorResultStatus Status { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Failed to import media files
        /// </summary>
        /// <example>Failed to import media files</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// Machine-readable error code<br/>
        /// Example: import_failed
        /// </summary>
        /// <example>import_failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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