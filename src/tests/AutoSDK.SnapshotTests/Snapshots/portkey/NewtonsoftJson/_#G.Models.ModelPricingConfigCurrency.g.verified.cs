//HintName: G.Models.ModelPricingConfigCurrency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Currency code (always USD)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelPricingConfigCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USD")]
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPricingConfigCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPricingConfigCurrency value)
        {
            return value switch
            {
                ModelPricingConfigCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPricingConfigCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ModelPricingConfigCurrency.Usd,
                _ => null,
            };
        }
    }
}