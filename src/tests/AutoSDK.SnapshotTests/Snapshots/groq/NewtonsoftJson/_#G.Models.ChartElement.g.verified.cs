//HintName: G.Models.ChartElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChartElement
    {
        /// <summary>
        /// The label for this chart element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// The group this element belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group")]
        public string? Group { get; set; }

        /// <summary>
        /// The value for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// The points for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Points { get; set; }

        /// <summary>
        /// The angle for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("angle")]
        public double? Angle { get; set; }

        /// <summary>
        /// The radius for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("radius")]
        public double? Radius { get; set; }

        /// <summary>
        /// The minimum value for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min")]
        public double? Min { get; set; }

        /// <summary>
        /// The first quartile value for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_quartile")]
        public double? FirstQuartile { get; set; }

        /// <summary>
        /// The median value for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("median")]
        public double? Median { get; set; }

        /// <summary>
        /// The third quartile value for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("third_quartile")]
        public double? ThirdQuartile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max")]
        public double? Max { get; set; }

        /// <summary>
        /// The outliers for this element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outliers")]
        public global::System.Collections.Generic.IList<double>? Outliers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartElement" /> class.
        /// </summary>
        /// <param name="label">
        /// The label for this chart element
        /// </param>
        /// <param name="group">
        /// The group this element belongs to
        /// </param>
        /// <param name="value">
        /// The value for this element
        /// </param>
        /// <param name="points">
        /// The points for this element
        /// </param>
        /// <param name="angle">
        /// The angle for this element
        /// </param>
        /// <param name="radius">
        /// The radius for this element
        /// </param>
        /// <param name="min">
        /// The minimum value for this element
        /// </param>
        /// <param name="firstQuartile">
        /// The first quartile value for this element
        /// </param>
        /// <param name="median">
        /// The median value for this element
        /// </param>
        /// <param name="thirdQuartile">
        /// The third quartile value for this element
        /// </param>
        /// <param name="max"></param>
        /// <param name="outliers">
        /// The outliers for this element
        /// </param>
        public ChartElement(
            string label,
            string? group,
            double? value,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? points,
            double? angle,
            double? radius,
            double? min,
            double? firstQuartile,
            double? median,
            double? thirdQuartile,
            double? max,
            global::System.Collections.Generic.IList<double>? outliers)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Group = group;
            this.Value = value;
            this.Points = points;
            this.Angle = angle;
            this.Radius = radius;
            this.Min = min;
            this.FirstQuartile = firstQuartile;
            this.Median = median;
            this.ThirdQuartile = thirdQuartile;
            this.Max = max;
            this.Outliers = outliers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartElement" /> class.
        /// </summary>
        public ChartElement()
        {
        }
    }
}