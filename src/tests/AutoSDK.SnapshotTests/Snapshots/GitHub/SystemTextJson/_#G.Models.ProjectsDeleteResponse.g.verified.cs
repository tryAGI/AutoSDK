//HintName: G.Models.ProjectsDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsDeleteResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsDeleteResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        /// <param name="errors"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectsDeleteResponse(
            string? message,
            string? documentationUrl,
            global::System.Collections.Generic.IList<string>? errors)
        {
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsDeleteResponse" /> class.
        /// </summary>
        public ProjectsDeleteResponse()
        {
        }
    }
}