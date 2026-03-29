//HintName: G.Models.ApiStoragesRedisValidateCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesRedisValidateCreateRequest
    {
        /// <summary>
        /// Storage description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Server Host IP (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("host")]
        public string? Host { get; set; }

        /// <summary>
        /// Storage ID. If set, storage with specified ID will be updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Server Password (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Storage prefix (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Server Port (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("port")]
        public string? Port { get; set; }

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
        /// Initializes a new instance of the <see cref="ApiStoragesRedisValidateCreateRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="host">
        /// Server Host IP (optional)
        /// </param>
        /// <param name="id">
        /// Storage ID. If set, storage with specified ID will be updated
        /// </param>
        /// <param name="password">
        /// Server Password (optional)
        /// </param>
        /// <param name="path">
        /// Storage prefix (optional)
        /// </param>
        /// <param name="port">
        /// Server Port (optional)
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
        public ApiStoragesRedisValidateCreateRequest(
            string? description,
            string? host,
            int? id,
            string? password,
            string? path,
            string? port,
            int? project,
            string? regexFilter,
            string? title,
            bool? useBlobUrls)
        {
            this.Description = description;
            this.Host = host;
            this.Id = id;
            this.Password = password;
            this.Path = path;
            this.Port = port;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.Title = title;
            this.UseBlobUrls = useBlobUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesRedisValidateCreateRequest" /> class.
        /// </summary>
        public ApiStoragesRedisValidateCreateRequest()
        {
        }
    }
}