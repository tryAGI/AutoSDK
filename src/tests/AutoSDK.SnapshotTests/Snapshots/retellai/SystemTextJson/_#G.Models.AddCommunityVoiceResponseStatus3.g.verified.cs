//HintName: G.Models.AddCommunityVoiceResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddCommunityVoiceResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddCommunityVoiceResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddCommunityVoiceResponseStatus3 value)
        {
            return value switch
            {
                AddCommunityVoiceResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddCommunityVoiceResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => AddCommunityVoiceResponseStatus3.Error,
                _ => null,
            };
        }
    }
}