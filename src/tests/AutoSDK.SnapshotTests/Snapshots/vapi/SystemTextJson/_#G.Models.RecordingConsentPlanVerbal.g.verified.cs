//HintName: G.Models.RecordingConsentPlanVerbal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordingConsentPlanVerbal
    {
        /// <summary>
        /// This is the message asking for consent to record the call.<br/>
        /// If the type is `stay-on-line`, the message should ask the user to hang up if they do not consent.<br/>
        /// If the type is `verbal`, the message should ask the user to verbally consent or decline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// This is the voice to use for the consent message. If not specified, inherits from the assistant's voice.<br/>
        /// Use a different voice for the consent message for a better user experience.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>))]
        public global::G.OneOf<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>? Voice { get; set; }

        /// <summary>
        /// This is the type of recording consent plan. This type assumes consent is granted if the user verbally consents or declines.<br/>
        /// Example: verbal
        /// </summary>
        /// <example>verbal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RecordingConsentPlanVerbalTypeJsonConverter))]
        public global::G.RecordingConsentPlanVerbalType Type { get; set; }

        /// <summary>
        /// Tool to execute if user verbally declines recording consent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("declineTool")]
        public object? DeclineTool { get; set; }

        /// <summary>
        /// ID of existing tool to execute if user verbally declines recording consent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("declineToolId")]
        public string? DeclineToolId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingConsentPlanVerbal" /> class.
        /// </summary>
        /// <param name="message">
        /// This is the message asking for consent to record the call.<br/>
        /// If the type is `stay-on-line`, the message should ask the user to hang up if they do not consent.<br/>
        /// If the type is `verbal`, the message should ask the user to verbally consent or decline.
        /// </param>
        /// <param name="voice">
        /// This is the voice to use for the consent message. If not specified, inherits from the assistant's voice.<br/>
        /// Use a different voice for the consent message for a better user experience.
        /// </param>
        /// <param name="type">
        /// This is the type of recording consent plan. This type assumes consent is granted if the user verbally consents or declines.<br/>
        /// Example: verbal
        /// </param>
        /// <param name="declineTool">
        /// Tool to execute if user verbally declines recording consent
        /// </param>
        /// <param name="declineToolId">
        /// ID of existing tool to execute if user verbally declines recording consent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordingConsentPlanVerbal(
            string message,
            global::G.OneOf<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>? voice,
            global::G.RecordingConsentPlanVerbalType type,
            object? declineTool,
            string? declineToolId)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Voice = voice;
            this.Type = type;
            this.DeclineTool = declineTool;
            this.DeclineToolId = declineToolId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingConsentPlanVerbal" /> class.
        /// </summary>
        public RecordingConsentPlanVerbal()
        {
        }
    }
}