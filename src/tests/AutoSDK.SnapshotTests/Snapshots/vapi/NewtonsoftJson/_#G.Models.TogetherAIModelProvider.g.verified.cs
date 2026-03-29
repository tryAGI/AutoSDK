//HintName: G.Models.TogetherAIModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TogetherAIModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="together-ai")]
        TogetherAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TogetherAIModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TogetherAIModelProvider value)
        {
            return value switch
            {
                TogetherAIModelProvider.TogetherAi => "together-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TogetherAIModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "together-ai" => TogetherAIModelProvider.TogetherAi,
                _ => null,
            };
        }
    }
}