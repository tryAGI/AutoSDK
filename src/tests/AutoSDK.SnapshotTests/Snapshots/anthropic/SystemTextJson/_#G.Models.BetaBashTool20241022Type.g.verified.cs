//HintName: G.Models.BetaBashTool20241022Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBashTool20241022Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bash20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBashTool20241022TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBashTool20241022Type value)
        {
            return value switch
            {
                BetaBashTool20241022Type.Bash20241022 => "bash_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBashTool20241022Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_20241022" => BetaBashTool20241022Type.Bash20241022,
                _ => null,
            };
        }
    }
}