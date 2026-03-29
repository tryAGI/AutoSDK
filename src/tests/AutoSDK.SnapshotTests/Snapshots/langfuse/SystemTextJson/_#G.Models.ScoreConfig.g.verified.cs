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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScoreConfigDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScoreConfigDataType DataType { get; set; }

        /// <summary>
        /// Whether the score config is archived. Defaults to false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isArchived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsArchived { get; set; }

        /// <summary>
        /// Sets minimum value for numerical scores. If not set, the minimum value defaults to -∞
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minValue")]
        public double? MinValue { get; set; }

        /// <summary>
        /// Sets maximum value for numerical scores. If not set, the maximum value defaults to +∞
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxValue")]
        public double? MaxValue { get; set; }

        /// <summary>
        /// Configures custom categories for categorical scores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<global::G.ConfigCategory>? Categories { get; set; }

        /// <summary>
        /// Description of the score config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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