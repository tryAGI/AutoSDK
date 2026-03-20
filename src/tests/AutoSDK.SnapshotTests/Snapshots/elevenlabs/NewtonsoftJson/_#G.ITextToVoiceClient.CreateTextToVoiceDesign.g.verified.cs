//HintName: G.ITextToVoiceClient.CreateTextToVoiceDesign.g.cs
#nullable enable

namespace G
{
    public partial interface ITextToVoiceClient
    {
        /// <summary>
        /// Design A Voice.<br/>
        /// Design a voice via a prompt. This method returns a list of voice previews. Each preview has a generated_voice_id and a sample of the voice as base64 encoded mp3 audio. To create a voice use the generated_voice_id of the preferred preview with the /v1/text-to-voice endpoint.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_192
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoicePreviewsResponseModel> CreateTextToVoiceDesignAsync(

            global::G.VoiceDesignRequestModel request,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Design A Voice.<br/>
        /// Design a voice via a prompt. This method returns a list of voice previews. Each preview has a generated_voice_id and a sample of the voice as base64 encoded mp3 audio. To create a voice use the generated_voice_id of the preferred preview with the /v1/text-to-voice endpoint.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_192
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.
        /// </param>
        /// <param name="modelId">
        /// Model to use for the voice generation. Possible values: eleven_multilingual_ttv_v2, eleven_ttv_v3.<br/>
        /// Default Value: eleven_multilingual_ttv_v2
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.
        /// </param>
        /// <param name="autoGenerateText">
        /// Whether to automatically generate a text suitable for the voice description.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="loudness">
        /// Controls the volume level of the generated voice. -1 is quietest, 1 is loudest, 0 corresponds to roughly -24 LUFS.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="seed">
        /// Random number that controls the voice generation. Same seed with same inputs produces same voice.
        /// </param>
        /// <param name="guidanceScale">
        /// Controls how closely the AI follows the prompt. Lower numbers give the AI more freedom to be creative, while higher numbers force it to stick more to the prompt. High numbers can cause voice to sound artificial or robotic. We recommend to use longer, more detailed prompts at lower Guidance Scale.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="streamPreviews">
        /// Determines whether the Text to Voice previews should be included in the response. If true, only the generated IDs will be returned which can then be streamed via the /v1/text-to-voice/:generated_voice_id/stream endpoint.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="shouldEnhance">
        /// Whether to enhance the voice description using AI to add more detail and improve voice generation quality. When enabled, the system will automatically expand simple prompts into more detailed voice descriptions. Defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="remixingSessionId">
        /// The remixing session id.
        /// </param>
        /// <param name="remixingSessionIterationId">
        /// The id of the remixing session iteration where these generations should be attached to. If not provided, a new iteration will be created.
        /// </param>
        /// <param name="quality">
        /// Higher quality results in better voice output but less variety.
        /// </param>
        /// <param name="referenceAudioBase64">
        /// Reference audio to use for the voice generation. The audio should be base64 encoded. Only supported when using the  eleven_ttv_v3 model.
        /// </param>
        /// <param name="promptStrength">
        /// Controls the balance of prompt versus reference audio when generating voice samples. 0 means almost no prompt influence, 1 means almost no reference audio influence. Only supported when using the eleven_ttv_v3 model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoicePreviewsResponseModel> CreateTextToVoiceDesignAsync(
            string voiceDescription,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            global::G.VoiceDesignRequestModelModelId? modelId = default,
            string? text = default,
            bool? autoGenerateText = default,
            double? loudness = default,
            int? seed = default,
            double? guidanceScale = default,
            bool? streamPreviews = default,
            bool? shouldEnhance = default,
            string? remixingSessionId = default,
            string? remixingSessionIterationId = default,
            double? quality = default,
            string? referenceAudioBase64 = default,
            double? promptStrength = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}