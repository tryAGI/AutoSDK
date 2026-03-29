//HintName: G.Models.CreateCerebrasCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCerebrasCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCerebrasCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCerebrasCredentialDTOProvider value)
        {
            return value switch
            {
                CreateCerebrasCredentialDTOProvider.Cerebras => "cerebras",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCerebrasCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "cerebras" => CreateCerebrasCredentialDTOProvider.Cerebras,
                _ => null,
            };
        }
    }
}