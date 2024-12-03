//HintName: G.Models.SummarizeRequestLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `short`, `medium`, `long`, or `auto` defaults to `auto`. Indicates the approximate length of the summary. If `auto` is selected, the best option will be picked based on the input text.<br/>
    /// Default Value: medium<br/>
    /// Included only in requests
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummarizeRequestLength
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="short")]
        Short,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="long")]
        Long,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizeRequestLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizeRequestLength value)
        {
            return value switch
            {
                SummarizeRequestLength.Short => "short",
                SummarizeRequestLength.Medium => "medium",
                SummarizeRequestLength.Long => "long",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizeRequestLength? ToEnum(string value)
        {
            return value switch
            {
                "short" => SummarizeRequestLength.Short,
                "medium" => SummarizeRequestLength.Medium,
                "long" => SummarizeRequestLength.Long,
                _ => null,
            };
        }
    }
}