//HintName: G.Models.FunctionCallOutputItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallOutputItemType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallOutputItemType value)
        {
            return value switch
            {
                FunctionCallOutputItemType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => FunctionCallOutputItemType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}