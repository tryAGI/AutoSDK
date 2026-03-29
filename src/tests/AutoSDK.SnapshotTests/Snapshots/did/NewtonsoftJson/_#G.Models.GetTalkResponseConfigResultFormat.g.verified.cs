//HintName: G.Models.GetTalkResponseConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalkResponseConfigResultFormat
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
    public static class GetTalkResponseConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalkResponseConfigResultFormat value)
        {
            return value switch
            {
                GetTalkResponseConfigResultFormat.Mov => "mov",
                GetTalkResponseConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalkResponseConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetTalkResponseConfigResultFormat.Mov,
                "mp4" => GetTalkResponseConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}