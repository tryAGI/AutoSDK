//HintName: G.Models.ProjectsV2IterationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An iteration setting for an iteration field
    /// </summary>
    public sealed partial class ProjectsV2IterationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2IterationSetting" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="duration"></param>
        /// <param name="startDate"></param>
        public ProjectsV2IterationSetting(
            string id,
            string title,
            double? duration,
            string? startDate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Duration = duration;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2IterationSetting" /> class.
        /// </summary>
        public ProjectsV2IterationSetting()
        {
        }
    }
}