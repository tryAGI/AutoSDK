﻿//HintName: G.Models.BetaTextEditor20250124Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in tool_use blocks.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaTextEditor20250124Name
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="str_replace_editor")]
        StrReplaceEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextEditor20250124NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditor20250124Name value)
        {
            return value switch
            {
                BetaTextEditor20250124Name.StrReplaceEditor => "str_replace_editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditor20250124Name? ToEnum(string value)
        {
            return value switch
            {
                "str_replace_editor" => BetaTextEditor20250124Name.StrReplaceEditor,
                _ => null,
            };
        }
    }
}