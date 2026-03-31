//HintName: G.Models.CreateBearerAuthSecretRequestDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    public enum CreateBearerAuthSecretRequestDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBearerAuthSecretRequestDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBearerAuthSecretRequestDtoType value)
        {
            return value switch
            {
                CreateBearerAuthSecretRequestDtoType.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBearerAuthSecretRequestDtoType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => CreateBearerAuthSecretRequestDtoType.Bearer,
                _ => null,
            };
        }
    }
}