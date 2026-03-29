//HintName: G.Models.CreateAnimationRequestConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the file format of the animated video result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAnimationRequestConfigResultFormat
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
    public static class CreateAnimationRequestConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnimationRequestConfigResultFormat value)
        {
            return value switch
            {
                CreateAnimationRequestConfigResultFormat.Mov => "mov",
                CreateAnimationRequestConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnimationRequestConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateAnimationRequestConfigResultFormat.Mov,
                "mp4" => CreateAnimationRequestConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}