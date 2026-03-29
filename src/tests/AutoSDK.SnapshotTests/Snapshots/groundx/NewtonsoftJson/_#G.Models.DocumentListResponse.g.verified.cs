//HintName: G.Models.DocumentListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.DocumentDetail>? Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextToken")]
        public string? NextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentListResponse" /> class.
        /// </summary>
        /// <param name="documents"></param>
        /// <param name="nextToken"></param>
        public DocumentListResponse(
            global::System.Collections.Generic.IList<global::G.DocumentDetail>? documents,
            string? nextToken)
        {
            this.Documents = documents;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentListResponse" /> class.
        /// </summary>
        public DocumentListResponse()
        {
        }
    }
}