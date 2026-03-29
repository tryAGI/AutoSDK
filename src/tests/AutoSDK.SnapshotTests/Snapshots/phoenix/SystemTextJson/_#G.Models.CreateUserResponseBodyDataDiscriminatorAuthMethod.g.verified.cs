//HintName: G.Models.CreateUserResponseBodyDataDiscriminatorAuthMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateUserResponseBodyDataDiscriminatorAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Ldap,
        /// <summary>
        /// 
        /// </summary>
        Local,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUserResponseBodyDataDiscriminatorAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUserResponseBodyDataDiscriminatorAuthMethod value)
        {
            return value switch
            {
                CreateUserResponseBodyDataDiscriminatorAuthMethod.Ldap => "LDAP",
                CreateUserResponseBodyDataDiscriminatorAuthMethod.Local => "LOCAL",
                CreateUserResponseBodyDataDiscriminatorAuthMethod.Oauth2 => "OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUserResponseBodyDataDiscriminatorAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "LDAP" => CreateUserResponseBodyDataDiscriminatorAuthMethod.Ldap,
                "LOCAL" => CreateUserResponseBodyDataDiscriminatorAuthMethod.Local,
                "OAUTH2" => CreateUserResponseBodyDataDiscriminatorAuthMethod.Oauth2,
                _ => null,
            };
        }
    }
}