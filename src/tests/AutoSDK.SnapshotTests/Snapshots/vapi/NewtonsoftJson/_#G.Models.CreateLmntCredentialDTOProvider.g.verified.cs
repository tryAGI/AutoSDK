//HintName: G.Models.CreateLmntCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateLmntCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lmnt")]
        Lmnt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLmntCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLmntCredentialDTOProvider value)
        {
            return value switch
            {
                CreateLmntCredentialDTOProvider.Lmnt => "lmnt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLmntCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "lmnt" => CreateLmntCredentialDTOProvider.Lmnt,
                _ => null,
            };
        }
    }
}