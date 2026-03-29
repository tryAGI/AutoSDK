//HintName: G.Models.PublishedProjectError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response for published project requests
    /// </summary>
    public sealed partial class PublishedProjectError
    {
        /// <summary>
        /// Error type identifier<br/>
        /// Example: not_found
        /// </summary>
        /// <example>not_found</example>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublishedProjectErrorError Error { get; set; } = default!;

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Published project not found
        /// </summary>
        /// <example>Published project not found</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error type identifier<br/>
        /// Example: not_found
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Published project not found
        /// </param>
        public PublishedProjectError(
            global::G.PublishedProjectErrorError error,
            string message)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectError" /> class.
        /// </summary>
        public PublishedProjectError()
        {
        }
    }
}