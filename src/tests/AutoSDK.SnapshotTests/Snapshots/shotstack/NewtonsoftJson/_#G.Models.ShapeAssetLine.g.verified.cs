//HintName: G.Models.ShapeAssetLine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration settings for the line shape. Required when `shape` is set to `line`.
    /// </summary>
    public sealed partial class ShapeAssetLine
    {
        /// <summary>
        /// Set the length of the line shape in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("length", Required = global::Newtonsoft.Json.Required.Always)]
        public int Length { get; set; } = default!;

        /// <summary>
        /// Set the thickness of the line in pixels.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::Newtonsoft.Json.JsonProperty("thickness", Required = global::Newtonsoft.Json.Required.Always)]
        public int Thickness { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetLine" /> class.
        /// </summary>
        /// <param name="length">
        /// Set the length of the line shape in pixels.<br/>
        /// Example: 100
        /// </param>
        /// <param name="thickness">
        /// Set the thickness of the line in pixels.<br/>
        /// Example: 4
        /// </param>
        public ShapeAssetLine(
            int length,
            int thickness)
        {
            this.Length = length;
            this.Thickness = thickness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetLine" /> class.
        /// </summary>
        public ShapeAssetLine()
        {
        }
    }
}