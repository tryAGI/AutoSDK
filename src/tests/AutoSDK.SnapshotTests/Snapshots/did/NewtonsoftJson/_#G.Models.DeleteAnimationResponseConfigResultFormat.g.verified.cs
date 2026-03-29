//HintName: G.Models.DeleteAnimationResponseConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the file format of the animated video result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteAnimationResponseConfigResultFormat
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
    public static class DeleteAnimationResponseConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAnimationResponseConfigResultFormat value)
        {
            return value switch
            {
                DeleteAnimationResponseConfigResultFormat.Mov => "mov",
                DeleteAnimationResponseConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAnimationResponseConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => DeleteAnimationResponseConfigResultFormat.Mov,
                "mp4" => DeleteAnimationResponseConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}