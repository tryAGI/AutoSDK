//HintName: G.Models.ApiStoragesAzurePartialUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesAzurePartialUpdateRequest
    {
        /// <summary>
        /// Azure Blob account key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_key")]
        public string? AccountKey { get; set; }

        /// <summary>
        /// Azure Blob account name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_name")]
        public string? AccountName { get; set; }

        /// <summary>
        /// Azure blob container
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        public string? Container { get; set; }

        /// <summary>
        /// Storage description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Azure blob prefix name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Presign URLs for direct download<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presign")]
        public bool? Presign { get; set; }

        /// <summary>
        /// Presign TTL in minutes<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presign_ttl")]
        public int? PresignTtl { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Cloud storage regex for filtering objects. You must specify it otherwise no objects will be imported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// Storage title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Interpret objects as BLOBs and generate URLs. For example, if your bucket contains images, you can use this option to generate URLs for these images. If set to False, it will read the content of the file and load it into Label Studio.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesAzurePartialUpdateRequest" /> class.
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
        public ApiStoragesAzurePartialUpdateRequest(
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
        /// Initializes a new instance of the <see cref="ApiStoragesAzurePartialUpdateRequest" /> class.
        /// </summary>
        public ApiStoragesAzurePartialUpdateRequest()
        {
        }
    }
}