//HintName: G.Models.CreateCrawlRequestExtractDepth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced extraction retrieves more data, including tables and embedded content, with higher success but may increase latency. `basic` extraction costs 1 credit per 5 successful extractions, while `advanced` extraction costs 2 credits per 5 successful extractions.<br/>
    /// Default Value: basic
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCrawlRequestExtractDepth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="advanced")]
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCrawlRequestExtractDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCrawlRequestExtractDepth value)
        {
            return value switch
            {
                CreateCrawlRequestExtractDepth.Advanced => "advanced",
                CreateCrawlRequestExtractDepth.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCrawlRequestExtractDepth? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => CreateCrawlRequestExtractDepth.Advanced,
                "basic" => CreateCrawlRequestExtractDepth.Basic,
                _ => null,
            };
        }
    }
}