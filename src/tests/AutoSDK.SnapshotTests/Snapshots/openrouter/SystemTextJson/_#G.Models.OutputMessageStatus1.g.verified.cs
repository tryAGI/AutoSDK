//HintName: G.Models.OutputMessageStatus1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMessageStatus1
    {
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageStatus1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageStatus1 value)
        {
            return value switch
            {
                OutputMessageStatus1.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageStatus1? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => OutputMessageStatus1.Incomplete,
                _ => null,
            };
        }
    }
}