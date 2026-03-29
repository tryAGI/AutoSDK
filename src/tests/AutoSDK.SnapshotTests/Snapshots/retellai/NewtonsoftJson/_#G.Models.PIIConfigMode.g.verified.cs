//HintName: G.Models.PIIConfigMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The processing mode for PII scrubbing. Currently only post-call is supported.<br/>
    /// Default Value: post_call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PIIConfigMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="post_call")]
        PostCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PIIConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PIIConfigMode value)
        {
            return value switch
            {
                PIIConfigMode.PostCall => "post_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PIIConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "post_call" => PIIConfigMode.PostCall,
                _ => null,
            };
        }
    }
}