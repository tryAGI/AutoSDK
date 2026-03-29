//HintName: G.Models.RegexFlag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Supported regex flags.
    /// </summary>
    public enum RegexFlag
    {
        /// <summary>
        /// 
        /// </summary>
        Ascii,
        /// <summary>
        /// 
        /// </summary>
        Dotall,
        /// <summary>
        /// 
        /// </summary>
        Ignorecase,
        /// <summary>
        /// 
        /// </summary>
        Multiline,
        /// <summary>
        /// 
        /// </summary>
        Unicode,
        /// <summary>
        /// 
        /// </summary>
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