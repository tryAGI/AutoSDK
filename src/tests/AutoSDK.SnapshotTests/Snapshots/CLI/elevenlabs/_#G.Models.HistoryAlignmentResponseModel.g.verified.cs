//HintName: G.Models.HistoryAlignmentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HistoryAlignmentResponseModel
    {
        /// <summary>
        /// The characters in the alignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Characters { get; set; }

        /// <summary>
        /// The start times of the characters in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_start_times_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> CharacterStartTimesSeconds { get; set; }

        /// <summary>
        /// The end times of the characters in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_end_times_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> CharacterEndTimesSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryAlignmentResponseModel" /> class.
        /// </summary>
        /// <param name="characters">
        /// The characters in the alignment.
        /// </param>
        /// <param name="characterStartTimesSeconds">
        /// The start times of the characters in seconds.
        /// </param>
        /// <param name="characterEndTimesSeconds">
        /// The end times of the characters in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryAlignmentResponseModel(
            global::System.Collections.Generic.IList<string> characters,
            global::System.Collections.Generic.IList<double> characterStartTimesSeconds,
            global::System.Collections.Generic.IList<double> characterEndTimesSeconds)
        {
            this.Characters = characters ?? throw new global::System.ArgumentNullException(nameof(characters));
            this.CharacterStartTimesSeconds = characterStartTimesSeconds ?? throw new global::System.ArgumentNullException(nameof(characterStartTimesSeconds));
            this.CharacterEndTimesSeconds = characterEndTimesSeconds ?? throw new global::System.ArgumentNullException(nameof(characterEndTimesSeconds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryAlignmentResponseModel" /> class.
        /// </summary>
        public HistoryAlignmentResponseModel()
        {
        }
    }
}