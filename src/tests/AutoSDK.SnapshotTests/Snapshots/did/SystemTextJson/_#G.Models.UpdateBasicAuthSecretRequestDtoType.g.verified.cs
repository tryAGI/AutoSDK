//HintName: G.Models.UpdateBasicAuthSecretRequestDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type.
    /// </summary>
    public enum UpdateBasicAuthSecretRequestDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBasicAuthSecretRequestDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBasicAuthSecretRequestDtoType value)
        {
            return value switch
            {
                UpdateBasicAuthSecretRequestDtoType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBasicAuthSecretRequestDtoType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => UpdateBasicAuthSecretRequestDtoType.Basic,
                _ => null,
            };
        }
    }
}