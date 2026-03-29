//HintName: G.Models.CreateTalkStreamRequestScriptVariant22.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTalkStreamRequestScriptVariant22
    {
        /// <summary>
        /// The type of the script.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTalkStreamRequestScriptVariant2Type2 Type { get; set; }

        /// <summary>
        /// The URL of the audio file which will be used by the actor.<br/>
        /// File size is limit to 15MB.<br/>
        /// Example: https://path.to/audio.mp3
        /// </summary>
        /// <example>https://path.to/audio.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("audio_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkStreamRequestScriptVariant22" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// The URL of the audio file which will be used by the actor.<br/>
        /// File size is limit to 15MB.<br/>
        /// Example: https://path.to/audio.mp3
        /// </param>
        /// <param name="type">
        /// The type of the script.
        /// </param>
        public CreateTalkStreamRequestScriptVariant22(
            string audioUrl,
            global::G.CreateTalkStreamRequestScriptVariant2Type2 type)
        {
            this.Type = type;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkStreamRequestScriptVariant22" /> class.
        /// </summary>
        public CreateTalkStreamRequestScriptVariant22()
        {
        }
    }
}