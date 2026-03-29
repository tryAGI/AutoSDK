//HintName: G.Models.SecretReferenceDetailResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretReferenceDetailResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretReferenceDetailResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretReferenceDetailResponseStatus value)
        {
            return value switch
            {
                SecretReferenceDetailResponseStatus.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretReferenceDetailResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => SecretReferenceDetailResponseStatus.Active,
                _ => null,
            };
        }
    }
}