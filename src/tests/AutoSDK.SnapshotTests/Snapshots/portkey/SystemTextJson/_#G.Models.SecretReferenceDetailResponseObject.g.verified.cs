//HintName: G.Models.SecretReferenceDetailResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretReferenceDetailResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        SecretReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretReferenceDetailResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretReferenceDetailResponseObject value)
        {
            return value switch
            {
                SecretReferenceDetailResponseObject.SecretReference => "secret-reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretReferenceDetailResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "secret-reference" => SecretReferenceDetailResponseObject.SecretReference,
                _ => null,
            };
        }
    }
}