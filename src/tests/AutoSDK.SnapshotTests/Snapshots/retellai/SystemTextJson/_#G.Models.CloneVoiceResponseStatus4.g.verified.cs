//HintName: G.Models.CloneVoiceResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CloneVoiceResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloneVoiceResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloneVoiceResponseStatus4 value)
        {
            return value switch
            {
                CloneVoiceResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloneVoiceResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => CloneVoiceResponseStatus4.Error,
                _ => null,
            };
        }
    }
}