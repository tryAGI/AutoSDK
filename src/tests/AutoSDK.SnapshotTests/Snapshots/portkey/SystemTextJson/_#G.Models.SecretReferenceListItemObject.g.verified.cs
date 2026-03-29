//HintName: G.Models.SecretReferenceListItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretReferenceListItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        SecretReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretReferenceListItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretReferenceListItemObject value)
        {
            return value switch
            {
                SecretReferenceListItemObject.SecretReference => "secret-reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretReferenceListItemObject? ToEnum(string value)
        {
            return value switch
            {
                "secret-reference" => SecretReferenceListItemObject.SecretReference,
                _ => null,
            };
        }
    }
}