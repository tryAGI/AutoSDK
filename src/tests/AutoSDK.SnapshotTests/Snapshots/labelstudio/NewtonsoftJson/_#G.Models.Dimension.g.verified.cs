//HintName: G.Models.Dimension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for Dimension model.<br/>
    /// Handles serialization and validation for CRUD operations on dimensions.<br/>
    /// The project and created_by fields are set automatically from the request context.
    /// </summary>
    public sealed partial class Dimension
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
        /// User who created this dimension<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Human-readable description of what this dimension represents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Method used to extract values from annotation JSON
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_method")]
        public string? ExtractionMethod { get; set; }

        /// <summary>
        /// Parameters specific to the extraction method. See metrics.py for available extraction methods and their parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_method_params")]
        public object? ExtractionMethodParams { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Whether this dimension is used in agreement calculations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Whether this dimension was manually created by a user. System-generated dimensions have this set to False.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_user_defined")]
        public bool? IsUserDefined { get; set; }

        /// <summary>
        /// Parameters for the metric. See metrics.py for available metrics and their parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_params")]
        public object? MetricParams { get; set; }

        /// <summary>
        /// Strategy for comparing dimension values across annotators
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_type")]
        public string? MetricType { get; set; }

        /// <summary>
        /// Unique identifier for this dimension within the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Display order within the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order")]
        public int? Order { get; set; }

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
        /// Initializes a new instance of the <see cref="Dimension" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique identifier for this dimension within the project
        /// </param>
        /// <param name="controlTag">
        /// Name of the control tag this dimension is extracted from. Set automatically for system dimensions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// User who created this dimension<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Human-readable description of what this dimension represents
        /// </param>
        /// <param name="extractionMethod">
        /// Method used to extract values from annotation JSON
        /// </param>
        /// <param name="extractionMethodParams">
        /// Parameters specific to the extraction method. See metrics.py for available extraction methods and their parameters.
        /// </param>
        /// <param name="isActive">
        /// Whether this dimension is used in agreement calculations.
        /// </param>
        /// <param name="isUserDefined">
        /// Whether this dimension was manually created by a user. System-generated dimensions have this set to False.
        /// </param>
        /// <param name="metricParams">
        /// Parameters for the metric. See metrics.py for available metrics and their parameters.
        /// </param>
        /// <param name="metricType">
        /// Strategy for comparing dimension values across annotators
        /// </param>
        /// <param name="order">
        /// Display order within the project
        /// </param>
        /// <param name="allowedMetricsWithParams">
        /// Dictionary mapping metric type names to their parameter schemas.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="project">
        /// Project this dimension belongs to<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        public Dimension(
            string name,
            string? controlTag,
            int? createdBy,
            string? description,
            string? extractionMethod,
            object? extractionMethodParams,
            bool? isActive,
            bool? isUserDefined,
            object? metricParams,
            string? metricType,
            int? order,
            string allowedMetricsWithParams = default!,
            global::System.DateTime createdAt = default!,
            int id = default!,
            int project = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.AllowedMetricsWithParams = allowedMetricsWithParams;
            this.ControlTag = controlTag;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.ExtractionMethod = extractionMethod;
            this.ExtractionMethodParams = extractionMethodParams;
            this.Id = id;
            this.IsActive = isActive;
            this.IsUserDefined = isUserDefined;
            this.MetricParams = metricParams;
            this.MetricType = metricType;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Order = order;
            this.Project = project;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dimension" /> class.
        /// </summary>
        public Dimension()
        {
        }
    }
}