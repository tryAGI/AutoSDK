//HintName: G.Models.ImageColor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageColor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rgb")]
        public global::System.Collections.Generic.IList<int>? Rgb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("std")]
        public global::System.Collections.Generic.IList<double>? Std { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageColor" /> class.
        /// </summary>
        /// <param name="rgb"></param>
        /// <param name="std"></param>
        /// <param name="weight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageColor(
            global::System.Collections.Generic.IList<int>? rgb,
            global::System.Collections.Generic.IList<double>? std,
            double? weight)
        {
            this.Rgb = rgb;
            this.Std = std;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageColor" /> class.
        /// </summary>
        public ImageColor()
        {
        }
    }
}