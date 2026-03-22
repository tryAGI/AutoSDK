//HintName: G.Models.SchemaVariantKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SchemaVariantKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai-sdk")]
        AiSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create-voice")]
        CreateVoice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete-voice")]
        DeleteVoice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs-tts")]
        ElevenlabsTts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list-voices")]
        ListVoices,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-chat-completions")]
        OpenaiChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-completions")]
        OpenaiCompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-embeddings")]
        OpenaiEmbeddings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-images")]
        OpenaiImages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-images-variations")]
        OpenaiImagesVariations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-speech-to-text")]
        OpenaiSpeechToText,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-tts")]
        OpenaiTts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read-voice")]
        ReadVoice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update-voice")]
        UpdateVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemaVariantKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaVariantKey value)
        {
            return value switch
            {
                SchemaVariantKey.AiSdk => "ai-sdk",
                SchemaVariantKey.CreateVoice => "create-voice",
                SchemaVariantKey.Default => "default",
                SchemaVariantKey.DeleteVoice => "delete-voice",
                SchemaVariantKey.ElevenlabsTts => "elevenlabs-tts",
                SchemaVariantKey.ListVoices => "list-voices",
                SchemaVariantKey.OpenaiChatCompletions => "openai-chat-completions",
                SchemaVariantKey.OpenaiCompletions => "openai-completions",
                SchemaVariantKey.OpenaiEmbeddings => "openai-embeddings",
                SchemaVariantKey.OpenaiImages => "openai-images",
                SchemaVariantKey.OpenaiImagesVariations => "openai-images-variations",
                SchemaVariantKey.OpenaiSpeechToText => "openai-speech-to-text",
                SchemaVariantKey.OpenaiTts => "openai-tts",
                SchemaVariantKey.ReadVoice => "read-voice",
                SchemaVariantKey.UpdateVoice => "update-voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaVariantKey? ToEnum(string value)
        {
            return value switch
            {
                "ai-sdk" => SchemaVariantKey.AiSdk,
                "create-voice" => SchemaVariantKey.CreateVoice,
                "default" => SchemaVariantKey.Default,
                "delete-voice" => SchemaVariantKey.DeleteVoice,
                "elevenlabs-tts" => SchemaVariantKey.ElevenlabsTts,
                "list-voices" => SchemaVariantKey.ListVoices,
                "openai-chat-completions" => SchemaVariantKey.OpenaiChatCompletions,
                "openai-completions" => SchemaVariantKey.OpenaiCompletions,
                "openai-embeddings" => SchemaVariantKey.OpenaiEmbeddings,
                "openai-images" => SchemaVariantKey.OpenaiImages,
                "openai-images-variations" => SchemaVariantKey.OpenaiImagesVariations,
                "openai-speech-to-text" => SchemaVariantKey.OpenaiSpeechToText,
                "openai-tts" => SchemaVariantKey.OpenaiTts,
                "read-voice" => SchemaVariantKey.ReadVoice,
                "update-voice" => SchemaVariantKey.UpdateVoice,
                _ => null,
            };
        }
    }
}