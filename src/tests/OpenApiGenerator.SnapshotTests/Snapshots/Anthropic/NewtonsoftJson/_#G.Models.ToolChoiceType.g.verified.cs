//HintName: G.Models.ToolChoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the model should use the provided tools. The model can use a specific tool, <br/>
    /// any available tool, or decide by itself.<br/>
    /// - `auto`: allows Claude to decide whether to call any provided tools or not. This is the default value.<br/>
    /// - `any`: tells Claude that it must use one of the provided tools, but doesn’t force a particular tool.<br/>
    /// - `tool`: allows us to force Claude to always use a particular tool specified in the `name` field.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="any")]
        Any,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceType value)
        {
            return value switch
            {
                ToolChoiceType.Auto => "auto",
                ToolChoiceType.Any => "any",
                ToolChoiceType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolChoiceType.Auto,
                "any" => ToolChoiceType.Any,
                "tool" => ToolChoiceType.Tool,
                _ => null,
            };
        }
    }
}