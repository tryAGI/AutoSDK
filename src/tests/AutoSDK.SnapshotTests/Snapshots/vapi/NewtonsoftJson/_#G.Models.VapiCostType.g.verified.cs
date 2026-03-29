//HintName: G.Models.VapiCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'vapi' for this class.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VapiCostType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi")]
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiCostType value)
        {
            return value switch
            {
                VapiCostType.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiCostType? ToEnum(string value)
        {
            return value switch
            {
                "vapi" => VapiCostType.Vapi,
                _ => null,
            };
        }
    }
}