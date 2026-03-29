//HintName: G.Models.CreateRimeAICredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRimeAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        RimeAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRimeAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRimeAICredentialDTOProvider value)
        {
            return value switch
            {
                CreateRimeAICredentialDTOProvider.RimeAi => "rime-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRimeAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "rime-ai" => CreateRimeAICredentialDTOProvider.RimeAi,
                _ => null,
            };
        }
    }
}