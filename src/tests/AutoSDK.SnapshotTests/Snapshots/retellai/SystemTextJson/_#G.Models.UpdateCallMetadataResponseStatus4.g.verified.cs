//HintName: G.Models.UpdateCallMetadataResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCallMetadataResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCallMetadataResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCallMetadataResponseStatus4 value)
        {
            return value switch
            {
                UpdateCallMetadataResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCallMetadataResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateCallMetadataResponseStatus4.Error,
                _ => null,
            };
        }
    }
}