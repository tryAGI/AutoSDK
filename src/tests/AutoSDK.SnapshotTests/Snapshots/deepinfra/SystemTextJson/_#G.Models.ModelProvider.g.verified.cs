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
        Cnt,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Huggingface,
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
                ModelProvider.Cnt => "cnt",
                ModelProvider.Deepinfra => "deepinfra",
                ModelProvider.Huggingface => "huggingface",
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
                "cnt" => ModelProvider.Cnt,
                "deepinfra" => ModelProvider.Deepinfra,
                "huggingface" => ModelProvider.Huggingface,
                _ => null,
            };
        }
    }
}