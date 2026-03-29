//HintName: G.Models.TransferAssistant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferAssistant
    {
        /// <summary>
        /// Optional name for the transfer assistant<br/>
        /// Default Value: transfer-assistant<br/>
        /// Example: Sales Transfer Assistant
        /// </summary>
        /// <example>Sales Transfer Assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Model configuration for the transfer assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferAssistantModel Model { get; set; }

        /// <summary>
        /// These are the options for the transfer assistant's voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>))]
        public global::G.OneOf<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>? Voice { get; set; }

        /// <summary>
        /// These are the options for the transfer assistant's transcriber.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AssemblyAITranscriber, global::G.AzureSpeechTranscriber, global::G.CustomTranscriber, global::G.DeepgramTranscriber, global::G.ElevenLabsTranscriber, global::G.GladiaTranscriber, global::G.GoogleTranscriber, global::G.SpeechmaticsTranscriber, global::G.TalkscriberTranscriber, global::G.OpenAITranscriber, global::G.CartesiaTranscriber, global::G.SonioxTranscriber>))]
        public global::G.OneOf<global::G.AssemblyAITranscriber, global::G.AzureSpeechTranscriber, global::G.CustomTranscriber, global::G.DeepgramTranscriber, global::G.ElevenLabsTranscriber, global::G.GladiaTranscriber, global::G.GoogleTranscriber, global::G.SpeechmaticsTranscriber, global::G.TalkscriberTranscriber, global::G.OpenAITranscriber, global::G.CartesiaTranscriber, global::G.SonioxTranscriber>? Transcriber { get; set; }

        /// <summary>
        /// This is the first message that the transfer assistant will say.<br/>
        /// This can also be a URL to a custom audio file.<br/>
        /// If unspecified, assistant will wait for user to speak and use the model to respond once they speak.<br/>
        /// Example: Hello! I understand you need to be transferred. Let me connect you.
        /// </summary>
        /// <example>Hello! I understand you need to be transferred. Let me connect you.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMessage")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// This is the background sound in the transfer assistant call. Default for phone calls is 'office' and default for web calls is 'off'.<br/>
        /// You can also provide a custom sound by providing a URL to an audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundSound")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.TransferAssistantBackgroundSound?, string>))]
        public global::G.OneOf<global::G.TransferAssistantBackgroundSound?, string>? BackgroundSound { get; set; }

        /// <summary>
        /// This is the plan for when the transfer assistant should start talking.<br/>
        /// You should configure this if the transfer assistant needs different endpointing behavior than the base assistant.<br/>
        /// If this is not set, the transfer assistant will inherit the start speaking plan from the base assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startSpeakingPlan")]
        public global::G.StartSpeakingPlan? StartSpeakingPlan { get; set; }

        /// <summary>
        /// This is the mode for the first message. Default is 'assistant-speaks-first'.<br/>
        /// Use:<br/>
        /// - 'assistant-speaks-first' to have the assistant speak first.<br/>
        /// - 'assistant-waits-for-user' to have the assistant wait for the user to speak first.<br/>
        /// - 'assistant-speaks-first-with-model-generated-message' to have the assistant speak first with a message generated by the model based on the conversation state.<br/>
        /// @default 'assistant-speaks-first'<br/>
        /// Example: assistant-speaks-first
        /// </summary>
        /// <example>assistant-speaks-first</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMessageMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferAssistantFirstMessageModeJsonConverter))]
        public global::G.TransferAssistantFirstMessageMode? FirstMessageMode { get; set; }

        /// <summary>
        /// This is the maximum duration in seconds for the transfer assistant conversation.<br/>
        /// After this time, the transfer will be cancelled automatically.<br/>
        /// @default 120<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDurationSeconds")]
        public double? MaxDurationSeconds { get; set; }

        /// <summary>
        /// This enables filtering of noise and background speech while the user is talking.<br/>
        /// Features:<br/>
        /// - Smart denoising using Krisp<br/>
        /// - Fourier denoising<br/>
        /// Smart denoising can be combined with or used independently of Fourier denoising.<br/>
        /// Order of precedence:<br/>
        /// - Smart denoising<br/>
        /// - Fourier denoising
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundSpeechDenoisingPlan")]
        public global::G.BackgroundSpeechDenoisingPlan? BackgroundSpeechDenoisingPlan { get; set; }

        /// <summary>
        /// This is the number of seconds of silence to wait before ending the call. Defaults to 30.<br/>
        /// @default 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silenceTimeoutSeconds")]
        public double? SilenceTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssistant" /> class.
        /// </summary>
        /// <param name="model">
        /// Model configuration for the transfer assistant
        /// </param>
        /// <param name="name">
        /// Optional name for the transfer assistant<br/>
        /// Default Value: transfer-assistant<br/>
        /// Example: Sales Transfer Assistant
        /// </param>
        /// <param name="voice">
        /// These are the options for the transfer assistant's voice.
        /// </param>
        /// <param name="transcriber">
        /// These are the options for the transfer assistant's transcriber.
        /// </param>
        /// <param name="firstMessage">
        /// This is the first message that the transfer assistant will say.<br/>
        /// This can also be a URL to a custom audio file.<br/>
        /// If unspecified, assistant will wait for user to speak and use the model to respond once they speak.<br/>
        /// Example: Hello! I understand you need to be transferred. Let me connect you.
        /// </param>
        /// <param name="backgroundSound">
        /// This is the background sound in the transfer assistant call. Default for phone calls is 'office' and default for web calls is 'off'.<br/>
        /// You can also provide a custom sound by providing a URL to an audio file.
        /// </param>
        /// <param name="startSpeakingPlan">
        /// This is the plan for when the transfer assistant should start talking.<br/>
        /// You should configure this if the transfer assistant needs different endpointing behavior than the base assistant.<br/>
        /// If this is not set, the transfer assistant will inherit the start speaking plan from the base assistant.
        /// </param>
        /// <param name="firstMessageMode">
        /// This is the mode for the first message. Default is 'assistant-speaks-first'.<br/>
        /// Use:<br/>
        /// - 'assistant-speaks-first' to have the assistant speak first.<br/>
        /// - 'assistant-waits-for-user' to have the assistant wait for the user to speak first.<br/>
        /// - 'assistant-speaks-first-with-model-generated-message' to have the assistant speak first with a message generated by the model based on the conversation state.<br/>
        /// @default 'assistant-speaks-first'<br/>
        /// Example: assistant-speaks-first
        /// </param>
        /// <param name="maxDurationSeconds">
        /// This is the maximum duration in seconds for the transfer assistant conversation.<br/>
        /// After this time, the transfer will be cancelled automatically.<br/>
        /// @default 120<br/>
        /// Example: 120
        /// </param>
        /// <param name="backgroundSpeechDenoisingPlan">
        /// This enables filtering of noise and background speech while the user is talking.<br/>
        /// Features:<br/>
        /// - Smart denoising using Krisp<br/>
        /// - Fourier denoising<br/>
        /// Smart denoising can be combined with or used independently of Fourier denoising.<br/>
        /// Order of precedence:<br/>
        /// - Smart denoising<br/>
        /// - Fourier denoising
        /// </param>
        /// <param name="silenceTimeoutSeconds">
        /// This is the number of seconds of silence to wait before ending the call. Defaults to 30.<br/>
        /// @default 30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferAssistant(
            global::G.TransferAssistantModel model,
            string? name,
            global::G.OneOf<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>? voice,
            global::G.OneOf<global::G.AssemblyAITranscriber, global::G.AzureSpeechTranscriber, global::G.CustomTranscriber, global::G.DeepgramTranscriber, global::G.ElevenLabsTranscriber, global::G.GladiaTranscriber, global::G.GoogleTranscriber, global::G.SpeechmaticsTranscriber, global::G.TalkscriberTranscriber, global::G.OpenAITranscriber, global::G.CartesiaTranscriber, global::G.SonioxTranscriber>? transcriber,
            string? firstMessage,
            global::G.OneOf<global::G.TransferAssistantBackgroundSound?, string>? backgroundSound,
            global::G.StartSpeakingPlan? startSpeakingPlan,
            global::G.TransferAssistantFirstMessageMode? firstMessageMode,
            double? maxDurationSeconds,
            global::G.BackgroundSpeechDenoisingPlan? backgroundSpeechDenoisingPlan,
            double? silenceTimeoutSeconds)
        {
            this.Name = name;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Voice = voice;
            this.Transcriber = transcriber;
            this.FirstMessage = firstMessage;
            this.BackgroundSound = backgroundSound;
            this.StartSpeakingPlan = startSpeakingPlan;
            this.FirstMessageMode = firstMessageMode;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.BackgroundSpeechDenoisingPlan = backgroundSpeechDenoisingPlan;
            this.SilenceTimeoutSeconds = silenceTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssistant" /> class.
        /// </summary>
        public TransferAssistant()
        {
        }
    }
}