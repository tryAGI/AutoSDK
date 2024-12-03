//HintName: G.Models.GetDatasetByIdResponseDatasetsByPkDatasetImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "dataset_images"
    /// </summary>
    public sealed partial class GetDatasetByIdResponseDatasetsByPkDatasetImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetByIdResponseDatasetsByPkDatasetImage" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="url"></param>
        public GetDatasetByIdResponseDatasetsByPkDatasetImage(
            string? createdAt,
            string? id,
            string? url)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetByIdResponseDatasetsByPkDatasetImage" /> class.
        /// </summary>
        public GetDatasetByIdResponseDatasetsByPkDatasetImage()
        {
        }
    }
}