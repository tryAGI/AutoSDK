//HintName: G.Models.LocalFilesExportStorage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalFilesExportStorage
    {
        /// <summary>
        /// Deletion from storage enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Last sync finished time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_sync")]
        public global::System.DateTime? LastSync { get; set; }

        /// <summary>
        /// Count of tasks synced last time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_sync_count")]
        public int? LastSyncCount { get; set; }

        /// <summary>
        /// Last sync job ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_sync_job")]
        public string? LastSyncJob { get; set; }

        /// <summary>
        /// Meta and debug information about storage processes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Local path
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// A unique integer value identifying this project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// Regex for filtering objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StatusC5aEnumJsonConverter))]
        public global::G.StatusC5aEnum? Status { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("synchronizable")]
        public bool? Synchronizable { get; set; }

        /// <summary>
        /// Cloud storage title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Traceback report for the last failed sync
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Default Value: localfiles<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Interpret objects as BLOBs and generate URLs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalFilesExportStorage" /> class.
        /// </summary>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="lastSync">
        /// Last sync finished time
        /// </param>
        /// <param name="lastSyncCount">
        /// Count of tasks synced last time
        /// </param>
        /// <param name="lastSyncJob">
        /// Last sync job ID
        /// </param>
        /// <param name="meta">
        /// Meta and debug information about storage processes
        /// </param>
        /// <param name="path">
        /// Local path
        /// </param>
        /// <param name="regexFilter">
        /// Regex for filtering objects
        /// </param>
        /// <param name="status">
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="traceback">
        /// Traceback report for the last failed sync
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs
        /// </param>
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Default Value: localfiles<br/>
        /// Included only in responses
        /// </param>
        public LocalFilesExportStorage(
            int project,
            bool? canDeleteObjects,
            string? description,
            global::System.DateTime? lastSync,
            int? lastSyncCount,
            string? lastSyncJob,
            object? meta,
            string? path,
            string? regexFilter,
            global::G.StatusC5aEnum? status,
            bool? synchronizable,
            string? title,
            string? traceback,
            bool? useBlobUrls,
            global::System.DateTime createdAt = default!,
            int id = default!,
            string type = default!)
        {
            this.CanDeleteObjects = canDeleteObjects;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Id = id;
            this.LastSync = lastSync;
            this.LastSyncCount = lastSyncCount;
            this.LastSyncJob = lastSyncJob;
            this.Meta = meta;
            this.Path = path;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.Status = status;
            this.Synchronizable = synchronizable;
            this.Title = title;
            this.Traceback = traceback;
            this.Type = type;
            this.UseBlobUrls = useBlobUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalFilesExportStorage" /> class.
        /// </summary>
        public LocalFilesExportStorage()
        {
        }
    }
}