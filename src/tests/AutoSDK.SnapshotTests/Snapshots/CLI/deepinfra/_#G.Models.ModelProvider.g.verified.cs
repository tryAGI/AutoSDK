//HintName: G.Models.ModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Huggingface,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Cnt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelProvider value)
        {
            return value switch
            {
                ModelProvider.Huggingface => "huggingface",
                ModelProvider.Deepinfra => "deepinfra",
                ModelProvider.Cnt => "cnt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "huggingface" => ModelProvider.Huggingface,
                "deepinfra" => ModelProvider.Deepinfra,
                "cnt" => ModelProvider.Cnt,
                _ => null,
            };
        }
    }
}