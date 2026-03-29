//HintName: G.Models.StringToolChoiceOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StringToolChoiceOptions
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
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StringToolChoiceOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StringToolChoiceOptions value)
        {
            return value switch
            {
                StringToolChoiceOptions.Auto => "auto",
                StringToolChoiceOptions.None => "none",
                StringToolChoiceOptions.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StringToolChoiceOptions? ToEnum(string value)
        {
            return value switch
            {
                "auto" => StringToolChoiceOptions.Auto,
                "none" => StringToolChoiceOptions.None,
                "required" => StringToolChoiceOptions.Required,
                _ => null,
            };
        }
    }
}