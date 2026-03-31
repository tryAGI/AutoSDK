//HintName: G.Models.DeleteResponseVariant1LlmDIdProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum DeleteResponseVariant1LlmDIdProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteResponseVariant1LlmDIdProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1LlmDIdProvider value)
        {
            return value switch
            {
                DeleteResponseVariant1LlmDIdProvider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1LlmDIdProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => DeleteResponseVariant1LlmDIdProvider.DId,
                _ => null,
            };
        }
    }
}