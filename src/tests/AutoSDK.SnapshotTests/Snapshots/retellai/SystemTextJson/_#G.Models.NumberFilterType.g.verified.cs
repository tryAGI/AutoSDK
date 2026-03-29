//HintName: G.Models.NumberFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum NumberFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NumberFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NumberFilterType value)
        {
            return value switch
            {
                NumberFilterType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NumberFilterType? ToEnum(string value)
        {
            return value switch
            {
                "number" => NumberFilterType.Number,
                _ => null,
            };
        }
    }
}