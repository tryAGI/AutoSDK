//HintName: G.Models.ResponseConfigVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model uses to respond.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseConfigVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alloy")]
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="echo")]
        Echo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shimmer")]
        Shimmer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseConfigVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseConfigVoice value)
        {
            return value switch
            {
                ResponseConfigVoice.Alloy => "alloy",
                ResponseConfigVoice.Echo => "echo",
                ResponseConfigVoice.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseConfigVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => ResponseConfigVoice.Alloy,
                "echo" => ResponseConfigVoice.Echo,
                "shimmer" => ResponseConfigVoice.Shimmer,
                _ => null,
            };
        }
    }
}