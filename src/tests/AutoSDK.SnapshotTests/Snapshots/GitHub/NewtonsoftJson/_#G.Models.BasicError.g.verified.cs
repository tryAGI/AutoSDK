//HintName: G.Models.BasicError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Basic Error
    /// </summary>
    public sealed partial class BasicError
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
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        /// <param name="url"></param>
        /// <param name="status"></param>
        public BasicError(
            string? message,
            string? documentationUrl,
            string? url,
            string? status)
        {
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
            this.Url = url;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicError" /> class.
        /// </summary>
        public BasicError()
        {
        }
    }
}