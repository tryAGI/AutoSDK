//HintName: G.Models.CreateClipStreamRequestConfigResultFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipStreamRequestConfigResultFormat2
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
    public static class CreateClipStreamRequestConfigResultFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestConfigResultFormat2 value)
        {
            return value switch
            {
                CreateClipStreamRequestConfigResultFormat2.Mov => "mov",
                CreateClipStreamRequestConfigResultFormat2.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestConfigResultFormat2? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateClipStreamRequestConfigResultFormat2.Mov,
                "mp4" => CreateClipStreamRequestConfigResultFormat2.Mp4,
                _ => null,
            };
        }
    }
}