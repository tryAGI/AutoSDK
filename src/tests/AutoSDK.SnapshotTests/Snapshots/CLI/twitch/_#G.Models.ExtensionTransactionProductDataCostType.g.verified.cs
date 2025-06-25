﻿//HintName: G.Models.ExtensionTransactionProductDataCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of currency exchanged. Possible values are:  <br/>
    ///   <br/>
    /// * bits
    /// </summary>
    public enum ExtensionTransactionProductDataCostType
    {
        /// <summary>
        /// 
        /// </summary>
        Bits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtensionTransactionProductDataCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtensionTransactionProductDataCostType value)
        {
            return value switch
            {
                ExtensionTransactionProductDataCostType.Bits => "bits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtensionTransactionProductDataCostType? ToEnum(string value)
        {
            return value switch
            {
                "bits" => ExtensionTransactionProductDataCostType.Bits,
                _ => null,
            };
        }
    }
}