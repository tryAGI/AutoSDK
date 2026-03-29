//HintName: G.Models.GetSpendBreakdownTimeRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetSpendBreakdownTimeRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="30d")]
        x30d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="7d")]
        x7d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="90d")]
        x90d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpendBreakdownTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpendBreakdownTimeRange value)
        {
            return value switch
            {
                GetSpendBreakdownTimeRange.x30d => "30d",
                GetSpendBreakdownTimeRange.x7d => "7d",
                GetSpendBreakdownTimeRange.x90d => "90d",
                GetSpendBreakdownTimeRange.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpendBreakdownTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "30d" => GetSpendBreakdownTimeRange.x30d,
                "7d" => GetSpendBreakdownTimeRange.x7d,
                "90d" => GetSpendBreakdownTimeRange.x90d,
                "all" => GetSpendBreakdownTimeRange.All,
                _ => null,
            };
        }
    }
}