//HintName: G.Models.ListDatasetsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListDatasetsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<global::G.Dataset>? Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetsResponse" /> class.
        /// </summary>
        /// <param name="datasets"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListDatasetsResponse(
            global::System.Collections.Generic.IList<global::G.Dataset>? datasets)
        {
            this.Datasets = datasets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetsResponse" /> class.
        /// </summary>
        public ListDatasetsResponse()
        {
        }
    }
}