//HintName: G.Models.ValidationErrorSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Validation Error Simple
    /// </summary>
    public sealed partial class ValidationErrorSimple
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorSimple" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        /// <param name="errors"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ValidationErrorSimple(
            string message,
            string documentationUrl,
            global::System.Collections.Generic.IList<string>? errors)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DocumentationUrl = documentationUrl ?? throw new global::System.ArgumentNullException(nameof(documentationUrl));
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorSimple" /> class.
        /// </summary>
        public ValidationErrorSimple()
        {
        }
    }
}