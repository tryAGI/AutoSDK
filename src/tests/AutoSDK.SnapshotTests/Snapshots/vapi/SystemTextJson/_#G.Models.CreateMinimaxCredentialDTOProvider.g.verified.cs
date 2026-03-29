//HintName: G.Models.CreateMinimaxCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMinimaxCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Minimax,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMinimaxCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMinimaxCredentialDTOProvider value)
        {
            return value switch
            {
                CreateMinimaxCredentialDTOProvider.Minimax => "minimax",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMinimaxCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "minimax" => CreateMinimaxCredentialDTOProvider.Minimax,
                _ => null,
            };
        }
    }
}