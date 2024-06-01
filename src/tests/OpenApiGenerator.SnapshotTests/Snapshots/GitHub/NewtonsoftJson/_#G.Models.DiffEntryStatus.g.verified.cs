//HintName: G.Models.DiffEntryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: added
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiffEntryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="added")]
        Added,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removed")]
        Removed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modified")]
        Modified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="renamed")]
        Renamed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="copied")]
        Copied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="changed")]
        Changed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unchanged")]
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
                DiffEntryStatus.Removed => "removed",
                DiffEntryStatus.Modified => "modified",
                DiffEntryStatus.Renamed => "renamed",
                DiffEntryStatus.Copied => "copied",
                DiffEntryStatus.Changed => "changed",
                DiffEntryStatus.Unchanged => "unchanged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiffEntryStatus ToEnum(string value)
        {
            return value switch
            {
                "added" => DiffEntryStatus.Added,
                "removed" => DiffEntryStatus.Removed,
                "modified" => DiffEntryStatus.Modified,
                "renamed" => DiffEntryStatus.Renamed,
                "copied" => DiffEntryStatus.Copied,
                "changed" => DiffEntryStatus.Changed,
                "unchanged" => DiffEntryStatus.Unchanged,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}