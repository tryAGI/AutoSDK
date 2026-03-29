//HintName: G.Models.CreateAssemblyAICredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssemblyAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        AssemblyAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssemblyAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssemblyAICredentialDTOProvider value)
        {
            return value switch
            {
                CreateAssemblyAICredentialDTOProvider.AssemblyAi => "assembly-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssemblyAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "assembly-ai" => CreateAssemblyAICredentialDTOProvider.AssemblyAi,
                _ => null,
            };
        }
    }
}