//HintName: G.Models.ScoreConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a score
    /// </summary>
    public sealed partial class ScoreConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScoreConfigDataType DataType { get; set; } = default!;

        /// <summary>
        /// Whether the score config is archived. Defaults to false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isArchived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsArchived { get; set; } = default!;

        /// <summary>
        /// Sets minimum value for numerical scores. If not set, the minimum value defaults to -∞
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minValue")]
        public double? MinValue { get; set; }

        /// <summary>
        /// Sets maximum value for numerical scores. If not set, the maximum value defaults to +∞
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxValue")]
        public double? MaxValue { get; set; }

        /// <summary>
        /// Configures custom categories for categorical scores
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::System.Collections.Generic.IList<global::G.ConfigCategory>? Categories { get; set; }

        /// <summary>
        /// Description of the score config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreConfig" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId"></param>
        /// <param name="dataType"></param>
        /// <param name="isArchived">
        /// Whether the score config is archived. Defaults to false
        /// </param>
        /// <param name="minValue">
        /// Sets minimum value for numerical scores. If not set, the minimum value defaults to -∞
        /// </param>
        /// <param name="maxValue">
        /// Sets maximum value for numerical scores. If not set, the maximum value defaults to +∞
        /// </param>
        /// <param name="categories">
        /// Configures custom categories for categorical scores
        /// </param>
        /// <param name="description">
        /// Description of the score config
        /// </param>
        public ScoreConfig(
            string id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string projectId,
            global::G.ScoreConfigDataType dataType,
            bool isArchived,
            double? minValue,
            double? maxValue,
            global::System.Collections.Generic.IList<global::G.ConfigCategory>? categories,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DataType = dataType;
            this.IsArchived = isArchived;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.Categories = categories;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreConfig" /> class.
        /// </summary>
        public ScoreConfig()
        {
        }
    }
}