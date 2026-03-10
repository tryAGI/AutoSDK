//HintName: G.Models.ListDubsDubbingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// What state the dub is currently in.
    /// </summary>
    public enum ListDubsDubbingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        Dubbed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsDubbingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsDubbingStatus value)
        {
            return value switch
            {
                ListDubsDubbingStatus.Dubbing => "dubbing",
                ListDubsDubbingStatus.Dubbed => "dubbed",
                ListDubsDubbingStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsDubbingStatus? ToEnum(string value)
        {
            return value switch
            {
                "dubbing" => ListDubsDubbingStatus.Dubbing,
                "dubbed" => ListDubsDubbingStatus.Dubbed,
                "failed" => ListDubsDubbingStatus.Failed,
                _ => null,
            };
        }
    }
}