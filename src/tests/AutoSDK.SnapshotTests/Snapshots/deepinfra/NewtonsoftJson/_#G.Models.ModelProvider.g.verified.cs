//HintName: G.Models.ModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="huggingface")]
        Huggingface,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepinfra")]
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cnt")]
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