//HintName: G.Models.OcrWord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrWord
    {
        /// <summary>
        /// The word ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The recognized text of this word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Bounding box coordinates for this word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        public global::G.OcrWordBoundingBox? BoundingBox { get; set; }

        /// <summary>
        /// Confidence score for this word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrWord" /> class.
        /// </summary>
        /// <param name="id">
        /// The word ID.
        /// </param>
        /// <param name="text">
        /// The recognized text of this word.
        /// </param>
        /// <param name="boundingBox">
        /// Bounding box coordinates for this word.
        /// </param>
        /// <param name="confidence">
        /// Confidence score for this word.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrWord(
            int? id,
            string? text,
            global::G.OcrWordBoundingBox? boundingBox,
            double? confidence)
        {
            this.Id = id;
            this.Text = text;
            this.BoundingBox = boundingBox;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrWord" /> class.
        /// </summary>
        public OcrWord()
        {
        }
    }
}