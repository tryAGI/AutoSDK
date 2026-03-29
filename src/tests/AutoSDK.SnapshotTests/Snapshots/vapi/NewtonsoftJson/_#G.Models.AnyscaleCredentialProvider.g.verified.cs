//HintName: G.Models.AnyscaleCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnyscaleCredentialProvider
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
    public static class AnyscaleCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnyscaleCredentialProvider value)
        {
            return value switch
            {
                AnyscaleCredentialProvider.Anyscale => "anyscale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnyscaleCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "anyscale" => AnyscaleCredentialProvider.Anyscale,
                _ => null,
            };
        }
    }
}