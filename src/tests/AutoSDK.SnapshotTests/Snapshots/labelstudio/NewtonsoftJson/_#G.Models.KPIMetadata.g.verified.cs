//HintName: G.Models.KPIMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for KPI metadata information.<br/>
    /// Provides information about available KPIs including their keys, labels,<br/>
    /// dependencies, and configuration.
    /// </summary>
    public sealed partial class KPIMetadata
    {
        /// <summary>
        /// Aggregation method for the KPI: count, sum, avg, max, min, or snapshot. Snapshot KPIs show point-in-time counts rather than event totals.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aggregation_method")]
        public string? AggregationMethod { get; set; }

        /// <summary>
        /// Base class name that the KPI inherits from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_class", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseClass { get; set; } = default!;

        /// <summary>
        /// Formula for calculated KPIs defining how to derive the value from component KPIs. Structure: {"type": "ratio|sum|difference|product", "numerator": "kpi_key", "denominator": "kpi_key"}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("calculation_formula")]
        public object? CalculationFormula { get; set; }

        /// <summary>
        /// Database column used for date filtering and aggregation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_column")]
        public string? DateColumn { get; set; }

        /// <summary>
        /// List of other KPI keys that this KPI depends on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("depends_on_kpis", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DependsOnKpis { get; set; } = default!;

        /// <summary>
        /// Whether this KPI is calculated from other KPIs (has dependencies)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_calculated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsCalculated { get; set; } = default!;

        /// <summary>
        /// Whether this KPI is a label/filter type that does not show a value per se
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_label_type", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsLabelType { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the KPI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Human-readable label for the KPI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Whether the KPI value is a percentage (DEPRECATED: use unit)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Percentage { get; set; } = default!;

        /// <summary>
        /// Unit of measurement: seconds, minutes, hours, count, or ratio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Unit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIMetadata" /> class.
        /// </summary>
        /// <param name="baseClass">
        /// Base class name that the KPI inherits from
        /// </param>
        /// <param name="dependsOnKpis">
        /// List of other KPI keys that this KPI depends on
        /// </param>
        /// <param name="isCalculated">
        /// Whether this KPI is calculated from other KPIs (has dependencies)
        /// </param>
        /// <param name="isLabelType">
        /// Whether this KPI is a label/filter type that does not show a value per se
        /// </param>
        /// <param name="key">
        /// Unique identifier for the KPI
        /// </param>
        /// <param name="percentage">
        /// Whether the KPI value is a percentage (DEPRECATED: use unit)
        /// </param>
        /// <param name="unit">
        /// Unit of measurement: seconds, minutes, hours, count, or ratio
        /// </param>
        /// <param name="aggregationMethod">
        /// Aggregation method for the KPI: count, sum, avg, max, min, or snapshot. Snapshot KPIs show point-in-time counts rather than event totals.
        /// </param>
        /// <param name="calculationFormula">
        /// Formula for calculated KPIs defining how to derive the value from component KPIs. Structure: {"type": "ratio|sum|difference|product", "numerator": "kpi_key", "denominator": "kpi_key"}
        /// </param>
        /// <param name="dateColumn">
        /// Database column used for date filtering and aggregation
        /// </param>
        /// <param name="label">
        /// Human-readable label for the KPI
        /// </param>
        public KPIMetadata(
            string baseClass,
            global::System.Collections.Generic.IList<string> dependsOnKpis,
            bool isCalculated,
            bool isLabelType,
            string key,
            bool percentage,
            string unit,
            string? aggregationMethod,
            object? calculationFormula,
            string? dateColumn,
            string? label)
        {
            this.AggregationMethod = aggregationMethod;
            this.BaseClass = baseClass ?? throw new global::System.ArgumentNullException(nameof(baseClass));
            this.CalculationFormula = calculationFormula;
            this.DateColumn = dateColumn;
            this.DependsOnKpis = dependsOnKpis ?? throw new global::System.ArgumentNullException(nameof(dependsOnKpis));
            this.IsCalculated = isCalculated;
            this.IsLabelType = isLabelType;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label;
            this.Percentage = percentage;
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIMetadata" /> class.
        /// </summary>
        public KPIMetadata()
        {
        }
    }
}