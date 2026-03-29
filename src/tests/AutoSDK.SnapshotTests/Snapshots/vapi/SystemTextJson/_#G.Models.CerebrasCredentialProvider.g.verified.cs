//HintName: G.Models.CerebrasCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CerebrasCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CerebrasCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CerebrasCredentialProvider value)
        {
            return value switch
            {
                CerebrasCredentialProvider.Cerebras => "cerebras",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CerebrasCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "cerebras" => CerebrasCredentialProvider.Cerebras,
                _ => null,
            };
        }
    }
}