//HintName: G.Models.MessagesRequestServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard_only")]
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