//HintName: G.Models.KPIValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for a single KPI value (no segmentation).
    /// </summary>
    public sealed partial class KPIValue
    {
        /// <summary>
        /// Unit of measurement: seconds, minutes, hours, count, or ratio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Unit { get; set; } = default!;

        /// <summary>
        /// The KPI value in its native unit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIValue" /> class.
        /// </summary>
        /// <param name="unit">
        /// Unit of measurement: seconds, minutes, hours, count, or ratio
        /// </param>
        /// <param name="value">
        /// The KPI value in its native unit
        /// </param>
        public KPIValue(
            string unit,
            double? value)
        {
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIValue" /> class.
        /// </summary>
        public KPIValue()
        {
        }
    }
}