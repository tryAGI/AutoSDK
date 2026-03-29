//HintName: G.Models.LLMConfigDIdProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigDIdProvider
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
    public static class LLMConfigDIdProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigDIdProvider value)
        {
            return value switch
            {
                LLMConfigDIdProvider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigDIdProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => LLMConfigDIdProvider.DId,
                _ => null,
            };
        }
    }
}