//HintName: G.Models.ListVoicesProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListVoicesProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        HumeAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVoicesProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVoicesProvider value)
        {
            return value switch
            {
                ListVoicesProvider.Custom => "CUSTOM",
                ListVoicesProvider.HumeAi => "HUME_AI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVoicesProvider? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => ListVoicesProvider.Custom,
                "HUME_AI" => ListVoicesProvider.HumeAi,
                _ => null,
            };
        }
    }
}