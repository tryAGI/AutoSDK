//HintName: G.Models.ModelDocBlockKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelDocBlockKey
    {
        /// <summary>
        /// 
        /// </summary>
        AiSdkJs,
        /// <summary>
        /// 
        /// </summary>
        CreateVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        CreateVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        CreateVoicePython,
        /// <summary>
        /// 
        /// </summary>
        Deepctl,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoicePython,
        /// <summary>
        /// 
        /// </summary>
        ElevenlabsTtsHttp,
        /// <summary>
        /// 
        /// </summary>
        ElevenlabsTtsJs,
        /// <summary>
        /// 
        /// </summary>
        ElevenlabsTtsPython,
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        HttpBgeM3Multimodal,
        /// <summary>
        /// 
        /// </summary>
        JsEmb,
        /// <summary>
        /// 
        /// </summary>
        JsSpeechToText,
        /// <summary>
        /// 
        /// </summary>
        JsTextGen,
        /// <summary>
        /// 
        /// </summary>
        JsTextToImg,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesHttp,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesJs,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiEmbHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiEmbJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiEmbPy,
        /// <summary>
        /// 
        /// </summary>
        OpenaiHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesVariationsHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesVariationsJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesVariationsPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiSpeechHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiSpeechJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiSpeechPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiTtsHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiTtsJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiTtsPython,
        /// <summary>
        /// 
        /// </summary>
        ReadVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        ReadVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        ReadVoicePython,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoicePython,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelDocBlockKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelDocBlockKey value)
        {
            return value switch
            {
                ModelDocBlockKey.AiSdkJs => "ai-sdk-js",
                ModelDocBlockKey.CreateVoiceHttp => "create-voice-http",
                ModelDocBlockKey.CreateVoiceJs => "create-voice-js",
                ModelDocBlockKey.CreateVoicePython => "create-voice-python",
                ModelDocBlockKey.Deepctl => "deepctl",
                ModelDocBlockKey.DeleteVoiceHttp => "delete-voice-http",
                ModelDocBlockKey.DeleteVoiceJs => "delete-voice-js",
                ModelDocBlockKey.DeleteVoicePython => "delete-voice-python",
                ModelDocBlockKey.ElevenlabsTtsHttp => "elevenlabs-tts-http",
                ModelDocBlockKey.ElevenlabsTtsJs => "elevenlabs-tts-js",
                ModelDocBlockKey.ElevenlabsTtsPython => "elevenlabs-tts-python",
                ModelDocBlockKey.Http => "http",
                ModelDocBlockKey.HttpBgeM3Multimodal => "http-bge-m3-multimodal",
                ModelDocBlockKey.JsEmb => "js-emb",
                ModelDocBlockKey.JsSpeechToText => "js-speech-to-text",
                ModelDocBlockKey.JsTextGen => "js-text-gen",
                ModelDocBlockKey.JsTextToImg => "js-text-to-img",
                ModelDocBlockKey.ListVoicesHttp => "list-voices-http",
                ModelDocBlockKey.ListVoicesJs => "list-voices-js",
                ModelDocBlockKey.ListVoicesPython => "list-voices-python",
                ModelDocBlockKey.OpenaiCompHttp => "openai-comp-http",
                ModelDocBlockKey.OpenaiCompJs => "openai-comp-js",
                ModelDocBlockKey.OpenaiCompPython => "openai-comp-python",
                ModelDocBlockKey.OpenaiEmbHttp => "openai-emb-http",
                ModelDocBlockKey.OpenaiEmbJs => "openai-emb-js",
                ModelDocBlockKey.OpenaiEmbPy => "openai-emb-py",
                ModelDocBlockKey.OpenaiHttp => "openai-http",
                ModelDocBlockKey.OpenaiImagesHttp => "openai-images-http",
                ModelDocBlockKey.OpenaiImagesJs => "openai-images-js",
                ModelDocBlockKey.OpenaiImagesPython => "openai-images-python",
                ModelDocBlockKey.OpenaiImagesVariationsHttp => "openai-images-variations-http",
                ModelDocBlockKey.OpenaiImagesVariationsJs => "openai-images-variations-js",
                ModelDocBlockKey.OpenaiImagesVariationsPython => "openai-images-variations-python",
                ModelDocBlockKey.OpenaiJs => "openai-js",
                ModelDocBlockKey.OpenaiPython => "openai-python",
                ModelDocBlockKey.OpenaiSpeechHttp => "openai-speech-http",
                ModelDocBlockKey.OpenaiSpeechJs => "openai-speech-js",
                ModelDocBlockKey.OpenaiSpeechPython => "openai-speech-python",
                ModelDocBlockKey.OpenaiTtsHttp => "openai-tts-http",
                ModelDocBlockKey.OpenaiTtsJs => "openai-tts-js",
                ModelDocBlockKey.OpenaiTtsPython => "openai-tts-python",
                ModelDocBlockKey.ReadVoiceHttp => "read-voice-http",
                ModelDocBlockKey.ReadVoiceJs => "read-voice-js",
                ModelDocBlockKey.ReadVoicePython => "read-voice-python",
                ModelDocBlockKey.UpdateVoiceHttp => "update-voice-http",
                ModelDocBlockKey.UpdateVoiceJs => "update-voice-js",
                ModelDocBlockKey.UpdateVoicePython => "update-voice-python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelDocBlockKey? ToEnum(string value)
        {
            return value switch
            {
                "ai-sdk-js" => ModelDocBlockKey.AiSdkJs,
                "create-voice-http" => ModelDocBlockKey.CreateVoiceHttp,
                "create-voice-js" => ModelDocBlockKey.CreateVoiceJs,
                "create-voice-python" => ModelDocBlockKey.CreateVoicePython,
                "deepctl" => ModelDocBlockKey.Deepctl,
                "delete-voice-http" => ModelDocBlockKey.DeleteVoiceHttp,
                "delete-voice-js" => ModelDocBlockKey.DeleteVoiceJs,
                "delete-voice-python" => ModelDocBlockKey.DeleteVoicePython,
                "elevenlabs-tts-http" => ModelDocBlockKey.ElevenlabsTtsHttp,
                "elevenlabs-tts-js" => ModelDocBlockKey.ElevenlabsTtsJs,
                "elevenlabs-tts-python" => ModelDocBlockKey.ElevenlabsTtsPython,
                "http" => ModelDocBlockKey.Http,
                "http-bge-m3-multimodal" => ModelDocBlockKey.HttpBgeM3Multimodal,
                "js-emb" => ModelDocBlockKey.JsEmb,
                "js-speech-to-text" => ModelDocBlockKey.JsSpeechToText,
                "js-text-gen" => ModelDocBlockKey.JsTextGen,
                "js-text-to-img" => ModelDocBlockKey.JsTextToImg,
                "list-voices-http" => ModelDocBlockKey.ListVoicesHttp,
                "list-voices-js" => ModelDocBlockKey.ListVoicesJs,
                "list-voices-python" => ModelDocBlockKey.ListVoicesPython,
                "openai-comp-http" => ModelDocBlockKey.OpenaiCompHttp,
                "openai-comp-js" => ModelDocBlockKey.OpenaiCompJs,
                "openai-comp-python" => ModelDocBlockKey.OpenaiCompPython,
                "openai-emb-http" => ModelDocBlockKey.OpenaiEmbHttp,
                "openai-emb-js" => ModelDocBlockKey.OpenaiEmbJs,
                "openai-emb-py" => ModelDocBlockKey.OpenaiEmbPy,
                "openai-http" => ModelDocBlockKey.OpenaiHttp,
                "openai-images-http" => ModelDocBlockKey.OpenaiImagesHttp,
                "openai-images-js" => ModelDocBlockKey.OpenaiImagesJs,
                "openai-images-python" => ModelDocBlockKey.OpenaiImagesPython,
                "openai-images-variations-http" => ModelDocBlockKey.OpenaiImagesVariationsHttp,
                "openai-images-variations-js" => ModelDocBlockKey.OpenaiImagesVariationsJs,
                "openai-images-variations-python" => ModelDocBlockKey.OpenaiImagesVariationsPython,
                "openai-js" => ModelDocBlockKey.OpenaiJs,
                "openai-python" => ModelDocBlockKey.OpenaiPython,
                "openai-speech-http" => ModelDocBlockKey.OpenaiSpeechHttp,
                "openai-speech-js" => ModelDocBlockKey.OpenaiSpeechJs,
                "openai-speech-python" => ModelDocBlockKey.OpenaiSpeechPython,
                "openai-tts-http" => ModelDocBlockKey.OpenaiTtsHttp,
                "openai-tts-js" => ModelDocBlockKey.OpenaiTtsJs,
                "openai-tts-python" => ModelDocBlockKey.OpenaiTtsPython,
                "read-voice-http" => ModelDocBlockKey.ReadVoiceHttp,
                "read-voice-js" => ModelDocBlockKey.ReadVoiceJs,
                "read-voice-python" => ModelDocBlockKey.ReadVoicePython,
                "update-voice-http" => ModelDocBlockKey.UpdateVoiceHttp,
                "update-voice-js" => ModelDocBlockKey.UpdateVoiceJs,
                "update-voice-python" => ModelDocBlockKey.UpdateVoicePython,
                _ => null,
            };
        }
    }
}