//HintName: G.Models.BudgetResetPeriodEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `Monthly` - Monthly<br/>
    /// * `Yearly` - Yearly
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BudgetResetPeriodEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Yearly")]
        Yearly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetResetPeriodEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetResetPeriodEnum value)
        {
            return value switch
            {
                BudgetResetPeriodEnum.Monthly => "Monthly",
                BudgetResetPeriodEnum.Yearly => "Yearly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetResetPeriodEnum? ToEnum(string value)
        {
            return value switch
            {
                "Monthly" => BudgetResetPeriodEnum.Monthly,
                "Yearly" => BudgetResetPeriodEnum.Yearly,
                _ => null,
            };
        }
    }
}