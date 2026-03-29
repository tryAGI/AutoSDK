//HintName: G.Models.MessagesRequestServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        StandardOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestServiceTier value)
        {
            return value switch
            {
                MessagesRequestServiceTier.Auto => "auto",
                MessagesRequestServiceTier.StandardOnly => "standard_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => MessagesRequestServiceTier.Auto,
                "standard_only" => MessagesRequestServiceTier.StandardOnly,
                _ => null,
            };
        }
    }
}