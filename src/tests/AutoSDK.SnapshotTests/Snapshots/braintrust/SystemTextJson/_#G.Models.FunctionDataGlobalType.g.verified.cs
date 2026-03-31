//HintName: G.Models.FunctionDataGlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataGlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataGlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataGlobalType value)
        {
            return value switch
            {
                FunctionDataGlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataGlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => FunctionDataGlobalType.Global,
                _ => null,
            };
        }
    }
}