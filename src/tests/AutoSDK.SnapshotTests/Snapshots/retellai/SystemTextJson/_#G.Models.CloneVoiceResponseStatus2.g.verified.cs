//HintName: G.Models.CloneVoiceResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CloneVoiceResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloneVoiceResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloneVoiceResponseStatus2 value)
        {
            return value switch
            {
                CloneVoiceResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloneVoiceResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CloneVoiceResponseStatus2.Error,
                _ => null,
            };
        }
    }
}