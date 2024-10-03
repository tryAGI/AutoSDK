//HintName: G.Models.ToolChoiceEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolChoiceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceEnum value)
        {
            return value switch
            {
                ToolChoiceEnum.Auto => "auto",
                ToolChoiceEnum.None => "none",
                ToolChoiceEnum.Any => "any",
                ToolChoiceEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolChoiceEnum.Auto,
                "none" => ToolChoiceEnum.None,
                "any" => ToolChoiceEnum.Any,
                "required" => ToolChoiceEnum.Required,
                _ => null,
            };
        }
    }
}