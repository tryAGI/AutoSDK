//HintName: G.Models.GetAgentResponseModelPhoneNumberDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentResponseModelPhoneNumberDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        SipTrunk,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentResponseModelPhoneNumberDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentResponseModelPhoneNumberDiscriminatorProvider value)
        {
            return value switch
            {
                GetAgentResponseModelPhoneNumberDiscriminatorProvider.SipTrunk => "sip_trunk",
                GetAgentResponseModelPhoneNumberDiscriminatorProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentResponseModelPhoneNumberDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => GetAgentResponseModelPhoneNumberDiscriminatorProvider.SipTrunk,
                "twilio" => GetAgentResponseModelPhoneNumberDiscriminatorProvider.Twilio,
                _ => null,
            };
        }
    }
}