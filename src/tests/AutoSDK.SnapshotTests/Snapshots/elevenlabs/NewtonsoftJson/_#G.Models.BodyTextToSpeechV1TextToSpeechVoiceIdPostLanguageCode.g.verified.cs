//HintName: G.Models.BodyTextToSpeechV1TextToSpeechVoiceIdPostLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 and Flash v2.5 support language enforcement. For other models, an error will be returned if language code is provided.
    /// </summary>
    public sealed partial class BodyTextToSpeechV1TextToSpeechVoiceIdPostLanguageCode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}