//HintName: G.Models.WordDurationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordDurationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endMs")]
        public int? EndMs { get; set; }

        /// <summary>
        /// This field has been deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitchScaleMaximum")]
        public double? PitchScaleMaximum { get; set; }

        /// <summary>
        /// This field has been deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitchScaleMinimum")]
        public double? PitchScaleMinimum { get; set; }

        /// <summary>
        /// This field has been deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceWordIndex")]
        public int? SourceWordIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startMs")]
        public int? StartMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordDurationResponse" /> class.
        /// </summary>
        /// <param name="endMs"></param>
        /// <param name="pitchScaleMaximum">
        /// This field has been deprecated.
        /// </param>
        /// <param name="pitchScaleMinimum">
        /// This field has been deprecated.
        /// </param>
        /// <param name="sourceWordIndex">
        /// This field has been deprecated.
        /// </param>
        /// <param name="startMs"></param>
        /// <param name="word"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordDurationResponse(
            int? endMs,
            double? pitchScaleMaximum,
            double? pitchScaleMinimum,
            int? sourceWordIndex,
            int? startMs,
            string? word)
        {
            this.EndMs = endMs;
            this.PitchScaleMaximum = pitchScaleMaximum;
            this.PitchScaleMinimum = pitchScaleMinimum;
            this.SourceWordIndex = sourceWordIndex;
            this.StartMs = startMs;
            this.Word = word;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordDurationResponse" /> class.
        /// </summary>
        public WordDurationResponse()
        {
        }
    }
}