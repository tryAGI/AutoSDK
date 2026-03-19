//HintName: G.Models.SessionVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model uses to respond.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionVoice
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
    public static class SessionVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionVoice value)
        {
            return value switch
            {
                SessionVoice.Alloy => "alloy",
                SessionVoice.Echo => "echo",
                SessionVoice.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => SessionVoice.Alloy,
                "echo" => SessionVoice.Echo,
                "shimmer" => SessionVoice.Shimmer,
                _ => null,
            };
        }
    }
}