//HintName: G.Models.FunctionToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "function" for Function tool.
    /// </summary>
    public enum FunctionToolProviderDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionToolProviderDetailsType value)
        {
            return value switch
            {
                FunctionToolProviderDetailsType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "function" => FunctionToolProviderDetailsType.Function,
                _ => null,
            };
        }
    }
}