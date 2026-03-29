//HintName: G.Models.JSONQueryOnEventsTableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of query. Only allowed type is "vapiql-json".<br/>
    /// Example: vapiql-json
    /// </summary>
    public enum JSONQueryOnEventsTableType
    {
        /// <summary>
        /// 
        /// </summary>
        VapiqlJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnEventsTableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnEventsTableType value)
        {
            return value switch
            {
                JSONQueryOnEventsTableType.VapiqlJson => "vapiql-json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnEventsTableType? ToEnum(string value)
        {
            return value switch
            {
                "vapiql-json" => JSONQueryOnEventsTableType.VapiqlJson,
                _ => null,
            };
        }
    }
}