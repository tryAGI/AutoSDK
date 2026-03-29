//HintName: G.Models.PostedLanguageModelModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostedLanguageModelModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANTHROPIC")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CUSTOM_LANGUAGE_MODEL")]
        CustomLanguageModel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIREWORKS")]
        Fireworks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GOOGLE")]
        Google,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GROQ")]
        Groq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OPEN_AI")]
        OpenAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostedLanguageModelModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostedLanguageModelModelProvider value)
        {
            return value switch
            {
                PostedLanguageModelModelProvider.Anthropic => "ANTHROPIC",
                PostedLanguageModelModelProvider.CustomLanguageModel => "CUSTOM_LANGUAGE_MODEL",
                PostedLanguageModelModelProvider.Fireworks => "FIREWORKS",
                PostedLanguageModelModelProvider.Google => "GOOGLE",
                PostedLanguageModelModelProvider.Groq => "GROQ",
                PostedLanguageModelModelProvider.OpenAi => "OPEN_AI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostedLanguageModelModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => PostedLanguageModelModelProvider.Anthropic,
                "CUSTOM_LANGUAGE_MODEL" => PostedLanguageModelModelProvider.CustomLanguageModel,
                "FIREWORKS" => PostedLanguageModelModelProvider.Fireworks,
                "GOOGLE" => PostedLanguageModelModelProvider.Google,
                "GROQ" => PostedLanguageModelModelProvider.Groq,
                "OPEN_AI" => PostedLanguageModelModelProvider.OpenAi,
                _ => null,
            };
        }
    }
}