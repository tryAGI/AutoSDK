//HintName: G.Models.OpenAIVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAIVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        Cedar,
        /// <summary>
        /// 
        /// </summary>
        Echo,
        /// <summary>
        /// 
        /// </summary>
        Fable,
        /// <summary>
        /// 
        /// </summary>
        Marin,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Onyx,
        /// <summary>
        /// 
        /// </summary>
        Shimmer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIVoiceVoiceId value)
        {
            return value switch
            {
                OpenAIVoiceVoiceId.Alloy => "alloy",
                OpenAIVoiceVoiceId.Cedar => "cedar",
                OpenAIVoiceVoiceId.Echo => "echo",
                OpenAIVoiceVoiceId.Fable => "fable",
                OpenAIVoiceVoiceId.Marin => "marin",
                OpenAIVoiceVoiceId.Nova => "nova",
                OpenAIVoiceVoiceId.Onyx => "onyx",
                OpenAIVoiceVoiceId.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => OpenAIVoiceVoiceId.Alloy,
                "cedar" => OpenAIVoiceVoiceId.Cedar,
                "echo" => OpenAIVoiceVoiceId.Echo,
                "fable" => OpenAIVoiceVoiceId.Fable,
                "marin" => OpenAIVoiceVoiceId.Marin,
                "nova" => OpenAIVoiceVoiceId.Nova,
                "onyx" => OpenAIVoiceVoiceId.Onyx,
                "shimmer" => OpenAIVoiceVoiceId.Shimmer,
                _ => null,
            };
        }
    }
}