//HintName: G.Models.ProjectsMoveCardResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsMoveCardResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentation_url")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<global::G.ProjectsMoveCardResponseError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMoveCardResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        /// <param name="errors"></param>
        public ProjectsMoveCardResponse2(
            string? message,
            string? documentationUrl,
            global::System.Collections.Generic.IList<global::G.ProjectsMoveCardResponseError>? errors)
        {
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMoveCardResponse2" /> class.
        /// </summary>
        public ProjectsMoveCardResponse2()
        {
        }
    }
}