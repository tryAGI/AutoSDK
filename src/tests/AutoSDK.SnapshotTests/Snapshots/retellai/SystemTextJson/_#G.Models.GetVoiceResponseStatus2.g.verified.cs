//HintName: G.Models.GetVoiceResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVoiceResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVoiceResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoiceResponseStatus2 value)
        {
            return value switch
            {
                GetVoiceResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoiceResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetVoiceResponseStatus2.Error,
                _ => null,
            };
        }
    }
}