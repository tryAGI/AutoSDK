//HintName: G.Models.UpdateBearerAuthSecretRequestDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type.
    /// </summary>
    public enum UpdateBearerAuthSecretRequestDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBearerAuthSecretRequestDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBearerAuthSecretRequestDtoType value)
        {
            return value switch
            {
                UpdateBearerAuthSecretRequestDtoType.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBearerAuthSecretRequestDtoType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => UpdateBearerAuthSecretRequestDtoType.Bearer,
                _ => null,
            };
        }
    }
}