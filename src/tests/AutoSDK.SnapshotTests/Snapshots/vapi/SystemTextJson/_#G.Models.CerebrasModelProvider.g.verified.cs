//HintName: G.Models.CerebrasModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CerebrasModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CerebrasModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CerebrasModelProvider value)
        {
            return value switch
            {
                CerebrasModelProvider.Cerebras => "cerebras",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CerebrasModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "cerebras" => CerebrasModelProvider.Cerebras,
                _ => null,
            };
        }
    }
}