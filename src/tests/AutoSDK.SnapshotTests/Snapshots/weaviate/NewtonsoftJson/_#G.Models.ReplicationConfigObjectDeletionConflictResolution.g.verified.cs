//HintName: G.Models.ReplicationConfigObjectDeletionConflictResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Conflict resolution strategy for deleted objects
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReplicationConfigObjectDeletionConflictResolution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NoAutomatedResolution")]
        NoAutomatedResolution,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PermanentDeletion")]
        PermanentDeletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicationConfigObjectDeletionConflictResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicationConfigObjectDeletionConflictResolution value)
        {
            return value switch
            {
                ReplicationConfigObjectDeletionConflictResolution.NoAutomatedResolution => "NoAutomatedResolution",
                ReplicationConfigObjectDeletionConflictResolution.PermanentDeletion => "PermanentDeletion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicationConfigObjectDeletionConflictResolution? ToEnum(string value)
        {
            return value switch
            {
                "NoAutomatedResolution" => ReplicationConfigObjectDeletionConflictResolution.NoAutomatedResolution,
                "PermanentDeletion" => ReplicationConfigObjectDeletionConflictResolution.PermanentDeletion,
                _ => null,
            };
        }
    }
}