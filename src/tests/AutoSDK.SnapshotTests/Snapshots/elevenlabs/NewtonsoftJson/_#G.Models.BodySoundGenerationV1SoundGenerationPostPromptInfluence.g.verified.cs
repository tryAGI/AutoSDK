//HintName: G.Models.BodySoundGenerationV1SoundGenerationPostPromptInfluence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A higher prompt influence makes your generation follow the prompt more closely while also making generations less variable. Must be a value between 0 and 1. Defaults to 0.3.<br/>
    /// Default Value: 0.3F
    /// </summary>
    public sealed partial class BodySoundGenerationV1SoundGenerationPostPromptInfluence
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}