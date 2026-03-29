//HintName: G.Models.OutputItemFunctionCallStatus0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemFunctionCallStatus0
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemFunctionCallStatus0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemFunctionCallStatus0 value)
        {
            return value switch
            {
                OutputItemFunctionCallStatus0.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemFunctionCallStatus0? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputItemFunctionCallStatus0.Completed,
                _ => null,
            };
        }
    }
}