//HintName: G.Models.BBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bounding box with coordinates and optional metadata.
    /// </summary>
    public sealed partial class BBox
    {
        /// <summary>
        /// X coordinate of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public double X { get; set; } = default!;

        /// <summary>
        /// Y coordinate of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public double Y { get; set; } = default!;

        /// <summary>
        /// Width of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("w", Required = global::Newtonsoft.Json.Required.Always)]
        public double W { get; set; } = default!;

        /// <summary>
        /// Height of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("h", Required = global::Newtonsoft.Json.Required.Always)]
        public double H { get; set; } = default!;

        /// <summary>
        /// Confidence score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Start index in the text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// End index in the text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Label for the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BBox" /> class.
        /// </summary>
        /// <param name="x">
        /// X coordinate of the bounding box
        /// </param>
        /// <param name="y">
        /// Y coordinate of the bounding box
        /// </param>
        /// <param name="w">
        /// Width of the bounding box
        /// </param>
        /// <param name="h">
        /// Height of the bounding box
        /// </param>
        /// <param name="confidence">
        /// Confidence score
        /// </param>
        /// <param name="startIndex">
        /// Start index in the text
        /// </param>
        /// <param name="endIndex">
        /// End index in the text
        /// </param>
        /// <param name="label">
        /// Label for the bounding box
        /// </param>
        public BBox(
            double x,
            double y,
            double w,
            double h,
            double? confidence,
            int? startIndex,
            int? endIndex,
            string? label)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
            this.Confidence = confidence;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BBox" /> class.
        /// </summary>
        public BBox()
        {
        }
    }
}