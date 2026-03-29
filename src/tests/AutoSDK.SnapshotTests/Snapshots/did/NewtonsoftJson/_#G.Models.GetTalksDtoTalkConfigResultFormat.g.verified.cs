//HintName: G.Models.GetTalksDtoTalkConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalksDtoTalkConfigResultFormat
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
    public static class GetTalksDtoTalkConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalksDtoTalkConfigResultFormat value)
        {
            return value switch
            {
                GetTalksDtoTalkConfigResultFormat.Mov => "mov",
                GetTalksDtoTalkConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalksDtoTalkConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetTalksDtoTalkConfigResultFormat.Mov,
                "mp4" => GetTalksDtoTalkConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}