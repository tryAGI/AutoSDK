//HintName: G.Models.SanitizedSecretDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SanitizedSecretDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key")]
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bearer")]
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oauth2")]
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SanitizedSecretDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SanitizedSecretDtoType value)
        {
            return value switch
            {
                SanitizedSecretDtoType.ApiKey => "api_key",
                SanitizedSecretDtoType.Basic => "basic",
                SanitizedSecretDtoType.Bearer => "bearer",
                SanitizedSecretDtoType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SanitizedSecretDtoType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => SanitizedSecretDtoType.ApiKey,
                "basic" => SanitizedSecretDtoType.Basic,
                "bearer" => SanitizedSecretDtoType.Bearer,
                "oauth2" => SanitizedSecretDtoType.Oauth2,
                _ => null,
            };
        }
    }
}