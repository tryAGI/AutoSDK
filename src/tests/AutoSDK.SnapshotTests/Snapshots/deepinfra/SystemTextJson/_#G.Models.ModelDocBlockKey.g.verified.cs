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
        Http,
        /// <summary>
        /// 
        /// </summary>
        HttpBgeM3Multimodal,
        /// <summary>
        /// 
        /// </summary>
        Deepctl,
        /// <summary>
        /// 
        /// </summary>
        JsTextGen,
        /// <summary>
        /// 
        /// </summary>
        JsEmb,
        /// <summary>
        /// 
        /// </summary>
        JsTextToImg,
        /// <summary>
        /// 
        /// </summary>
        JsSpeechToText,
        /// <summary>
        /// 
        /// </summary>
        OpenaiPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiSpeechHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiSpeechPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiSpeechJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesVariationsHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesVariationsPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiImagesVariationsJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompPython,
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
        OpenaiEmbPy,
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
        OpenaiTtsHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiTtsPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiTtsJs,
        /// <summary>
        /// 
        /// </summary>
        ElevenlabsTtsHttp,
        /// <summary>
        /// 
        /// </summary>
        ElevenlabsTtsPython,
        /// <summary>
        /// 
        /// </summary>
        ElevenlabsTtsJs,
        /// <summary>
        /// 
        /// </summary>
        CreateVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        CreateVoicePython,
        /// <summary>
        /// 
        /// </summary>
        CreateVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        ReadVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        ReadVoicePython,
        /// <summary>
        /// 
        /// </summary>
        ReadVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoicePython,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoicePython,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesHttp,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesPython,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesJs,
        /// <summary>
        /// 
        /// </summary>
        AiSdkJs,
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
                ModelDocBlockKey.Http => "http",
                ModelDocBlockKey.HttpBgeM3Multimodal => "http-bge-m3-multimodal",
                ModelDocBlockKey.Deepctl => "deepctl",
                ModelDocBlockKey.JsTextGen => "js-text-gen",
                ModelDocBlockKey.JsEmb => "js-emb",
                ModelDocBlockKey.JsTextToImg => "js-text-to-img",
                ModelDocBlockKey.JsSpeechToText => "js-speech-to-text",
                ModelDocBlockKey.OpenaiPython => "openai-python",
                ModelDocBlockKey.OpenaiHttp => "openai-http",
                ModelDocBlockKey.OpenaiJs => "openai-js",
                ModelDocBlockKey.OpenaiSpeechHttp => "openai-speech-http",
                ModelDocBlockKey.OpenaiSpeechPython => "openai-speech-python",
                ModelDocBlockKey.OpenaiSpeechJs => "openai-speech-js",
                ModelDocBlockKey.OpenaiImagesHttp => "openai-images-http",
                ModelDocBlockKey.OpenaiImagesPython => "openai-images-python",
                ModelDocBlockKey.OpenaiImagesJs => "openai-images-js",
                ModelDocBlockKey.OpenaiImagesVariationsHttp => "openai-images-variations-http",
                ModelDocBlockKey.OpenaiImagesVariationsPython => "openai-images-variations-python",
                ModelDocBlockKey.OpenaiImagesVariationsJs => "openai-images-variations-js",
                ModelDocBlockKey.OpenaiCompPython => "openai-comp-python",
                ModelDocBlockKey.OpenaiCompHttp => "openai-comp-http",
                ModelDocBlockKey.OpenaiCompJs => "openai-comp-js",
                ModelDocBlockKey.OpenaiEmbPy => "openai-emb-py",
                ModelDocBlockKey.OpenaiEmbHttp => "openai-emb-http",
                ModelDocBlockKey.OpenaiEmbJs => "openai-emb-js",
                ModelDocBlockKey.OpenaiTtsHttp => "openai-tts-http",
                ModelDocBlockKey.OpenaiTtsPython => "openai-tts-python",
                ModelDocBlockKey.OpenaiTtsJs => "openai-tts-js",
                ModelDocBlockKey.ElevenlabsTtsHttp => "elevenlabs-tts-http",
                ModelDocBlockKey.ElevenlabsTtsPython => "elevenlabs-tts-python",
                ModelDocBlockKey.ElevenlabsTtsJs => "elevenlabs-tts-js",
                ModelDocBlockKey.CreateVoiceHttp => "create-voice-http",
                ModelDocBlockKey.CreateVoicePython => "create-voice-python",
                ModelDocBlockKey.CreateVoiceJs => "create-voice-js",
                ModelDocBlockKey.ReadVoiceHttp => "read-voice-http",
                ModelDocBlockKey.ReadVoicePython => "read-voice-python",
                ModelDocBlockKey.ReadVoiceJs => "read-voice-js",
                ModelDocBlockKey.UpdateVoiceHttp => "update-voice-http",
                ModelDocBlockKey.UpdateVoicePython => "update-voice-python",
                ModelDocBlockKey.UpdateVoiceJs => "update-voice-js",
                ModelDocBlockKey.DeleteVoiceHttp => "delete-voice-http",
                ModelDocBlockKey.DeleteVoicePython => "delete-voice-python",
                ModelDocBlockKey.DeleteVoiceJs => "delete-voice-js",
                ModelDocBlockKey.ListVoicesHttp => "list-voices-http",
                ModelDocBlockKey.ListVoicesPython => "list-voices-python",
                ModelDocBlockKey.ListVoicesJs => "list-voices-js",
                ModelDocBlockKey.AiSdkJs => "ai-sdk-js",
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
                "http" => ModelDocBlockKey.Http,
                "http-bge-m3-multimodal" => ModelDocBlockKey.HttpBgeM3Multimodal,
                "deepctl" => ModelDocBlockKey.Deepctl,
                "js-text-gen" => ModelDocBlockKey.JsTextGen,
                "js-emb" => ModelDocBlockKey.JsEmb,
                "js-text-to-img" => ModelDocBlockKey.JsTextToImg,
                "js-speech-to-text" => ModelDocBlockKey.JsSpeechToText,
                "openai-python" => ModelDocBlockKey.OpenaiPython,
                "openai-http" => ModelDocBlockKey.OpenaiHttp,
                "openai-js" => ModelDocBlockKey.OpenaiJs,
                "openai-speech-http" => ModelDocBlockKey.OpenaiSpeechHttp,
                "openai-speech-python" => ModelDocBlockKey.OpenaiSpeechPython,
                "openai-speech-js" => ModelDocBlockKey.OpenaiSpeechJs,
                "openai-images-http" => ModelDocBlockKey.OpenaiImagesHttp,
                "openai-images-python" => ModelDocBlockKey.OpenaiImagesPython,
                "openai-images-js" => ModelDocBlockKey.OpenaiImagesJs,
                "openai-images-variations-http" => ModelDocBlockKey.OpenaiImagesVariationsHttp,
                "openai-images-variations-python" => ModelDocBlockKey.OpenaiImagesVariationsPython,
                "openai-images-variations-js" => ModelDocBlockKey.OpenaiImagesVariationsJs,
                "openai-comp-python" => ModelDocBlockKey.OpenaiCompPython,
                "openai-comp-http" => ModelDocBlockKey.OpenaiCompHttp,
                "openai-comp-js" => ModelDocBlockKey.OpenaiCompJs,
                "openai-emb-py" => ModelDocBlockKey.OpenaiEmbPy,
                "openai-emb-http" => ModelDocBlockKey.OpenaiEmbHttp,
                "openai-emb-js" => ModelDocBlockKey.OpenaiEmbJs,
                "openai-tts-http" => ModelDocBlockKey.OpenaiTtsHttp,
                "openai-tts-python" => ModelDocBlockKey.OpenaiTtsPython,
                "openai-tts-js" => ModelDocBlockKey.OpenaiTtsJs,
                "elevenlabs-tts-http" => ModelDocBlockKey.ElevenlabsTtsHttp,
                "elevenlabs-tts-python" => ModelDocBlockKey.ElevenlabsTtsPython,
                "elevenlabs-tts-js" => ModelDocBlockKey.ElevenlabsTtsJs,
                "create-voice-http" => ModelDocBlockKey.CreateVoiceHttp,
                "create-voice-python" => ModelDocBlockKey.CreateVoicePython,
                "create-voice-js" => ModelDocBlockKey.CreateVoiceJs,
                "read-voice-http" => ModelDocBlockKey.ReadVoiceHttp,
                "read-voice-python" => ModelDocBlockKey.ReadVoicePython,
                "read-voice-js" => ModelDocBlockKey.ReadVoiceJs,
                "update-voice-http" => ModelDocBlockKey.UpdateVoiceHttp,
                "update-voice-python" => ModelDocBlockKey.UpdateVoicePython,
                "update-voice-js" => ModelDocBlockKey.UpdateVoiceJs,
                "delete-voice-http" => ModelDocBlockKey.DeleteVoiceHttp,
                "delete-voice-python" => ModelDocBlockKey.DeleteVoicePython,
                "delete-voice-js" => ModelDocBlockKey.DeleteVoiceJs,
                "list-voices-http" => ModelDocBlockKey.ListVoicesHttp,
                "list-voices-python" => ModelDocBlockKey.ListVoicesPython,
                "list-voices-js" => ModelDocBlockKey.ListVoicesJs,
                "ai-sdk-js" => ModelDocBlockKey.AiSdkJs,
                _ => null,
            };
        }
    }
}