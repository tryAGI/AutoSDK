//HintName: G.Models.BetaBashTool20250124Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in tool_use blocks.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaBashTool20250124Name
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash")]
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBashTool20250124NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBashTool20250124Name value)
        {
            return value switch
            {
                BetaBashTool20250124Name.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBashTool20250124Name? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BetaBashTool20250124Name.Bash,
                _ => null,
            };
        }
    }
}