//HintName: G.Models.UpdateCallMetadataResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCallMetadataResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCallMetadataResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCallMetadataResponseStatus3 value)
        {
            return value switch
            {
                UpdateCallMetadataResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCallMetadataResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateCallMetadataResponseStatus3.Error,
                _ => null,
            };
        }
    }
}