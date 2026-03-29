//HintName: G.Models.ReplicaState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the single shard within a replica set.
    /// </summary>
    public enum ReplicaState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        ActiveRead,
        /// <summary>
        /// 
        /// </summary>
        Dead,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Listener,
        /// <summary>
        /// 
        /// </summary>
        ManualRecovery,
        /// <summary>
        /// 
        /// </summary>
        Partial,
        /// <summary>
        /// 
        /// </summary>
        PartialSnapshot,
        /// <summary>
        /// 
        /// </summary>
        Recovery,
        /// <summary>
        /// 
        /// </summary>
        Resharding,
        /// <summary>
        /// 
        /// </summary>
        ReshardingScaleDown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicaStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicaState value)
        {
            return value switch
            {
                ReplicaState.Active => "Active",
                ReplicaState.ActiveRead => "ActiveRead",
                ReplicaState.Dead => "Dead",
                ReplicaState.Initializing => "Initializing",
                ReplicaState.Listener => "Listener",
                ReplicaState.ManualRecovery => "ManualRecovery",
                ReplicaState.Partial => "Partial",
                ReplicaState.PartialSnapshot => "PartialSnapshot",
                ReplicaState.Recovery => "Recovery",
                ReplicaState.Resharding => "Resharding",
                ReplicaState.ReshardingScaleDown => "ReshardingScaleDown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicaState? ToEnum(string value)
        {
            return value switch
            {
                "Active" => ReplicaState.Active,
                "ActiveRead" => ReplicaState.ActiveRead,
                "Dead" => ReplicaState.Dead,
                "Initializing" => ReplicaState.Initializing,
                "Listener" => ReplicaState.Listener,
                "ManualRecovery" => ReplicaState.ManualRecovery,
                "Partial" => ReplicaState.Partial,
                "PartialSnapshot" => ReplicaState.PartialSnapshot,
                "Recovery" => ReplicaState.Recovery,
                "Resharding" => ReplicaState.Resharding,
                "ReshardingScaleDown" => ReplicaState.ReshardingScaleDown,
                _ => null,
            };
        }
    }
}