//HintName: G.Models.V2PhoneCallResponseVariant1Direction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Direction of the phone call.<br/>
    /// Example: inbound
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum V2PhoneCallResponseVariant1Direction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inbound")]
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outbound")]
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2PhoneCallResponseVariant1DirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2PhoneCallResponseVariant1Direction value)
        {
            return value switch
            {
                V2PhoneCallResponseVariant1Direction.Inbound => "inbound",
                V2PhoneCallResponseVariant1Direction.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2PhoneCallResponseVariant1Direction? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => V2PhoneCallResponseVariant1Direction.Inbound,
                "outbound" => V2PhoneCallResponseVariant1Direction.Outbound,
                _ => null,
            };
        }
    }
}