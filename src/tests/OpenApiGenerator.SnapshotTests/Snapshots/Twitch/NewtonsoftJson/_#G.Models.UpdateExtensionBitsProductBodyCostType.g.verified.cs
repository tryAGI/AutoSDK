//HintName: G.Models.UpdateExtensionBitsProductBodyCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of currency. Possible values are:  
    ///   
    /// * bits — The minimum price is 1 and the maximum is 10000.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateExtensionBitsProductBodyCostType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bits")]
        Bits,
    }

    public static class UpdateExtensionBitsProductBodyCostTypeExtensions
    {
        public static string ToValueString(this UpdateExtensionBitsProductBodyCostType value)
        {
            return value switch
            {
                UpdateExtensionBitsProductBodyCostType.Bits => "bits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateExtensionBitsProductBodyCostType ToEnum(string value)
        {
            return value switch
            {
                "bits" => UpdateExtensionBitsProductBodyCostType.Bits,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateExtensionBitsProductBodyCostType ToEnum(int value)
        {
            return value switch
            {
                0 => UpdateExtensionBitsProductBodyCostType.Bits,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}