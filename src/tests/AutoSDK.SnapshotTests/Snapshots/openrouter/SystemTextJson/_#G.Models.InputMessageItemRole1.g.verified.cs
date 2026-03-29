//HintName: G.Models.InputMessageItemRole1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputMessageItemRole1
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageItemRole1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageItemRole1 value)
        {
            return value switch
            {
                InputMessageItemRole1.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageItemRole1? ToEnum(string value)
        {
            return value switch
            {
                "system" => InputMessageItemRole1.System,
                _ => null,
            };
        }
    }
}