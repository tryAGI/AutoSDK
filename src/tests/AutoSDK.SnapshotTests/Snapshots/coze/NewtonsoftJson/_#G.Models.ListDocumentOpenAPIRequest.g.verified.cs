//HintName: G.Models.ListDocumentOpenAPIRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListDocumentOpenAPIRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentOpenAPIRequest" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        public ListDocumentOpenAPIRequest(
            string datasetId,
            int? page,
            int? size)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Page = page;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentOpenAPIRequest" /> class.
        /// </summary>
        public ListDocumentOpenAPIRequest()
        {
        }
    }
}