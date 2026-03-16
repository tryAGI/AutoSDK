//HintName: G.Models.RequestElevenMultilingualV2VoiceDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestElevenMultilingualV2VoiceDiscriminator
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
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualV2VoiceDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public RequestElevenMultilingualV2VoiceDiscriminator(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualV2VoiceDiscriminator" /> class.
        /// </summary>
        public RequestElevenMultilingualV2VoiceDiscriminator()
        {
        }
    }
}