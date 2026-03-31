//HintName: G.Models.CreateTalkStreamRequestConfigVariant1ResultFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    public enum CreateTalkStreamRequestConfigVariant1ResultFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkStreamRequestConfigVariant1ResultFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkStreamRequestConfigVariant1ResultFormat2 value)
        {
            return value switch
            {
                CreateTalkStreamRequestConfigVariant1ResultFormat2.Mov => "mov",
                CreateTalkStreamRequestConfigVariant1ResultFormat2.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkStreamRequestConfigVariant1ResultFormat2? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateTalkStreamRequestConfigVariant1ResultFormat2.Mov,
                "mp4" => CreateTalkStreamRequestConfigVariant1ResultFormat2.Mp4,
                _ => null,
            };
        }
    }
}