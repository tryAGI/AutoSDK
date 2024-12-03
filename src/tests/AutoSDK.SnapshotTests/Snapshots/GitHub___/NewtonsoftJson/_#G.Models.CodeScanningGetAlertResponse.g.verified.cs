//HintName: G.Models.CodeScanningGetAlertResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningGetAlertResponse
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
        [global::Newtonsoft.Json.JsonProperty("documentation_url")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningGetAlertResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        public CodeScanningGetAlertResponse(
            string? code,
            string? message,
            string? documentationUrl)
        {
            this.Code = code;
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningGetAlertResponse" /> class.
        /// </summary>
        public CodeScanningGetAlertResponse()
        {
        }
    }
}