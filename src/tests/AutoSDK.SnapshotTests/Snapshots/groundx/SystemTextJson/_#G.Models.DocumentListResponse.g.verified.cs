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
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::G.DocumentDetail>? Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextToken")]
        public string? NextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentListResponse" /> class.
        /// </summary>
        /// <param name="documents"></param>
        /// <param name="nextToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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