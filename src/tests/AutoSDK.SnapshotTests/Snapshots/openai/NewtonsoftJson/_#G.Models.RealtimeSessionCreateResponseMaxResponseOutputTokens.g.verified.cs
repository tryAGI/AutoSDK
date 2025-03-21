//HintName: G.Models.RealtimeSessionCreateResponseMaxResponseOutputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateResponseMaxResponseOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inf")]
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseMaxResponseOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseMaxResponseOutputTokens value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseMaxResponseOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseMaxResponseOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeSessionCreateResponseMaxResponseOutputTokens.Inf,
                _ => null,
            };
        }
    }
}