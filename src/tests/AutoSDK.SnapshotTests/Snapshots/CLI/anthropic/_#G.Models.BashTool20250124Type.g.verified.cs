//HintName: G.Models.BashTool20250124Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BashTool20250124Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bash20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashTool20250124TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashTool20250124Type value)
        {
            return value switch
            {
                BashTool20250124Type.Bash20250124 => "bash_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashTool20250124Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_20250124" => BashTool20250124Type.Bash20250124,
                _ => null,
            };
        }
    }
}