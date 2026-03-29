//HintName: G.Models.CustomerCustomEndpointingRuleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This endpointing rule is based on current customer message as they are speaking.<br/>
    /// Flow:<br/>
    /// - Assistant speaks<br/>
    /// - Customer starts speaking<br/>
    /// - Customer transcription comes in<br/>
    /// - This rule is evaluated on the current customer transcription<br/>
    /// - If a match is found based on `regex`, the endpointing timeout is set to `timeoutSeconds`<br/>
    /// Usage:<br/>
    /// - If you want to wait longer while customer is speaking numbers, you can set a longer timeout.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomerCustomEndpointingRuleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer")]
        Customer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerCustomEndpointingRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerCustomEndpointingRuleType value)
        {
            return value switch
            {
                CustomerCustomEndpointingRuleType.Customer => "customer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerCustomEndpointingRuleType? ToEnum(string value)
        {
            return value switch
            {
                "customer" => CustomerCustomEndpointingRuleType.Customer,
                _ => null,
            };
        }
    }
}