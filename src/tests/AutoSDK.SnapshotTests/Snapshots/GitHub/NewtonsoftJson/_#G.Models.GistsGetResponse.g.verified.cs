//HintName: G.Models.GistsGetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block")]
        public global::G.GistsGetResponseBlock? Block { get; set; }

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
        /// Initializes a new instance of the <see cref="GistsGetResponse" /> class.
        /// </summary>
        /// <param name="block"></param>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        public GistsGetResponse(
            global::G.GistsGetResponseBlock? block,
            string? message,
            string? documentationUrl)
        {
            this.Block = block;
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsGetResponse" /> class.
        /// </summary>
        public GistsGetResponse()
        {
        }
    }
}