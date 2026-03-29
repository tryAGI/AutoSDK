//HintName: G.Models.HashicorpTokenAuthConfigVaultAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HashicorpTokenAuthConfigVaultAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        Token,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HashicorpTokenAuthConfigVaultAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HashicorpTokenAuthConfigVaultAuthType value)
        {
            return value switch
            {
                HashicorpTokenAuthConfigVaultAuthType.Token => "token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HashicorpTokenAuthConfigVaultAuthType? ToEnum(string value)
        {
            return value switch
            {
                "token" => HashicorpTokenAuthConfigVaultAuthType.Token,
                _ => null,
            };
        }
    }
}