//HintName: G.Models.CloneVoiceResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CloneVoiceResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloneVoiceResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloneVoiceResponseStatus3 value)
        {
            return value switch
            {
                CloneVoiceResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloneVoiceResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CloneVoiceResponseStatus3.Error,
                _ => null,
            };
        }
    }
}