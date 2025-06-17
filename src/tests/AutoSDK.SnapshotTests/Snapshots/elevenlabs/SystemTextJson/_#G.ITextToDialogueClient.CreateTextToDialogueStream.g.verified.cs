//HintName: G.ITextToDialogueClient.CreateTextToDialogueStream.g.cs
#nullable enable

namespace G
{
    public partial interface ITextToDialogueClient
    {
        /// <summary>
        /// Text To Dialogue (Multi-Voice) Streaming<br/>
        /// Converts a list of text and voice ID pairs into speech (dialogue) and returns an audio stream.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateTextToDialogueStreamAsync(
            global::G.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPost request,
            global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormat? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Text To Dialogue (Multi-Voice) Streaming<br/>
        /// Converts a list of text and voice ID pairs into speech (dialogue) and returns an audio stream.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="inputs">
        /// A list of dialogue inputs, each containing text and a voice ID which will be converted into speech.<br/>
        /// Example: [, ]
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_v3
        /// </param>
        /// <param name="settings"></param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request<br/>
        /// Example: []
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateTextToDialogueStreamAsync(
            global::System.Collections.Generic.IList<global::G.DialogueInput> inputs,
            global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormat? outputFormat = default,
            string? xiApiKey = default,
            string? modelId = default,
            global::G.ModelSettingsResponseModel? settings = default,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>? pronunciationDictionaryLocators = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}