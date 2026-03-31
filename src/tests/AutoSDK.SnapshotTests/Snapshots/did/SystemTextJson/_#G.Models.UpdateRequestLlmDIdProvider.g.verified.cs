//HintName: G.Models.UpdateRequestLlmDIdProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum UpdateRequestLlmDIdProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRequestLlmDIdProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestLlmDIdProvider value)
        {
            return value switch
            {
                UpdateRequestLlmDIdProvider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestLlmDIdProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => UpdateRequestLlmDIdProvider.DId,
                _ => null,
            };
        }
    }
}