//HintName: G.Models.ForcedAlignmentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model representing the response from the aligner service.
    /// </summary>
    public sealed partial class ForcedAlignmentResponseModel
    {
        /// <summary>
        /// List of characters with their timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ForcedAlignmentCharacterResponseModel> Characters { get; set; }

        /// <summary>
        /// List of words with their timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ForcedAlignmentWordResponseModel> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentResponseModel" /> class.
        /// </summary>
        /// <param name="characters">
        /// List of characters with their timing information.
        /// </param>
        /// <param name="words">
        /// List of words with their timing information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForcedAlignmentResponseModel(
            global::System.Collections.Generic.IList<global::G.ForcedAlignmentCharacterResponseModel> characters,
            global::System.Collections.Generic.IList<global::G.ForcedAlignmentWordResponseModel> words)
        {
            this.Characters = characters ?? throw new global::System.ArgumentNullException(nameof(characters));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentResponseModel" /> class.
        /// </summary>
        public ForcedAlignmentResponseModel()
        {
        }
    }
}