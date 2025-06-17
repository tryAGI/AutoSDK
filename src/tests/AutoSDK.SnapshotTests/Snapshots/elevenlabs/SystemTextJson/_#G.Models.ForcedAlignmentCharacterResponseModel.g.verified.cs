//HintName: G.Models.ForcedAlignmentCharacterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model representing a single character with its timing information from the aligner.
    /// </summary>
    public sealed partial class ForcedAlignmentCharacterResponseModel
    {
        /// <summary>
        /// The character that was transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The start time of the character in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// The end time of the character in seconds.
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
        /// Initializes a new instance of the <see cref="ForcedAlignmentCharacterResponseModel" /> class.
        /// </summary>
        /// <param name="text">
        /// The character that was transcribed.
        /// </param>
        /// <param name="start">
        /// The start time of the character in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the character in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForcedAlignmentCharacterResponseModel(
            string text,
            double start,
            double end)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentCharacterResponseModel" /> class.
        /// </summary>
        public ForcedAlignmentCharacterResponseModel()
        {
        }
    }
}