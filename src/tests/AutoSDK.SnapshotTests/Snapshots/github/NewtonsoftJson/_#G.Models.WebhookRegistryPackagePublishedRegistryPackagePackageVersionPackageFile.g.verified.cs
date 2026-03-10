//HintName: G.Models.WebhookRegistryPackagePublishedRegistryPackagePackageVersionPackageFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackagePublishedRegistryPackagePackageVersionPackageFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md5")]
        public string? Md5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionPackageFile" /> class.
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
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionPackageFile(
            string contentType,
            string createdAt,
            string downloadUrl,
            int id,
            string name,
            int size,
            string updatedAt,
            string? md5,
            string? sha1,
            string? sha256,
            string? state)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DownloadUrl = downloadUrl ?? throw new global::System.ArgumentNullException(nameof(downloadUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Size = size;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Md5 = md5;
            this.Sha1 = sha1;
            this.Sha256 = sha256;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionPackageFile" /> class.
        /// </summary>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionPackageFile()
        {
        }
    }
}