//HintName: G.Models.ScimError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Scim Error
    /// </summary>
    public sealed partial class ScimError
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
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scimType")]
        public string? ScimType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        public global::System.Collections.Generic.IList<string>? Schemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        /// <param name="detail"></param>
        /// <param name="status"></param>
        /// <param name="scimType"></param>
        /// <param name="schemas"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ScimError(
            string? message,
            string? documentationUrl,
            string? detail,
            int? status,
            string? scimType,
            global::System.Collections.Generic.IList<string>? schemas)
        {
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
            this.Detail = detail;
            this.Status = status;
            this.ScimType = scimType;
            this.Schemas = schemas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimError" /> class.
        /// </summary>
        public ScimError()
        {
        }
    }
}