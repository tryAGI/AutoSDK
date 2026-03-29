//HintName: G.Models.TableFormerMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operating modes for TableFormer table structure extraction model.<br/>
    /// Controls the trade-off between processing speed and extraction accuracy.<br/>
    /// Choose based on your performance requirements and document complexity.<br/>
    /// Attributes:<br/>
    ///     FAST: Fast mode prioritizes speed over precision. Suitable for simple tables or high-volume<br/>
    ///         processing.<br/>
    ///     ACCURATE: Accurate mode provides higher quality results with slower processing. Recommended for complex<br/>
    ///         tables and production use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TableFormerMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="accurate")]
        Accurate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableFormerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableFormerMode value)
        {
            return value switch
            {
                TableFormerMode.Accurate => "accurate",
                TableFormerMode.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableFormerMode? ToEnum(string value)
        {
            return value switch
            {
                "accurate" => TableFormerMode.Accurate,
                "fast" => TableFormerMode.Fast,
                _ => null,
            };
        }
    }
}