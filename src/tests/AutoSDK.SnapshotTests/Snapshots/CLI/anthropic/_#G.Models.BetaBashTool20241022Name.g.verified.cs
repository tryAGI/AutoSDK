﻿//HintName: G.Models.BetaBashTool20241022Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in tool_use blocks.
    /// </summary>
    public enum BetaBashTool20241022Name
    {
        /// <summary>
        /// 
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBashTool20241022NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBashTool20241022Name value)
        {
            return value switch
            {
                BetaBashTool20241022Name.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBashTool20241022Name? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BetaBashTool20241022Name.Bash,
                _ => null,
            };
        }
    }
}