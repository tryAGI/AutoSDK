//HintName: G.Models.BrowserbaseProxyConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of proxy. Always use 'browserbase' for the Browserbase managed proxy network.
    /// </summary>
    public enum BrowserbaseProxyConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Browserbase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BrowserbaseProxyConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrowserbaseProxyConfigType value)
        {
            return value switch
            {
                BrowserbaseProxyConfigType.Browserbase => "browserbase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrowserbaseProxyConfigType? ToEnum(string value)
        {
            return value switch
            {
                "browserbase" => BrowserbaseProxyConfigType.Browserbase,
                _ => null,
            };
        }
    }
}