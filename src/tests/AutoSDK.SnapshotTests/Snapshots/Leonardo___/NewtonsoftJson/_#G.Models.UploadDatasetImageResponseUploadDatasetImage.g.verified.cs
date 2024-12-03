//HintName: G.Models.UploadDatasetImageResponseUploadDatasetImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetImageResponseUploadDatasetImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields")]
        public string? Fields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

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
        /// Initializes a new instance of the <see cref="UploadDatasetImageResponseUploadDatasetImage" /> class.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="url"></param>
        public UploadDatasetImageResponseUploadDatasetImage(
            string? fields,
            string? id,
            string? key,
            string? url)
        {
            this.Fields = fields;
            this.Id = id;
            this.Key = key;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageResponseUploadDatasetImage" /> class.
        /// </summary>
        public UploadDatasetImageResponseUploadDatasetImage()
        {
        }
    }
}