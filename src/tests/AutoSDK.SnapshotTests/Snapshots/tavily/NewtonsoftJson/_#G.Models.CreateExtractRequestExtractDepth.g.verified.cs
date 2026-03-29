//HintName: G.Models.CreateExtractRequestExtractDepth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The depth of the extraction process. `advanced` extraction retrieves more data, including tables and embedded content, with higher success but may increase latency.`basic` extraction costs 1 credit per 5 successful URL extractions, while `advanced` extraction costs 2 credits per 5 successful URL extractions.<br/>
    /// Default Value: basic
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateExtractRequestExtractDepth
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
    public static class CreateExtractRequestExtractDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExtractRequestExtractDepth value)
        {
            return value switch
            {
                CreateExtractRequestExtractDepth.Advanced => "advanced",
                CreateExtractRequestExtractDepth.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExtractRequestExtractDepth? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => CreateExtractRequestExtractDepth.Advanced,
                "basic" => CreateExtractRequestExtractDepth.Basic,
                _ => null,
            };
        }
    }
}