//HintName: G.Models.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator" /> class.
        /// </summary>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator()
        {
        }
    }
}