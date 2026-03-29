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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Current job status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StatusEnum Status { get; set; } = default!;

        /// <summary>
        /// Machine-readable error code when failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Human-readable error details when failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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