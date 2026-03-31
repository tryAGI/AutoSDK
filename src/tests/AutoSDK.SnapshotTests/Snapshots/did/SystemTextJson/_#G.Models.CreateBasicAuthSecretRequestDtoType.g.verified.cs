//HintName: G.Models.CreateBasicAuthSecretRequestDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    public enum CreateBasicAuthSecretRequestDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBasicAuthSecretRequestDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBasicAuthSecretRequestDtoType value)
        {
            return value switch
            {
                CreateBasicAuthSecretRequestDtoType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBasicAuthSecretRequestDtoType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateBasicAuthSecretRequestDtoType.Basic,
                _ => null,
            };
        }
    }
}