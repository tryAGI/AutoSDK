//HintName: G.Models.V2PhoneCallResponseVariant1CallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the call. Used to distinguish between web call and phone call.<br/>
    /// Example: phone_call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum V2PhoneCallResponseVariant1CallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone_call")]
        PhoneCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2PhoneCallResponseVariant1CallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2PhoneCallResponseVariant1CallType value)
        {
            return value switch
            {
                V2PhoneCallResponseVariant1CallType.PhoneCall => "phone_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2PhoneCallResponseVariant1CallType? ToEnum(string value)
        {
            return value switch
            {
                "phone_call" => V2PhoneCallResponseVariant1CallType.PhoneCall,
                _ => null,
            };
        }
    }
}