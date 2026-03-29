//HintName: G.Models.RegexFlag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Supported regex flags.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RegexFlag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASCII")]
        Ascii,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DOTALL")]
        Dotall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IGNORECASE")]
        Ignorecase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MULTILINE")]
        Multiline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNICODE")]
        Unicode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VERBOSE")]
        Verbose,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegexFlagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegexFlag value)
        {
            return value switch
            {
                RegexFlag.Ascii => "ASCII",
                RegexFlag.Dotall => "DOTALL",
                RegexFlag.Ignorecase => "IGNORECASE",
                RegexFlag.Multiline => "MULTILINE",
                RegexFlag.Unicode => "UNICODE",
                RegexFlag.Verbose => "VERBOSE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegexFlag? ToEnum(string value)
        {
            return value switch
            {
                "ASCII" => RegexFlag.Ascii,
                "DOTALL" => RegexFlag.Dotall,
                "IGNORECASE" => RegexFlag.Ignorecase,
                "MULTILINE" => RegexFlag.Multiline,
                "UNICODE" => RegexFlag.Unicode,
                "VERBOSE" => RegexFlag.Verbose,
                _ => null,
            };
        }
    }
}