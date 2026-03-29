//HintName: G.Models.ComprehendMedicalRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComprehendMedicalRequest
    {
        /// <summary>
        /// The text to analyze.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComprehendMedicalType ResponseType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComprehendMedicalRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The text to analyze.
        /// </param>
        /// <param name="responseType"></param>
        public ComprehendMedicalRequest(
            string content,
            global::G.ComprehendMedicalType responseType)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComprehendMedicalRequest" /> class.
        /// </summary>
        public ComprehendMedicalRequest()
        {
        }
    }
}