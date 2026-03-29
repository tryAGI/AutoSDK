//HintName: G.Models.ContentsRequestLivecrawl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for livecrawling pages.<br/>
    /// 'never': Disable livecrawling (default for neural search).<br/>
    /// 'fallback': Livecrawl when cache is empty.<br/>
    /// 'always': Always livecrawl.<br/>
    /// 'preferred': Always try to livecrawl, but fall back to cache if crawling fails.<br/>
    /// Example: always
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentsRequestLivecrawl
    {
        /// <summary>
        /// Always livecrawl.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always")]
        Always,
        /// <summary>
        /// Livecrawl when cache is empty.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fallback")]
        Fallback,
        /// <summary>
        /// Disable livecrawling (default for neural search).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="never")]
        Never,
        /// <summary>
        /// Always try to livecrawl, but fall back to cache if crawling fails.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preferred")]
        Preferred,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentsRequestLivecrawlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestLivecrawl value)
        {
            return value switch
            {
                ContentsRequestLivecrawl.Always => "always",
                ContentsRequestLivecrawl.Fallback => "fallback",
                ContentsRequestLivecrawl.Never => "never",
                ContentsRequestLivecrawl.Preferred => "preferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestLivecrawl? ToEnum(string value)
        {
            return value switch
            {
                "always" => ContentsRequestLivecrawl.Always,
                "fallback" => ContentsRequestLivecrawl.Fallback,
                "never" => ContentsRequestLivecrawl.Never,
                "preferred" => ContentsRequestLivecrawl.Preferred,
                _ => null,
            };
        }
    }
}