//HintName: G.Models.DatasetsListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetsListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasets")]
        public global::System.Collections.Generic.IList<global::G.Dataset>? Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsListResponse" /> class.
        /// </summary>
        /// <param name="datasets"></param>
        public DatasetsListResponse(
            global::System.Collections.Generic.IList<global::G.Dataset>? datasets)
        {
            this.Datasets = datasets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsListResponse" /> class.
        /// </summary>
        public DatasetsListResponse()
        {
        }
    }
}