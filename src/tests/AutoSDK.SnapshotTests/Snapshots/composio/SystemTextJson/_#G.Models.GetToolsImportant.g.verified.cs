//HintName: G.Models.GetToolsImportant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetToolsImportant
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolsImportantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolsImportant value)
        {
            return value switch
            {
                GetToolsImportant.False => "false",
                GetToolsImportant.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolsImportant? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetToolsImportant.False,
                "true" => GetToolsImportant.True,
                _ => null,
            };
        }
    }
}