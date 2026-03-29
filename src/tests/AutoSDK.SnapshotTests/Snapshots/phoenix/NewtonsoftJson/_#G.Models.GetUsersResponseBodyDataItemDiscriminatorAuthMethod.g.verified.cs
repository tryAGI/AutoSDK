//HintName: G.Models.GetUsersResponseBodyDataItemDiscriminatorAuthMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetUsersResponseBodyDataItemDiscriminatorAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LDAP")]
        Ldap,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOCAL")]
        Local,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OAUTH2")]
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsersResponseBodyDataItemDiscriminatorAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersResponseBodyDataItemDiscriminatorAuthMethod value)
        {
            return value switch
            {
                GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Ldap => "LDAP",
                GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Local => "LOCAL",
                GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Oauth2 => "OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersResponseBodyDataItemDiscriminatorAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "LDAP" => GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Ldap,
                "LOCAL" => GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Local,
                "OAUTH2" => GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Oauth2,
                _ => null,
            };
        }
    }
}