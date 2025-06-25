//HintName: G.Models.ToolChoiceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolChoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceDiscriminatorType value)
        {
            return value switch
            {
                ToolChoiceDiscriminatorType.Any => "any",
                ToolChoiceDiscriminatorType.Auto => "auto",
                ToolChoiceDiscriminatorType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "any" => ToolChoiceDiscriminatorType.Any,
                "auto" => ToolChoiceDiscriminatorType.Auto,
                "tool" => ToolChoiceDiscriminatorType.Tool,
                _ => null,
            };
        }
    }
}