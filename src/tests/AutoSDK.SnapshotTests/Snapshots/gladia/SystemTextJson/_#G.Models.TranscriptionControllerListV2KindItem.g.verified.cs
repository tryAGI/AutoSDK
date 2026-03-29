//HintName: G.Models.TranscriptionControllerListV2KindItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionControllerListV2KindItem
    {
        /// <summary>
        /// 
        /// </summary>
        Live,
        /// <summary>
        /// 
        /// </summary>
        PreRecorded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionControllerListV2KindItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionControllerListV2KindItem value)
        {
            return value switch
            {
                TranscriptionControllerListV2KindItem.Live => "live",
                TranscriptionControllerListV2KindItem.PreRecorded => "pre-recorded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionControllerListV2KindItem? ToEnum(string value)
        {
            return value switch
            {
                "live" => TranscriptionControllerListV2KindItem.Live,
                "pre-recorded" => TranscriptionControllerListV2KindItem.PreRecorded,
                _ => null,
            };
        }
    }
}