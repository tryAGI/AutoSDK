//HintName: G.Models.CharacterRefreshPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CharacterRefreshPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3_month_period")]
        x3MonthPeriod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="6_month_period")]
        x6MonthPeriod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="annual_period")]
        AnnualPeriod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monthly_period")]
        MonthlyPeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterRefreshPeriod value)
        {
            return value switch
            {
                CharacterRefreshPeriod.x3MonthPeriod => "3_month_period",
                CharacterRefreshPeriod.x6MonthPeriod => "6_month_period",
                CharacterRefreshPeriod.AnnualPeriod => "annual_period",
                CharacterRefreshPeriod.MonthlyPeriod => "monthly_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "3_month_period" => CharacterRefreshPeriod.x3MonthPeriod,
                "6_month_period" => CharacterRefreshPeriod.x6MonthPeriod,
                "annual_period" => CharacterRefreshPeriod.AnnualPeriod,
                "monthly_period" => CharacterRefreshPeriod.MonthlyPeriod,
                _ => null,
            };
        }
    }
}