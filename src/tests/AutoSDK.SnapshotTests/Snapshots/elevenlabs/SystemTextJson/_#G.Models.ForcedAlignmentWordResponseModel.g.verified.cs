//HintName: G.Models.ForcedAlignmentWordResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model representing a single word with its timing information from the aligner.<br/>
    /// Example: {"end":1.02,"start":0,"text":"Hello"}
    /// </summary>
    public sealed partial class ForcedAlignmentWordResponseModel
    {
        /// <summary>
        /// The word that was transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The start time of the word in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// The end time of the word in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentWordResponseModel" /> class.
        /// </summary>
        /// <param name="text">
        /// The word that was transcribed.
        /// </param>
        /// <param name="start">
        /// The start time of the word in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the word in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForcedAlignmentWordResponseModel(
            string text,
            double start,
            double end)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentWordResponseModel" /> class.
        /// </summary>
        public ForcedAlignmentWordResponseModel()
        {
        }
    }
}