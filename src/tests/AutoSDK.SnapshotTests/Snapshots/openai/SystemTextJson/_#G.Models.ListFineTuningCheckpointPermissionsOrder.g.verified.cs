//HintName: G.Models.ListFineTuningCheckpointPermissionsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListFineTuningCheckpointPermissionsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFineTuningCheckpointPermissionsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFineTuningCheckpointPermissionsOrder value)
        {
            return value switch
            {
                ListFineTuningCheckpointPermissionsOrder.Ascending => "ascending",
                ListFineTuningCheckpointPermissionsOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFineTuningCheckpointPermissionsOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListFineTuningCheckpointPermissionsOrder.Ascending,
                "descending" => ListFineTuningCheckpointPermissionsOrder.Descending,
                _ => null,
            };
        }
    }
}