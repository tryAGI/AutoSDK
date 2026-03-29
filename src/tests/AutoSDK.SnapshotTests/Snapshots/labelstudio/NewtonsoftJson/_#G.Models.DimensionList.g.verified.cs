//HintName: G.Models.DimensionList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Lightweight serializer for listing dimensions.<br/>
    /// Excludes detailed parameters for performance in list views.
    /// </summary>
    public sealed partial class DimensionList
    {
        /// <summary>
        /// Dictionary mapping metric type names to their parameter schemas.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("allowed_metrics_with_params")]
        public string AllowedMetricsWithParams { get; set; } = default!;

        /// <summary>
        /// Name of the control tag this dimension is extracted from. Set automatically for system dimensions.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("control_tag")]
        public string? ControlTag { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Human-readable description of what this dimension represents<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Method used to extract values from annotation JSON<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("extraction_method")]
        public string ExtractionMethod { get; set; } = default!;

        /// <summary>
        /// Parameters specific to the extraction method. See metrics.py for available extraction methods and their parameters.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("extraction_method_params")]
        public object ExtractionMethodParams { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Whether this dimension is used in agreement calculations.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("is_active")]
        public bool IsActive { get; set; } = default!;

        /// <summary>
        /// Whether this dimension was manually created by a user. System-generated dimensions have this set to False.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("is_user_defined")]
        public bool IsUserDefined { get; set; } = default!;

        /// <summary>
        /// Parameters for the metric. See metrics.py for available metrics and their parameters.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("metric_params")]
        public object MetricParams { get; set; } = default!;

        /// <summary>
        /// Strategy for comparing dimension values across annotators<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("metric_type")]
        public string MetricType { get; set; } = default!;

        /// <summary>
        /// Unique identifier for this dimension within the project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Display order within the project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("order")]
        public int Order { get; set; } = default!;

        /// <summary>
        /// Project this dimension belongs to<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int Project { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="DimensionList" /> class.
        /// </summary>
        /// <param name="controlTag">
        /// Name of the control tag this dimension is extracted from. Set automatically for system dimensions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="allowedMetricsWithParams">
        /// Dictionary mapping metric type names to their parameter schemas.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Human-readable description of what this dimension represents<br/>
        /// Included only in responses
        /// </param>
        /// <param name="extractionMethod">
        /// Method used to extract values from annotation JSON<br/>
        /// Included only in responses
        /// </param>
        /// <param name="extractionMethodParams">
        /// Parameters specific to the extraction method. See metrics.py for available extraction methods and their parameters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="isActive">
        /// Whether this dimension is used in agreement calculations.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="isUserDefined">
        /// Whether this dimension was manually created by a user. System-generated dimensions have this set to False.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metricParams">
        /// Parameters for the metric. See metrics.py for available metrics and their parameters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metricType">
        /// Strategy for comparing dimension values across annotators<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Unique identifier for this dimension within the project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="order">
        /// Display order within the project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="project">
        /// Project this dimension belongs to<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        public DimensionList(
            string? controlTag,
            string allowedMetricsWithParams = default!,
            global::System.DateTime createdAt = default!,
            string description = default!,
            string extractionMethod = default!,
            object extractionMethodParams = default!,
            int id = default!,
            bool isActive = default!,
            bool isUserDefined = default!,
            object metricParams = default!,
            string metricType = default!,
            string name = default!,
            int order = default!,
            int project = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.AllowedMetricsWithParams = allowedMetricsWithParams;
            this.ControlTag = controlTag;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.ExtractionMethod = extractionMethod;
            this.ExtractionMethodParams = extractionMethodParams;
            this.Id = id;
            this.IsActive = isActive;
            this.IsUserDefined = isUserDefined;
            this.MetricParams = metricParams;
            this.MetricType = metricType;
            this.Name = name;
            this.Order = order;
            this.Project = project;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionList" /> class.
        /// </summary>
        public DimensionList()
        {
        }
    }
}