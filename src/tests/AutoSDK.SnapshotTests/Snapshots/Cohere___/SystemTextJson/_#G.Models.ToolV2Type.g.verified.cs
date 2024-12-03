//HintName: G.Models.ToolV2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolV2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolV2Type value)
        {
            return value switch
            {
                ToolV2Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolV2Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolV2Type.Function,
                _ => null,
            };
        }
    }
}