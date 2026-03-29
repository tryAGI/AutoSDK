//HintName: G.Models.LLMConfigCreateDtoVariant5Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigCreateDtoVariant5Provider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="d-id")]
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCreateDtoVariant5ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant5Provider value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant5Provider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant5Provider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => LLMConfigCreateDtoVariant5Provider.DId,
                _ => null,
            };
        }
    }
}