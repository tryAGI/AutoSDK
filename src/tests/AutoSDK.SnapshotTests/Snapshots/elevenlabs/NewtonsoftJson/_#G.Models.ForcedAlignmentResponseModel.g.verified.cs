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
        [global::Newtonsoft.Json.JsonProperty("characters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ForcedAlignmentCharacterResponseModel> Characters { get; set; } = default!;

        /// <summary>
        /// List of words with their timing information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ForcedAlignmentWordResponseModel> Words { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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