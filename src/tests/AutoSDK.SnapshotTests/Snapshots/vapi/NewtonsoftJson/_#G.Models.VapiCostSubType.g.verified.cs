//HintName: G.Models.VapiCostSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the sub type of the cost.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VapiCostSubType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="normal")]
        Normal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="overage")]
        Overage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiCostSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiCostSubType value)
        {
            return value switch
            {
                VapiCostSubType.Normal => "normal",
                VapiCostSubType.Overage => "overage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiCostSubType? ToEnum(string value)
        {
            return value switch
            {
                "normal" => VapiCostSubType.Normal,
                "overage" => VapiCostSubType.Overage,
                _ => null,
            };
        }
    }
}