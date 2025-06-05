//HintName: G.Models.ModelPricingImageUnits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingImageUnits
    {
        /// <summary>
        /// Default Value: image_units
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_image_unit", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerImageUnit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_width", Required = global::Newtonsoft.Json.Required.Always)]
        public int DefaultWidth { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_height", Required = global::Newtonsoft.Json.Required.Always)]
        public int DefaultHeight { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_iterations", Required = global::Newtonsoft.Json.Required.Always)]
        public int DefaultIterations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingImageUnits" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: image_units
        /// </param>
        /// <param name="centsPerImageUnit"></param>
        /// <param name="defaultWidth"></param>
        /// <param name="defaultHeight"></param>
        /// <param name="defaultIterations"></param>
        public ModelPricingImageUnits(
            double centsPerImageUnit,
            int defaultWidth,
            int defaultHeight,
            int defaultIterations,
            string? type)
        {
            this.CentsPerImageUnit = centsPerImageUnit;
            this.DefaultWidth = defaultWidth;
            this.DefaultHeight = defaultHeight;
            this.DefaultIterations = defaultIterations;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingImageUnits" /> class.
        /// </summary>
        public ModelPricingImageUnits()
        {
        }
    }
}