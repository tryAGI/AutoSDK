//HintName: G.Models.V2VideoGenerateRequestVideoInputVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequestVideoInputVoice
    {
        /// <summary>
        /// Example: Welcome to the new era of video creation with HeyGen! Simply type your script to get started!
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// Example: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: 2f72ee82b83d4b00af16c4771d611752
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}