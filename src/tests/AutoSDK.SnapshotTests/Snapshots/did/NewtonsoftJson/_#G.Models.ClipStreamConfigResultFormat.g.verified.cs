//HintName: G.Models.ClipStreamConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipStreamConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mov")]
        Mov,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipStreamConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipStreamConfigResultFormat value)
        {
            return value switch
            {
                ClipStreamConfigResultFormat.Mov => "mov",
                ClipStreamConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipStreamConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => ClipStreamConfigResultFormat.Mov,
                "mp4" => ClipStreamConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}