//HintName: G.Models.ShapeAssetCircle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration settings for the circle shape. Required when `shape` is set to `circle`.
    /// </summary>
    public sealed partial class ShapeAssetCircle
    {
        /// <summary>
        /// Set the radius of the circle shape in pixels.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::Newtonsoft.Json.JsonProperty("radius", Required = global::Newtonsoft.Json.Required.Always)]
        public int Radius { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetCircle" /> class.
        /// </summary>
        /// <param name="radius">
        /// Set the radius of the circle shape in pixels.<br/>
        /// Example: 800
        /// </param>
        public ShapeAssetCircle(
            int radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetCircle" /> class.
        /// </summary>
        public ShapeAssetCircle()
        {
        }
    }
}