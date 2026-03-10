//HintName: G.Models.WebhookPackagePublishedPackagePackageVersionPackageFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersionPackageFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md5")]
        public string? Md5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha1")]
        public string? Sha1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        public string? Sha256 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionPackageFile" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPackagePublishedPackagePackageVersionPackageFile(
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
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionPackageFile" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersionPackageFile()
        {
        }
    }
}