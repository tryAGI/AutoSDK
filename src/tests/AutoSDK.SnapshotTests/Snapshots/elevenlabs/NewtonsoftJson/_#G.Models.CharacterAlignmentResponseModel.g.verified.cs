//HintName: G.Models.CharacterAlignmentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharacterAlignmentResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Characters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_start_times_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> CharacterStartTimesSeconds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_end_times_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> CharacterEndTimesSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterAlignmentResponseModel" /> class.
        /// </summary>
        /// <param name="characters"></param>
        /// <param name="characterStartTimesSeconds"></param>
        /// <param name="characterEndTimesSeconds"></param>
        public CharacterAlignmentResponseModel(
            global::System.Collections.Generic.IList<string> characters,
            global::System.Collections.Generic.IList<double> characterStartTimesSeconds,
            global::System.Collections.Generic.IList<double> characterEndTimesSeconds)
        {
            this.Characters = characters ?? throw new global::System.ArgumentNullException(nameof(characters));
            this.CharacterStartTimesSeconds = characterStartTimesSeconds ?? throw new global::System.ArgumentNullException(nameof(characterStartTimesSeconds));
            this.CharacterEndTimesSeconds = characterEndTimesSeconds ?? throw new global::System.ArgumentNullException(nameof(characterEndTimesSeconds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterAlignmentResponseModel" /> class.
        /// </summary>
        public CharacterAlignmentResponseModel()
        {
        }
    }
}