//HintName: G.Models.BashTool20250124Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in tool_use blocks.
    /// </summary>
    public enum BashTool20250124Name
    {
        /// <summary>
        /// 
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashTool20250124NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashTool20250124Name value)
        {
            return value switch
            {
                BashTool20250124Name.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashTool20250124Name? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BashTool20250124Name.Bash,
                _ => null,
            };
        }
    }
}