//HintName: G.Models.FallbackOpenAIVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackOpenAIVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alloy")]
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cedar")]
        Cedar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="echo")]
        Echo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fable")]
        Fable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marin")]
        Marin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova")]
        Nova,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="onyx")]
        Onyx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shimmer")]
        Shimmer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackOpenAIVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackOpenAIVoiceVoiceId value)
        {
            return value switch
            {
                FallbackOpenAIVoiceVoiceId.Alloy => "alloy",
                FallbackOpenAIVoiceVoiceId.Cedar => "cedar",
                FallbackOpenAIVoiceVoiceId.Echo => "echo",
                FallbackOpenAIVoiceVoiceId.Fable => "fable",
                FallbackOpenAIVoiceVoiceId.Marin => "marin",
                FallbackOpenAIVoiceVoiceId.Nova => "nova",
                FallbackOpenAIVoiceVoiceId.Onyx => "onyx",
                FallbackOpenAIVoiceVoiceId.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackOpenAIVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => FallbackOpenAIVoiceVoiceId.Alloy,
                "cedar" => FallbackOpenAIVoiceVoiceId.Cedar,
                "echo" => FallbackOpenAIVoiceVoiceId.Echo,
                "fable" => FallbackOpenAIVoiceVoiceId.Fable,
                "marin" => FallbackOpenAIVoiceVoiceId.Marin,
                "nova" => FallbackOpenAIVoiceVoiceId.Nova,
                "onyx" => FallbackOpenAIVoiceVoiceId.Onyx,
                "shimmer" => FallbackOpenAIVoiceVoiceId.Shimmer,
                _ => null,
            };
        }
    }
}