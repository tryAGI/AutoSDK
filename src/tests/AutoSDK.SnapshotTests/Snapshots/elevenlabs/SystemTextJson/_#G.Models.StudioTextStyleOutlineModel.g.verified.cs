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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Opacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioTextStyleOutlineModel" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="color"></param>
        /// <param name="opacity"></param>
        /// <param name="width"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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