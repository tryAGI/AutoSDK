//HintName: G.Models.CreateAnyscaleCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAnyscaleCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anyscale")]
        Anyscale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAnyscaleCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnyscaleCredentialDTOProvider value)
        {
            return value switch
            {
                CreateAnyscaleCredentialDTOProvider.Anyscale => "anyscale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnyscaleCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "anyscale" => CreateAnyscaleCredentialDTOProvider.Anyscale,
                _ => null,
            };
        }
    }
}