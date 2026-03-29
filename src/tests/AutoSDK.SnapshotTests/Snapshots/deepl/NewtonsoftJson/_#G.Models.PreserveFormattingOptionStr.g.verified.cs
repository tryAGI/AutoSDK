//HintName: G.Models.PreserveFormattingOptionStr.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets whether the translation engine should respect the original formatting, even if it would usually correct some aspects. Possible values are:<br/>
    ///  * `0` (default)<br/>
    ///  * `1`<br/>
    /// The formatting aspects affected by this setting include:<br/>
    ///  * Punctuation at the beginning and end of the sentence<br/>
    ///  * Upper/lower case at the beginning of the sentence<br/>
    /// Default Value: 0
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PreserveFormattingOptionStr
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="0")]
        x0,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1")]
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreserveFormattingOptionStrExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreserveFormattingOptionStr value)
        {
            return value switch
            {
                PreserveFormattingOptionStr.x0 => "0",
                PreserveFormattingOptionStr.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreserveFormattingOptionStr? ToEnum(string value)
        {
            return value switch
            {
                "0" => PreserveFormattingOptionStr.x0,
                "1" => PreserveFormattingOptionStr.x1,
                _ => null,
            };
        }
    }
}