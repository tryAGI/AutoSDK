//HintName: G.Models.CreateLangfuseCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLangfuseCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLangfuseCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLangfuseCredentialDTOProvider value)
        {
            return value switch
            {
                CreateLangfuseCredentialDTOProvider.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLangfuseCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => CreateLangfuseCredentialDTOProvider.Langfuse,
                _ => null,
            };
        }
    }
}