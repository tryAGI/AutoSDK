//HintName: G.Models.ExpressiveAgentPresenterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum ExpressiveAgentPresenterType
    {
        /// <summary>
        /// 
        /// </summary>
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressiveAgentPresenterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAgentPresenterType value)
        {
            return value switch
            {
                ExpressiveAgentPresenterType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAgentPresenterType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => ExpressiveAgentPresenterType.Expressive,
                _ => null,
            };
        }
    }
}