//HintName: G.Models.GetVideosPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetVideosPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="day")]
        Day,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="week")]
        Week,
    }

    public static class GetVideosPeriodExtensions
    {
        public static string ToValueString(this GetVideosPeriod value)
        {
            return value switch
            {
                GetVideosPeriod.All => "all",
                GetVideosPeriod.Day => "day",
                GetVideosPeriod.Month => "month",
                GetVideosPeriod.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetVideosPeriod ToEnum(string value)
        {
            return value switch
            {
                "all" => GetVideosPeriod.All,
                "day" => GetVideosPeriod.Day,
                "month" => GetVideosPeriod.Month,
                "week" => GetVideosPeriod.Week,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetVideosPeriod ToEnum(int value)
        {
            return value switch
            {
                0 => GetVideosPeriod.All,
                1 => GetVideosPeriod.Day,
                2 => GetVideosPeriod.Month,
                3 => GetVideosPeriod.Week,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}