//HintName: G.Models.CustomLLMCreateDtoProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomLLMCreateDtoProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomLLMCreateDtoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomLLMCreateDtoProvider value)
        {
            return value switch
            {
                CustomLLMCreateDtoProvider.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomLLMCreateDtoProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CustomLLMCreateDtoProvider.Custom,
                _ => null,
            };
        }
    }
}