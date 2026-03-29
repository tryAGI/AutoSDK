//HintName: G.Models.CreateUserRequestBodyUserDiscriminatorAuthMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateUserRequestBodyUserDiscriminatorAuthMethod
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
    public static class CreateUserRequestBodyUserDiscriminatorAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUserRequestBodyUserDiscriminatorAuthMethod value)
        {
            return value switch
            {
                CreateUserRequestBodyUserDiscriminatorAuthMethod.Ldap => "LDAP",
                CreateUserRequestBodyUserDiscriminatorAuthMethod.Local => "LOCAL",
                CreateUserRequestBodyUserDiscriminatorAuthMethod.Oauth2 => "OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUserRequestBodyUserDiscriminatorAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "LDAP" => CreateUserRequestBodyUserDiscriminatorAuthMethod.Ldap,
                "LOCAL" => CreateUserRequestBodyUserDiscriminatorAuthMethod.Local,
                "OAUTH2" => CreateUserRequestBodyUserDiscriminatorAuthMethod.Oauth2,
                _ => null,
            };
        }
    }
}