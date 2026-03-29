//HintName: G.Models.LmntCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LmntCredentialProvider
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
    public static class LmntCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LmntCredentialProvider value)
        {
            return value switch
            {
                LmntCredentialProvider.Lmnt => "lmnt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LmntCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "lmnt" => LmntCredentialProvider.Lmnt,
                _ => null,
            };
        }
    }
}