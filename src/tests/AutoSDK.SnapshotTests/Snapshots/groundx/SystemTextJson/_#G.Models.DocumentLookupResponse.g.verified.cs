//HintName: G.Models.DocumentLookupResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"message":"The method you used is not supported for this query"}
    /// </summary>
    public sealed partial class DocumentLookupResponse
    {
        /// <summary>
        /// The number of results returned in the current response<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::G.DocumentDetail>? Documents { get; set; }

        /// <summary>
        /// Example: The method you used is not supported for this query
        /// </summary>
        /// <example>The method you used is not supported for this query</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextToken")]
        public string? NextToken { get; set; }

        /// <summary>
        /// The total number of results found<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLookupResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// The number of results returned in the current response<br/>
        /// Example: 20
        /// </param>
        /// <param name="documents"></param>
        /// <param name="nextToken">
        /// Example: The method you used is not supported for this query
        /// </param>
        /// <param name="total">
        /// The total number of results found<br/>
        /// Example: 30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentLookupResponse(
            int? count,
            global::System.Collections.Generic.IList<global::G.DocumentDetail>? documents,
            string? nextToken,
            int? total)
        {
            this.Count = count;
            this.Documents = documents;
            this.NextToken = nextToken;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLookupResponse" /> class.
        /// </summary>
        public DocumentLookupResponse()
        {
        }
    }
}