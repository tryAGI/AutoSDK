//HintName: G.Models.UpdateChatMetadataResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateChatMetadataResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateChatMetadataResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChatMetadataResponseStatus3 value)
        {
            return value switch
            {
                UpdateChatMetadataResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChatMetadataResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateChatMetadataResponseStatus3.Error,
                _ => null,
            };
        }
    }
}