//HintName: G.Models.GenerateSpeechStreamingRequestPronunciationDictionary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object used to define custom pronunciations. <br/>
    ///  Example 1: {"live":{"type": "IPA", "pronunciation": "laɪv"}}. <br/>
    ///  Example 2: {"2022":{"type": "SAY_AS", "pronunciation": "twenty twenty two"}}
    /// </summary>
    public sealed partial class GenerateSpeechStreamingRequestPronunciationDictionary
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}