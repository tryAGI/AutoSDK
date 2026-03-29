//HintName: G.Models.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The method used to generate the code challenge
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="S256")]
        S256,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plain")]
        Plain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod value)
        {
            return value switch
            {
                AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.S256 => "S256",
                AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.Plain => "plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? ToEnum(string value)
        {
            return value switch
            {
                "S256" => AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.S256,
                "plain" => AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.Plain,
                _ => null,
            };
        }
    }
}