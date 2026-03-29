//HintName: G.Models.CreateGoHighLevelMCPCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateGoHighLevelMCPCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ghl.oauth2-authorization")]
        GhlOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoHighLevelMCPCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoHighLevelMCPCredentialDTOProvider value)
        {
            return value switch
            {
                CreateGoHighLevelMCPCredentialDTOProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoHighLevelMCPCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "ghl.oauth2-authorization" => CreateGoHighLevelMCPCredentialDTOProvider.GhlOauth2Authorization,
                _ => null,
            };
        }
    }
}