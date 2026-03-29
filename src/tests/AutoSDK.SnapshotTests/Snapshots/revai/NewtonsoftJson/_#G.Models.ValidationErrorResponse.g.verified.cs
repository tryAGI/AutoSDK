//HintName: G.Models.ValidationErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidationErrorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Invalid properties mapped to a list of reasons
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorResponse" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="parameters">
        /// Invalid properties mapped to a list of reasons
        /// </param>
        public ValidationErrorResponse(
            string? title,
            int? status,
            string? type,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? parameters)
        {
            this.Title = title;
            this.Status = status;
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorResponse" /> class.
        /// </summary>
        public ValidationErrorResponse()
        {
        }
    }
}