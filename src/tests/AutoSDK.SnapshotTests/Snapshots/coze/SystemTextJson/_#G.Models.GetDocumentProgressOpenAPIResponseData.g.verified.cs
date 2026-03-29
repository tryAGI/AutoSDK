//HintName: G.Models.GetDocumentProgressOpenAPIResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentProgressOpenAPIResponseData
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.GetDocumentProgressOpenAPIResponseDataDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentProgressOpenAPIResponseData" /> class.
        /// </summary>
        /// <param name="data">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentProgressOpenAPIResponseData(
            global::System.Collections.Generic.IList<global::G.GetDocumentProgressOpenAPIResponseDataDataItem>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentProgressOpenAPIResponseData" /> class.
        /// </summary>
        public GetDocumentProgressOpenAPIResponseData()
        {
        }
    }
}