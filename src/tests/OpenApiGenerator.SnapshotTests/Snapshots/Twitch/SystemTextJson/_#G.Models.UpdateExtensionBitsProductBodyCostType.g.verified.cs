//HintName: G.Models.UpdateExtensionBitsProductBodyCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of currency. Possible values are:  
    ///   
    /// * bits — The minimum price is 1 and the maximum is 10000.
    /// </summary>
    public enum UpdateExtensionBitsProductBodyCostType
    {
        /// <summary>
        /// 
        /// </summary>
        Bits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateExtensionBitsProductBodyCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateExtensionBitsProductBodyCostType value)
        {
            return value switch
            {
                UpdateExtensionBitsProductBodyCostType.Bits => "bits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateExtensionBitsProductBodyCostType ToEnum(string value)
        {
            return value switch
            {
                "bits" => UpdateExtensionBitsProductBodyCostType.Bits,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}