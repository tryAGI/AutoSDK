//HintName: G.Models.SecretReferenceListItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretReferenceListItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret-reference")]
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