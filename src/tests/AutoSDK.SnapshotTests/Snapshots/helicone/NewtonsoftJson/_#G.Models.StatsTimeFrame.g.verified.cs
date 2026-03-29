//HintName: G.Models.StatsTimeFrame.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StatsTimeFrame
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1y")]
        x1y,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="24h")]
        x24h,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="30d")]
        x30d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3m")]
        x3m,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="7d")]
        x7d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatsTimeFrameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatsTimeFrame value)
        {
            return value switch
            {
                StatsTimeFrame.x1y => "1y",
                StatsTimeFrame.x24h => "24h",
                StatsTimeFrame.x30d => "30d",
                StatsTimeFrame.x3m => "3m",
                StatsTimeFrame.x7d => "7d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatsTimeFrame? ToEnum(string value)
        {
            return value switch
            {
                "1y" => StatsTimeFrame.x1y,
                "24h" => StatsTimeFrame.x24h,
                "30d" => StatsTimeFrame.x30d,
                "3m" => StatsTimeFrame.x3m,
                "7d" => StatsTimeFrame.x7d,
                _ => null,
            };
        }
    }
}