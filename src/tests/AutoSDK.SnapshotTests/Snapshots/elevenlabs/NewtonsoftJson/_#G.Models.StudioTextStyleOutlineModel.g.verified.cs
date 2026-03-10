//HintName: G.Models.StudioTextStyleOutlineModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioTextStyleOutlineModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("opacity", Required = global::Newtonsoft.Json.Required.Always)]
        public double Opacity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public double Width { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioTextStyleOutlineModel" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="color"></param>
        /// <param name="opacity"></param>
        /// <param name="width"></param>
        public StudioTextStyleOutlineModel(
            bool enabled,
            string color,
            double opacity,
            double width)
        {
            this.Enabled = enabled;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.Opacity = opacity;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioTextStyleOutlineModel" /> class.
        /// </summary>
        public StudioTextStyleOutlineModel()
        {
        }
    }
}