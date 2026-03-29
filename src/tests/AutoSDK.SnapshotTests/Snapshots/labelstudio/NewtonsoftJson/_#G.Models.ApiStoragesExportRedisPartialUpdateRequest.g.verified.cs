//HintName: G.Models.ApiStoragesExportRedisPartialUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesExportRedisPartialUpdateRequest
    {
        /// <summary>
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Database ID of database to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("db")]
        public int? Db { get; set; }

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
        /// Storage title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportRedisPartialUpdateRequest" /> class.
        /// </summary>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="db">
        /// Database ID of database to use
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="host">
        /// Server Host IP (optional)
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
        /// <param name="title">
        /// Storage title
        /// </param>
        public ApiStoragesExportRedisPartialUpdateRequest(
            bool? canDeleteObjects,
            int? db,
            string? description,
            string? host,
            string? password,
            string? path,
            string? port,
            int? project,
            string? title)
        {
            this.CanDeleteObjects = canDeleteObjects;
            this.Db = db;
            this.Description = description;
            this.Host = host;
            this.Password = password;
            this.Path = path;
            this.Port = port;
            this.Project = project;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportRedisPartialUpdateRequest" /> class.
        /// </summary>
        public ApiStoragesExportRedisPartialUpdateRequest()
        {
        }
    }
}