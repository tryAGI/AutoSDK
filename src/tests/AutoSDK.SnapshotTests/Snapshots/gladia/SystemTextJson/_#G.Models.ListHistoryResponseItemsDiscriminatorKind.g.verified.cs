//HintName: G.Models.ListHistoryResponseItemsDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListHistoryResponseItemsDiscriminatorKind
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
    public static class ListHistoryResponseItemsDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListHistoryResponseItemsDiscriminatorKind value)
        {
            return value switch
            {
                ListHistoryResponseItemsDiscriminatorKind.Live => "live",
                ListHistoryResponseItemsDiscriminatorKind.PreRecorded => "pre-recorded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListHistoryResponseItemsDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "live" => ListHistoryResponseItemsDiscriminatorKind.Live,
                "pre-recorded" => ListHistoryResponseItemsDiscriminatorKind.PreRecorded,
                _ => null,
            };
        }
    }
}