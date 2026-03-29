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
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X { get; set; }

        /// <summary>
        /// Y coordinate of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Y { get; set; }

        /// <summary>
        /// Width of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("w")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double W { get; set; }

        /// <summary>
        /// Height of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double H { get; set; }

        /// <summary>
        /// Confidence score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Start index in the text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// End index in the text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Label for the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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