//HintName: G.Models.UpdateCallMetadataResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCallMetadataResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCallMetadataResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCallMetadataResponseStatus2 value)
        {
            return value switch
            {
                UpdateCallMetadataResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCallMetadataResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateCallMetadataResponseStatus2.Error,
                _ => null,
            };
        }
    }
}