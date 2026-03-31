//HintName: G.Models.DIdLLMCreateDtoProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum DIdLLMCreateDtoProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DIdLLMCreateDtoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIdLLMCreateDtoProvider value)
        {
            return value switch
            {
                DIdLLMCreateDtoProvider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIdLLMCreateDtoProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => DIdLLMCreateDtoProvider.DId,
                _ => null,
            };
        }
    }
}