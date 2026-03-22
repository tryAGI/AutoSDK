//HintName: G.Models.DiffEntryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: added
    /// </summary>
    public enum DiffEntryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Added,
        /// <summary>
        /// 
        /// </summary>
        Changed,
        /// <summary>
        /// 
        /// </summary>
        Copied,
        /// <summary>
        /// 
        /// </summary>
        Modified,
        /// <summary>
        /// 
        /// </summary>
        Removed,
        /// <summary>
        /// 
        /// </summary>
        Renamed,
        /// <summary>
        /// 
        /// </summary>
        Unchanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiffEntryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiffEntryStatus value)
        {
            return value switch
            {
                DiffEntryStatus.Added => "added",
                DiffEntryStatus.Changed => "changed",
                DiffEntryStatus.Copied => "copied",
                DiffEntryStatus.Modified => "modified",
                DiffEntryStatus.Removed => "removed",
                DiffEntryStatus.Renamed => "renamed",
                DiffEntryStatus.Unchanged => "unchanged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiffEntryStatus? ToEnum(string value)
        {
            return value switch
            {
                "added" => DiffEntryStatus.Added,
                "changed" => DiffEntryStatus.Changed,
                "copied" => DiffEntryStatus.Copied,
                "modified" => DiffEntryStatus.Modified,
                "removed" => DiffEntryStatus.Removed,
                "renamed" => DiffEntryStatus.Renamed,
                "unchanged" => DiffEntryStatus.Unchanged,
                _ => null,
            };
        }
    }
}