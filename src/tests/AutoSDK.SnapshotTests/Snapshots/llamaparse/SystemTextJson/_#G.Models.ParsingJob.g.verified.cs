//HintName: G.Models.ParsingJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A parse job (v1).
    /// </summary>
    public sealed partial class ParsingJob
    {
        /// <summary>
        /// Unique parse job identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Current job status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StatusEnum Status { get; set; }

        /// <summary>
        /// Machine-readable error code when failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Human-readable error details when failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJob" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique parse job identifier
        /// </param>
        /// <param name="status">
        /// Current job status
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code when failed
        /// </param>
        /// <param name="errorMessage">
        /// Human-readable error details when failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParsingJob(
            string id,
            global::G.StatusEnum status,
            string? errorCode,
            string? errorMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJob" /> class.
        /// </summary>
        public ParsingJob()
        {
        }
    }
}