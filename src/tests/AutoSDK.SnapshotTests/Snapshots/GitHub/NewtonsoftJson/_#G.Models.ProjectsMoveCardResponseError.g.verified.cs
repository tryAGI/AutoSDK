//HintName: G.Models.ProjectsMoveCardResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsMoveCardResponseError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        public string? Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMoveCardResponseError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="resource"></param>
        /// <param name="field"></param>
        public ProjectsMoveCardResponseError(
            string? code,
            string? message,
            string? resource,
            string? field)
        {
            this.Code = code;
            this.Message = message;
            this.Resource = resource;
            this.Field = field;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMoveCardResponseError" /> class.
        /// </summary>
        public ProjectsMoveCardResponseError()
        {
        }
    }
}