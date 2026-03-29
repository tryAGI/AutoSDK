//HintName: G.Models.ImportSuccessResultMediaStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status information for a single media import
    /// </summary>
    public sealed partial class ImportSuccessResultMediaStatus2
    {
        /// <summary>
        /// Status of this individual media import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImportSuccessResultMediaStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImportSuccessResultMediaStatusStatus Status { get; set; }

        /// <summary>
        /// Duration of the imported media in seconds (only present for successful imports)<br/>
        /// Example: 125.5
        /// </summary>
        /// <example>125.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public float? DurationSeconds { get; set; }

        /// <summary>
        /// Error message if the import failed (only present for failed imports)<br/>
        /// Example: URL is not accessible or does not support Range requests
        /// </summary>
        /// <example>URL is not accessible or does not support Range requests</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportSuccessResultMediaStatus2" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of this individual media import
        /// </param>
        /// <param name="durationSeconds">
        /// Duration of the imported media in seconds (only present for successful imports)<br/>
        /// Example: 125.5
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the import failed (only present for failed imports)<br/>
        /// Example: URL is not accessible or does not support Range requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportSuccessResultMediaStatus2(
            global::G.ImportSuccessResultMediaStatusStatus status,
            float? durationSeconds,
            string? errorMessage)
        {
            this.Status = status;
            this.DurationSeconds = durationSeconds;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportSuccessResultMediaStatus2" /> class.
        /// </summary>
        public ImportSuccessResultMediaStatus2()
        {
        }
    }
}