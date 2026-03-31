//HintName: G.Models.CreateRequestLlmVariant5Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum CreateRequestLlmVariant5Provider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestLlmVariant5ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant5Provider value)
        {
            return value switch
            {
                CreateRequestLlmVariant5Provider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant5Provider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => CreateRequestLlmVariant5Provider.DId,
                _ => null,
            };
        }
    }
}