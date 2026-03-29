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
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PublishedProjectErrorErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublishedProjectErrorError Error { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Published project not found
        /// </summary>
        /// <example>Published project not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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