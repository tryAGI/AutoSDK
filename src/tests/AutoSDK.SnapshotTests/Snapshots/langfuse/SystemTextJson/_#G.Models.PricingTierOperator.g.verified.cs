//HintName: G.Models.PricingTierOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operators for pricing tier conditions
    /// </summary>
    public enum PricingTierOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingTierOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingTierOperator value)
        {
            return value switch
            {
                PricingTierOperator.Eq => "eq",
                PricingTierOperator.Gt => "gt",
                PricingTierOperator.Gte => "gte",
                PricingTierOperator.Lt => "lt",
                PricingTierOperator.Lte => "lte",
                PricingTierOperator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingTierOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => PricingTierOperator.Eq,
                "gt" => PricingTierOperator.Gt,
                "gte" => PricingTierOperator.Gte,
                "lt" => PricingTierOperator.Lt,
                "lte" => PricingTierOperator.Lte,
                "neq" => PricingTierOperator.Neq,
                _ => null,
            };
        }
    }
}