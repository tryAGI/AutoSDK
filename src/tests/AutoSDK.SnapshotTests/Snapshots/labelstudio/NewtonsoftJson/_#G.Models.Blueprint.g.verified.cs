//HintName: G.Models.Blueprint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Blueprint
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Project description
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
        /// Labeling configuration in XML format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_config")]
        public string? LabelConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("share_id")]
        public string ShareId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("short_url")]
        public string ShortUrl { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("task_count")]
        public string TaskCount { get; set; } = default!;

        /// <summary>
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Blueprint" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="createdBy"></param>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="labelConfig">
        /// Labeling configuration in XML format
        /// </param>
        /// <param name="title">
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="shareId">
        /// Included only in responses
        /// </param>
        /// <param name="shortUrl">
        /// Included only in responses
        /// </param>
        /// <param name="taskCount">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        public Blueprint(
            int project,
            int? createdBy,
            string? description,
            string? labelConfig,
            string? title,
            global::System.DateTime createdAt = default!,
            int id = default!,
            string shareId = default!,
            string shortUrl = default!,
            string taskCount = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id;
            this.LabelConfig = labelConfig;
            this.Project = project;
            this.ShareId = shareId;
            this.ShortUrl = shortUrl;
            this.TaskCount = taskCount;
            this.Title = title;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Blueprint" /> class.
        /// </summary>
        public Blueprint()
        {
        }
    }
}