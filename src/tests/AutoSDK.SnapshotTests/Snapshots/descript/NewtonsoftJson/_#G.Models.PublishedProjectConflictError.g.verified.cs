//HintName: G.Models.PublishedProjectConflictError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response when published project is in an invalid state
    /// </summary>
    public sealed partial class PublishedProjectConflictError
    {
        /// <summary>
        /// Error type identifier<br/>
        /// Example: conflict
        /// </summary>
        /// <example>conflict</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublishedProjectConflictErrorErrorJsonConverter))]
        public global::G.PublishedProjectConflictErrorError Error { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Published in invalid state
        /// </summary>
        /// <example>Published in invalid state</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Current state of the published project<br/>
        /// Example: processing
        /// </summary>
        /// <example>processing</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublishedProjectConflictErrorStateJsonConverter))]
        public global::G.PublishedProjectConflictErrorState State { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectConflictError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Published in invalid state
        /// </param>
        /// <param name="state">
        /// Current state of the published project<br/>
        /// Example: processing
        /// </param>
        /// <param name="error">
        /// Error type identifier<br/>
        /// Example: conflict
        /// </param>
        public PublishedProjectConflictError(
            string message,
            global::G.PublishedProjectConflictErrorState state,
            global::G.PublishedProjectConflictErrorError error)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectConflictError" /> class.
        /// </summary>
        public PublishedProjectConflictError()
        {
        }
    }
}