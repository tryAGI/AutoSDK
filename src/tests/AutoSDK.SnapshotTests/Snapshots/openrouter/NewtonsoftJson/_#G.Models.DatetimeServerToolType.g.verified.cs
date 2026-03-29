//HintName: G.Models.DatetimeServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatetimeServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openrouter:datetime")]
        Openrouter_datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatetimeServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatetimeServerToolType value)
        {
            return value switch
            {
                DatetimeServerToolType.Openrouter_datetime => "openrouter:datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatetimeServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:datetime" => DatetimeServerToolType.Openrouter_datetime,
                _ => null,
            };
        }
    }
}