//HintName: G.Models.CreateTalkStreamRequestConfigVariant1ResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkStreamRequestConfigVariant1ResultFormat
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
    public static class CreateTalkStreamRequestConfigVariant1ResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkStreamRequestConfigVariant1ResultFormat value)
        {
            return value switch
            {
                CreateTalkStreamRequestConfigVariant1ResultFormat.Mov => "mov",
                CreateTalkStreamRequestConfigVariant1ResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkStreamRequestConfigVariant1ResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateTalkStreamRequestConfigVariant1ResultFormat.Mov,
                "mp4" => CreateTalkStreamRequestConfigVariant1ResultFormat.Mp4,
                _ => null,
            };
        }
    }
}