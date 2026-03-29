//HintName: G.Models.DimensionCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for creating new dimensions.<br/>
    /// Excludes is_user_defined from user input - new dimensions are always user-defined.
    /// </summary>
    public sealed partial class DimensionCreateRequest
    {
        /// <summary>
        /// Human-readable description of what this dimension represents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Method used to extract values from annotation JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_method")]
        public string? ExtractionMethod { get; set; }

        /// <summary>
        /// Parameters specific to the extraction method. See metrics.py for available extraction methods and their parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_method_params")]
        public object? ExtractionMethodParams { get; set; }

        /// <summary>
        /// Whether this dimension is used in agreement calculations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Parameters for the metric. See metrics.py for available metrics and their parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_params")]
        public object? MetricParams { get; set; }

        /// <summary>
        /// Strategy for comparing dimension values across annotators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_type")]
        public string? MetricType { get; set; }

        /// <summary>
        /// Unique identifier for this dimension within the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Display order within the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique identifier for this dimension within the project
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
        /// <param name="metricParams">
        /// Parameters for the metric. See metrics.py for available metrics and their parameters.
        /// </param>
        /// <param name="metricType">
        /// Strategy for comparing dimension values across annotators
        /// </param>
        /// <param name="order">
        /// Display order within the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DimensionCreateRequest(
            string name,
            string? description,
            string? extractionMethod,
            object? extractionMethodParams,
            bool? isActive,
            object? metricParams,
            string? metricType,
            int? order)
        {
            this.Description = description;
            this.ExtractionMethod = extractionMethod;
            this.ExtractionMethodParams = extractionMethodParams;
            this.IsActive = isActive;
            this.MetricParams = metricParams;
            this.MetricType = metricType;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionCreateRequest" /> class.
        /// </summary>
        public DimensionCreateRequest()
        {
        }
    }
}