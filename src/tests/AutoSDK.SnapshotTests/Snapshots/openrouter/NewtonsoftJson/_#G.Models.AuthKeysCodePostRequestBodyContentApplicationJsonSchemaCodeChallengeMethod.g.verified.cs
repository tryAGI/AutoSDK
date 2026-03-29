//HintName: G.Models.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The method used to generate the code challenge
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod
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
    public static class AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod value)
        {
            return value switch
            {
                AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.S256 => "S256",
                AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.Plain => "plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? ToEnum(string value)
        {
            return value switch
            {
                "S256" => AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.S256,
                "plain" => AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod.Plain,
                _ => null,
            };
        }
    }
}