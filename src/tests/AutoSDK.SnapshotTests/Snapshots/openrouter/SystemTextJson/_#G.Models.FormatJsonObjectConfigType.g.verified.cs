//HintName: G.Models.FormatJsonObjectConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormatJsonObjectConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormatJsonObjectConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormatJsonObjectConfigType value)
        {
            return value switch
            {
                FormatJsonObjectConfigType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormatJsonObjectConfigType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => FormatJsonObjectConfigType.JsonObject,
                _ => null,
            };
        }
    }
}