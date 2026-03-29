//HintName: G.Models.UpdateChatMetadataResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateChatMetadataResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateChatMetadataResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChatMetadataResponseStatus2 value)
        {
            return value switch
            {
                UpdateChatMetadataResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChatMetadataResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateChatMetadataResponseStatus2.Error,
                _ => null,
            };
        }
    }
}