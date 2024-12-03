//HintName: G.Models.WebhookRegistryPackageUpdatedRegistryPackagePackageVersionPackageFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackageUpdatedRegistryPackagePackageVersionPackageFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md5")]
        public string? Md5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha1")]
        public string? Sha1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha256")]
        public string? Sha256 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackageUpdatedRegistryPackagePackageVersionPackageFile" /> class.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="createdAt"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="id"></param>
        /// <param name="md5"></param>
        /// <param name="name"></param>
        /// <param name="sha1"></param>
        /// <param name="sha256"></param>
        /// <param name="size"></param>
        /// <param name="state"></param>
        /// <param name="updatedAt"></param>
        public WebhookRegistryPackageUpdatedRegistryPackagePackageVersionPackageFile(
            string? contentType,
            string? createdAt,
            string? downloadUrl,
            int? id,
            string? md5,
            string? name,
            string? sha1,
            string? sha256,
            int? size,
            string? state,
            string? updatedAt)
        {
            this.ContentType = contentType;
            this.CreatedAt = createdAt;
            this.DownloadUrl = downloadUrl;
            this.Id = id;
            this.Md5 = md5;
            this.Name = name;
            this.Sha1 = sha1;
            this.Sha256 = sha256;
            this.Size = size;
            this.State = state;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackageUpdatedRegistryPackagePackageVersionPackageFile" /> class.
        /// </summary>
        public WebhookRegistryPackageUpdatedRegistryPackagePackageVersionPackageFile()
        {
        }
    }
}