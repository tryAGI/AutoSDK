//HintName: G.Models.ApiStoragesAzureCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesAzureCreateRequest
    {
        /// <summary>
        /// Azure Blob account key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_key")]
        public string? AccountKey { get; set; }

        /// <summary>
        /// Azure Blob account name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string? AccountName { get; set; }

        /// <summary>
        /// Azure blob container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        public string? Container { get; set; }

        /// <summary>
        /// Storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Azure blob prefix name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Presign URLs for direct download<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presign")]
        public bool? Presign { get; set; }

        /// <summary>
        /// Presign TTL in minutes<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presign_ttl")]
        public int? PresignTtl { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Cloud storage regex for filtering objects. You must specify it otherwise no objects will be imported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// Storage title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Interpret objects as BLOBs and generate URLs. For example, if your bucket contains images, you can use this option to generate URLs for these images. If set to False, it will read the content of the file and load it into Label Studio.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesAzureCreateRequest" /> class.
        /// </summary>
        /// <param name="accountKey">
        /// Azure Blob account key
        /// </param>
        /// <param name="accountName">
        /// Azure Blob account name
        /// </param>
        /// <param name="container">
        /// Azure blob container
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="prefix">
        /// Azure blob prefix name
        /// </param>
        /// <param name="presign">
        /// Presign URLs for direct download<br/>
        /// Default Value: true
        /// </param>
        /// <param name="presignTtl">
        /// Presign TTL in minutes<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects. You must specify it otherwise no objects will be imported.
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs. For example, if your bucket contains images, you can use this option to generate URLs for these images. If set to False, it will read the content of the file and load it into Label Studio.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiStoragesAzureCreateRequest(
            string? accountKey,
            string? accountName,
            string? container,
            string? description,
            string? prefix,
            bool? presign,
            int? presignTtl,
            int? project,
            string? regexFilter,
            string? title,
            bool? useBlobUrls)
        {
            this.AccountKey = accountKey;
            this.AccountName = accountName;
            this.Container = container;
            this.Description = description;
            this.Prefix = prefix;
            this.Presign = presign;
            this.PresignTtl = presignTtl;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.Title = title;
            this.UseBlobUrls = useBlobUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesAzureCreateRequest" /> class.
        /// </summary>
        public ApiStoragesAzureCreateRequest()
        {
        }
    }
}