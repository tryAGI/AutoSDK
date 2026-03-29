//HintName: G.Models.CreateSearchRequestTimeRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The time range back from the current date to filter results based on publish date or last updated date. Useful when looking for sources that have published or updated data.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSearchRequestTimeRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="d")]
        D,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="day")]
        Day,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="m")]
        M,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="w")]
        W,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="week")]
        Week,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="y")]
        Y,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="year")]
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSearchRequestTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchRequestTimeRange value)
        {
            return value switch
            {
                CreateSearchRequestTimeRange.D => "d",
                CreateSearchRequestTimeRange.Day => "day",
                CreateSearchRequestTimeRange.M => "m",
                CreateSearchRequestTimeRange.Month => "month",
                CreateSearchRequestTimeRange.W => "w",
                CreateSearchRequestTimeRange.Week => "week",
                CreateSearchRequestTimeRange.Y => "y",
                CreateSearchRequestTimeRange.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchRequestTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "d" => CreateSearchRequestTimeRange.D,
                "day" => CreateSearchRequestTimeRange.Day,
                "m" => CreateSearchRequestTimeRange.M,
                "month" => CreateSearchRequestTimeRange.Month,
                "w" => CreateSearchRequestTimeRange.W,
                "week" => CreateSearchRequestTimeRange.Week,
                "y" => CreateSearchRequestTimeRange.Y,
                "year" => CreateSearchRequestTimeRange.Year,
                _ => null,
            };
        }
    }
}