//HintName: G.Models.Keypoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Keypoint
    {
        /// <summary>
        /// The x-axis pixel coordinate of the point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X { get; set; }

        /// <summary>
        /// The y-axis pixel coordinate of the point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Y { get; set; }

        /// <summary>
        /// Model confidence regarding keypoint visibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Identifier of keypoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClassId { get; set; }

        /// <summary>
        /// Type of keypoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Class { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Keypoint" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-axis pixel coordinate of the point
        /// </param>
        /// <param name="y">
        /// The y-axis pixel coordinate of the point
        /// </param>
        /// <param name="confidence">
        /// Model confidence regarding keypoint visibility.
        /// </param>
        /// <param name="classId">
        /// Identifier of keypoint.
        /// </param>
        /// <param name="class">
        /// Type of keypoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Keypoint(
            double x,
            double y,
            double confidence,
            int classId,
            string @class)
        {
            this.X = x;
            this.Y = y;
            this.Confidence = confidence;
            this.ClassId = classId;
            this.Class = @class ?? throw new global::System.ArgumentNullException(nameof(@class));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Keypoint" /> class.
        /// </summary>
        public Keypoint()
        {
        }
    }
}