//HintName: G.Models.DatetimeIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatetimeIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        Datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatetimeIndexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatetimeIndexType value)
        {
            return value switch
            {
                DatetimeIndexType.Datetime => "datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatetimeIndexType? ToEnum(string value)
        {
            return value switch
            {
                "datetime" => DatetimeIndexType.Datetime,
                _ => null,
            };
        }
    }
}