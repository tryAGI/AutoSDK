//HintName: G.Models.CreateSIPTrunkPhoneNumberRequestProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: sip_trunk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSIPTrunkPhoneNumberRequestProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_trunk")]
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSIPTrunkPhoneNumberRequestProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSIPTrunkPhoneNumberRequestProvider value)
        {
            return value switch
            {
                CreateSIPTrunkPhoneNumberRequestProvider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSIPTrunkPhoneNumberRequestProvider? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => CreateSIPTrunkPhoneNumberRequestProvider.SipTrunk,
                _ => null,
            };
        }
    }
}