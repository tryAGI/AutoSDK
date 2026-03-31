//HintName: G.Models.FunctionDataNullishGlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataNullishGlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishGlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishGlobalType value)
        {
            return value switch
            {
                FunctionDataNullishGlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishGlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => FunctionDataNullishGlobalType.Global,
                _ => null,
            };
        }
    }
}