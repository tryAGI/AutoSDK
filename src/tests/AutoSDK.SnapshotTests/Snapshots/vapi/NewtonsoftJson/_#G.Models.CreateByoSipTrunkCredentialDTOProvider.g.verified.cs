//HintName: G.Models.CreateByoSipTrunkCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This can be used to bring your own SIP trunks or to connect to a Carrier.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateByoSipTrunkCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="byo-sip-trunk")]
        ByoSipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateByoSipTrunkCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateByoSipTrunkCredentialDTOProvider value)
        {
            return value switch
            {
                CreateByoSipTrunkCredentialDTOProvider.ByoSipTrunk => "byo-sip-trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateByoSipTrunkCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-sip-trunk" => CreateByoSipTrunkCredentialDTOProvider.ByoSipTrunk,
                _ => null,
            };
        }
    }
}