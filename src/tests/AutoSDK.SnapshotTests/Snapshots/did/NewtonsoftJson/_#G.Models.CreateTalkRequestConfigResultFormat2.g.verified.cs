//HintName: G.Models.CreateTalkRequestConfigResultFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkRequestConfigResultFormat2
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
    public static class CreateTalkRequestConfigResultFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestConfigResultFormat2 value)
        {
            return value switch
            {
                CreateTalkRequestConfigResultFormat2.Mov => "mov",
                CreateTalkRequestConfigResultFormat2.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestConfigResultFormat2? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateTalkRequestConfigResultFormat2.Mov,
                "mp4" => CreateTalkRequestConfigResultFormat2.Mp4,
                _ => null,
            };
        }
    }
}