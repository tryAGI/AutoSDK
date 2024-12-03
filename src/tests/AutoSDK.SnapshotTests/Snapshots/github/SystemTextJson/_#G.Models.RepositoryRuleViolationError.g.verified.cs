//HintName: G.Models.RepositoryRuleViolationError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repository rule violation was detected
    /// </summary>
    public sealed partial class RepositoryRuleViolationError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation_url")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.RepositoryRuleViolationErrorMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRuleViolationError(
            string? message,
            string? documentationUrl,
            string? status,
            global::G.RepositoryRuleViolationErrorMetadata? metadata)
        {
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
            this.Status = status;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationError" /> class.
        /// </summary>
        public RepositoryRuleViolationError()
        {
        }
    }
}