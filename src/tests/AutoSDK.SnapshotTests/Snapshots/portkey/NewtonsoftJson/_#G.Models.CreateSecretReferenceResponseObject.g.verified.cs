//HintName: G.Models.CreateSecretReferenceResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSecretReferenceResponseObject
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
    public static class CreateSecretReferenceResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretReferenceResponseObject value)
        {
            return value switch
            {
                CreateSecretReferenceResponseObject.SecretReference => "secret-reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretReferenceResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "secret-reference" => CreateSecretReferenceResponseObject.SecretReference,
                _ => null,
            };
        }
    }
}