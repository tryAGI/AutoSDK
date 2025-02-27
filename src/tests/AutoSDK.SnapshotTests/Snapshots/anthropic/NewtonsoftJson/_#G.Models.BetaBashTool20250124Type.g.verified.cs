//HintName: G.Models.BetaBashTool20250124Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaBashTool20250124Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash_20250124")]
        Bash20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBashTool20250124TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBashTool20250124Type value)
        {
            return value switch
            {
                BetaBashTool20250124Type.Bash20250124 => "bash_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBashTool20250124Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_20250124" => BetaBashTool20250124Type.Bash20250124,
                _ => null,
            };
        }
    }
}