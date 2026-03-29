//HintName: G.Models.SnapshotPriority.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines source of truth for snapshot recovery:<br/>
    /// `NoSync` means - restore snapshot without *any* additional synchronization. `Snapshot` means - prefer snapshot data over the current state. `Replica` means - prefer existing data over the snapshot.
    /// </summary>
    public enum SnapshotPriority
    {
        /// <summary>
        /// 
        /// </summary>
        NoSync,
        /// <summary>
        /// 
        /// </summary>
        Replica,
        /// <summary>
        /// 
        /// </summary>
        Snapshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnapshotPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnapshotPriority value)
        {
            return value switch
            {
                SnapshotPriority.NoSync => "no_sync",
                SnapshotPriority.Replica => "replica",
                SnapshotPriority.Snapshot => "snapshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnapshotPriority? ToEnum(string value)
        {
            return value switch
            {
                "no_sync" => SnapshotPriority.NoSync,
                "replica" => SnapshotPriority.Replica,
                "snapshot" => SnapshotPriority.Snapshot,
                _ => null,
            };
        }
    }
}