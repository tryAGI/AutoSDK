//HintName: G.Models.AssignmentSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignmentSettings
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Automatic / Manual<br/>
        /// * `auto_distribution` - Label Stream distributes tasks automatically to annotators<br/>
        /// * `assigned_only` - Label Stream shows tasks only to assigned users
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_stream_task_distribution")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LabelStreamTaskDistributionEnumJsonConverter))]
        public global::G.LabelStreamTaskDistributionEnum? LabelStreamTaskDistribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentSettings" /> class.
        /// </summary>
        /// <param name="labelStreamTaskDistribution">
        /// Automatic / Manual<br/>
        /// * `auto_distribution` - Label Stream distributes tasks automatically to annotators<br/>
        /// * `assigned_only` - Label Stream shows tasks only to assigned users
        /// </param>
        /// <param name="project"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public AssignmentSettings(
            global::G.LabelStreamTaskDistributionEnum? labelStreamTaskDistribution,
            int? project,
            int id = default!)
        {
            this.Id = id;
            this.LabelStreamTaskDistribution = labelStreamTaskDistribution;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentSettings" /> class.
        /// </summary>
        public AssignmentSettings()
        {
        }
    }
}