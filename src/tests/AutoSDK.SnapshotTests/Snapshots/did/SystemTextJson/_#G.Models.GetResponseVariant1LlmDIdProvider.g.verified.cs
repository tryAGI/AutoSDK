//HintName: G.Models.GetResponseVariant1LlmDIdProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum GetResponseVariant1LlmDIdProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResponseVariant1LlmDIdProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1LlmDIdProvider value)
        {
            return value switch
            {
                GetResponseVariant1LlmDIdProvider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1LlmDIdProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => GetResponseVariant1LlmDIdProvider.DId,
                _ => null,
            };
        }
    }
}