//HintName: G.Models.UpdateChatMetadataResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateChatMetadataResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateChatMetadataResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChatMetadataResponseStatus value)
        {
            return value switch
            {
                UpdateChatMetadataResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChatMetadataResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateChatMetadataResponseStatus.Error,
                _ => null,
            };
        }
    }
}