//HintName: G.Models.OutputItemFunctionCallStatus1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemFunctionCallStatus1
    {
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemFunctionCallStatus1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemFunctionCallStatus1 value)
        {
            return value switch
            {
                OutputItemFunctionCallStatus1.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemFunctionCallStatus1? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => OutputItemFunctionCallStatus1.Incomplete,
                _ => null,
            };
        }
    }
}