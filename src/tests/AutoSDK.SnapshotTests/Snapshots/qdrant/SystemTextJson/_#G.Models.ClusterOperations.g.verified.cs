//HintName: G.Models.ClusterOperations.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ClusterOperations : global::System.IEquatable<ClusterOperations>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MoveShardOperation? MoveShardOperation { get; init; }
#else
        public global::G.MoveShardOperation? MoveShardOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MoveShardOperation))]
#endif
        public bool IsMoveShardOperation => MoveShardOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReplicateShardOperation? ReplicateShardOperation { get; init; }
#else
        public global::G.ReplicateShardOperation? ReplicateShardOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReplicateShardOperation))]
#endif
        public bool IsReplicateShardOperation => ReplicateShardOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AbortTransferOperation? AbortTransferOperation { get; init; }
#else
        public global::G.AbortTransferOperation? AbortTransferOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AbortTransferOperation))]
#endif
        public bool IsAbortTransferOperation => AbortTransferOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DropReplicaOperation? DropReplicaOperation { get; init; }
#else
        public global::G.DropReplicaOperation? DropReplicaOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DropReplicaOperation))]
#endif
        public bool IsDropReplicaOperation => DropReplicaOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateShardingKeyOperation? CreateShardingKeyOperation { get; init; }
#else
        public global::G.CreateShardingKeyOperation? CreateShardingKeyOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateShardingKeyOperation))]
#endif
        public bool IsCreateShardingKeyOperation => CreateShardingKeyOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DropShardingKeyOperation? DropShardingKeyOperation { get; init; }
#else
        public global::G.DropShardingKeyOperation? DropShardingKeyOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DropShardingKeyOperation))]
#endif
        public bool IsDropShardingKeyOperation => DropShardingKeyOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RestartTransferOperation? RestartTransferOperation { get; init; }
#else
        public global::G.RestartTransferOperation? RestartTransferOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RestartTransferOperation))]
#endif
        public bool IsRestartTransferOperation => RestartTransferOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StartReshardingOperation? StartReshardingOperation { get; init; }
#else
        public global::G.StartReshardingOperation? StartReshardingOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StartReshardingOperation))]
#endif
        public bool IsStartReshardingOperation => StartReshardingOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AbortReshardingOperation? AbortReshardingOperation { get; init; }
#else
        public global::G.AbortReshardingOperation? AbortReshardingOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AbortReshardingOperation))]
#endif
        public bool IsAbortReshardingOperation => AbortReshardingOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReplicatePointsOperation? ReplicatePointsOperation { get; init; }
#else
        public global::G.ReplicatePointsOperation? ReplicatePointsOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReplicatePointsOperation))]
#endif
        public bool IsReplicatePointsOperation => ReplicatePointsOperation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.MoveShardOperation value) => new ClusterOperations((global::G.MoveShardOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MoveShardOperation?(ClusterOperations @this) => @this.MoveShardOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.MoveShardOperation? value)
        {
            MoveShardOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.ReplicateShardOperation value) => new ClusterOperations((global::G.ReplicateShardOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReplicateShardOperation?(ClusterOperations @this) => @this.ReplicateShardOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.ReplicateShardOperation? value)
        {
            ReplicateShardOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.AbortTransferOperation value) => new ClusterOperations((global::G.AbortTransferOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AbortTransferOperation?(ClusterOperations @this) => @this.AbortTransferOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.AbortTransferOperation? value)
        {
            AbortTransferOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.DropReplicaOperation value) => new ClusterOperations((global::G.DropReplicaOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DropReplicaOperation?(ClusterOperations @this) => @this.DropReplicaOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.DropReplicaOperation? value)
        {
            DropReplicaOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.CreateShardingKeyOperation value) => new ClusterOperations((global::G.CreateShardingKeyOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateShardingKeyOperation?(ClusterOperations @this) => @this.CreateShardingKeyOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.CreateShardingKeyOperation? value)
        {
            CreateShardingKeyOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.DropShardingKeyOperation value) => new ClusterOperations((global::G.DropShardingKeyOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DropShardingKeyOperation?(ClusterOperations @this) => @this.DropShardingKeyOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.DropShardingKeyOperation? value)
        {
            DropShardingKeyOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.RestartTransferOperation value) => new ClusterOperations((global::G.RestartTransferOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RestartTransferOperation?(ClusterOperations @this) => @this.RestartTransferOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.RestartTransferOperation? value)
        {
            RestartTransferOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.StartReshardingOperation value) => new ClusterOperations((global::G.StartReshardingOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StartReshardingOperation?(ClusterOperations @this) => @this.StartReshardingOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.StartReshardingOperation? value)
        {
            StartReshardingOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.AbortReshardingOperation value) => new ClusterOperations((global::G.AbortReshardingOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AbortReshardingOperation?(ClusterOperations @this) => @this.AbortReshardingOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.AbortReshardingOperation? value)
        {
            AbortReshardingOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterOperations(global::G.ReplicatePointsOperation value) => new ClusterOperations((global::G.ReplicatePointsOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReplicatePointsOperation?(ClusterOperations @this) => @this.ReplicatePointsOperation;

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(global::G.ReplicatePointsOperation? value)
        {
            ReplicatePointsOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ClusterOperations(
            global::G.MoveShardOperation? moveShardOperation,
            global::G.ReplicateShardOperation? replicateShardOperation,
            global::G.AbortTransferOperation? abortTransferOperation,
            global::G.DropReplicaOperation? dropReplicaOperation,
            global::G.CreateShardingKeyOperation? createShardingKeyOperation,
            global::G.DropShardingKeyOperation? dropShardingKeyOperation,
            global::G.RestartTransferOperation? restartTransferOperation,
            global::G.StartReshardingOperation? startReshardingOperation,
            global::G.AbortReshardingOperation? abortReshardingOperation,
            global::G.ReplicatePointsOperation? replicatePointsOperation
            )
        {
            MoveShardOperation = moveShardOperation;
            ReplicateShardOperation = replicateShardOperation;
            AbortTransferOperation = abortTransferOperation;
            DropReplicaOperation = dropReplicaOperation;
            CreateShardingKeyOperation = createShardingKeyOperation;
            DropShardingKeyOperation = dropShardingKeyOperation;
            RestartTransferOperation = restartTransferOperation;
            StartReshardingOperation = startReshardingOperation;
            AbortReshardingOperation = abortReshardingOperation;
            ReplicatePointsOperation = replicatePointsOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReplicatePointsOperation as object ??
            AbortReshardingOperation as object ??
            StartReshardingOperation as object ??
            RestartTransferOperation as object ??
            DropShardingKeyOperation as object ??
            CreateShardingKeyOperation as object ??
            DropReplicaOperation as object ??
            AbortTransferOperation as object ??
            ReplicateShardOperation as object ??
            MoveShardOperation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MoveShardOperation?.ToString() ??
            ReplicateShardOperation?.ToString() ??
            AbortTransferOperation?.ToString() ??
            DropReplicaOperation?.ToString() ??
            CreateShardingKeyOperation?.ToString() ??
            DropShardingKeyOperation?.ToString() ??
            RestartTransferOperation?.ToString() ??
            StartReshardingOperation?.ToString() ??
            AbortReshardingOperation?.ToString() ??
            ReplicatePointsOperation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMoveShardOperation || IsReplicateShardOperation || IsAbortTransferOperation || IsDropReplicaOperation || IsCreateShardingKeyOperation || IsDropShardingKeyOperation || IsRestartTransferOperation || IsStartReshardingOperation || IsAbortReshardingOperation || IsReplicatePointsOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MoveShardOperation?, TResult>? moveShardOperation = null,
            global::System.Func<global::G.ReplicateShardOperation?, TResult>? replicateShardOperation = null,
            global::System.Func<global::G.AbortTransferOperation?, TResult>? abortTransferOperation = null,
            global::System.Func<global::G.DropReplicaOperation?, TResult>? dropReplicaOperation = null,
            global::System.Func<global::G.CreateShardingKeyOperation?, TResult>? createShardingKeyOperation = null,
            global::System.Func<global::G.DropShardingKeyOperation?, TResult>? dropShardingKeyOperation = null,
            global::System.Func<global::G.RestartTransferOperation?, TResult>? restartTransferOperation = null,
            global::System.Func<global::G.StartReshardingOperation?, TResult>? startReshardingOperation = null,
            global::System.Func<global::G.AbortReshardingOperation?, TResult>? abortReshardingOperation = null,
            global::System.Func<global::G.ReplicatePointsOperation?, TResult>? replicatePointsOperation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMoveShardOperation && moveShardOperation != null)
            {
                return moveShardOperation(MoveShardOperation!);
            }
            else if (IsReplicateShardOperation && replicateShardOperation != null)
            {
                return replicateShardOperation(ReplicateShardOperation!);
            }
            else if (IsAbortTransferOperation && abortTransferOperation != null)
            {
                return abortTransferOperation(AbortTransferOperation!);
            }
            else if (IsDropReplicaOperation && dropReplicaOperation != null)
            {
                return dropReplicaOperation(DropReplicaOperation!);
            }
            else if (IsCreateShardingKeyOperation && createShardingKeyOperation != null)
            {
                return createShardingKeyOperation(CreateShardingKeyOperation!);
            }
            else if (IsDropShardingKeyOperation && dropShardingKeyOperation != null)
            {
                return dropShardingKeyOperation(DropShardingKeyOperation!);
            }
            else if (IsRestartTransferOperation && restartTransferOperation != null)
            {
                return restartTransferOperation(RestartTransferOperation!);
            }
            else if (IsStartReshardingOperation && startReshardingOperation != null)
            {
                return startReshardingOperation(StartReshardingOperation!);
            }
            else if (IsAbortReshardingOperation && abortReshardingOperation != null)
            {
                return abortReshardingOperation(AbortReshardingOperation!);
            }
            else if (IsReplicatePointsOperation && replicatePointsOperation != null)
            {
                return replicatePointsOperation(ReplicatePointsOperation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MoveShardOperation?>? moveShardOperation = null,
            global::System.Action<global::G.ReplicateShardOperation?>? replicateShardOperation = null,
            global::System.Action<global::G.AbortTransferOperation?>? abortTransferOperation = null,
            global::System.Action<global::G.DropReplicaOperation?>? dropReplicaOperation = null,
            global::System.Action<global::G.CreateShardingKeyOperation?>? createShardingKeyOperation = null,
            global::System.Action<global::G.DropShardingKeyOperation?>? dropShardingKeyOperation = null,
            global::System.Action<global::G.RestartTransferOperation?>? restartTransferOperation = null,
            global::System.Action<global::G.StartReshardingOperation?>? startReshardingOperation = null,
            global::System.Action<global::G.AbortReshardingOperation?>? abortReshardingOperation = null,
            global::System.Action<global::G.ReplicatePointsOperation?>? replicatePointsOperation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMoveShardOperation)
            {
                moveShardOperation?.Invoke(MoveShardOperation!);
            }
            else if (IsReplicateShardOperation)
            {
                replicateShardOperation?.Invoke(ReplicateShardOperation!);
            }
            else if (IsAbortTransferOperation)
            {
                abortTransferOperation?.Invoke(AbortTransferOperation!);
            }
            else if (IsDropReplicaOperation)
            {
                dropReplicaOperation?.Invoke(DropReplicaOperation!);
            }
            else if (IsCreateShardingKeyOperation)
            {
                createShardingKeyOperation?.Invoke(CreateShardingKeyOperation!);
            }
            else if (IsDropShardingKeyOperation)
            {
                dropShardingKeyOperation?.Invoke(DropShardingKeyOperation!);
            }
            else if (IsRestartTransferOperation)
            {
                restartTransferOperation?.Invoke(RestartTransferOperation!);
            }
            else if (IsStartReshardingOperation)
            {
                startReshardingOperation?.Invoke(StartReshardingOperation!);
            }
            else if (IsAbortReshardingOperation)
            {
                abortReshardingOperation?.Invoke(AbortReshardingOperation!);
            }
            else if (IsReplicatePointsOperation)
            {
                replicatePointsOperation?.Invoke(ReplicatePointsOperation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MoveShardOperation,
                typeof(global::G.MoveShardOperation),
                ReplicateShardOperation,
                typeof(global::G.ReplicateShardOperation),
                AbortTransferOperation,
                typeof(global::G.AbortTransferOperation),
                DropReplicaOperation,
                typeof(global::G.DropReplicaOperation),
                CreateShardingKeyOperation,
                typeof(global::G.CreateShardingKeyOperation),
                DropShardingKeyOperation,
                typeof(global::G.DropShardingKeyOperation),
                RestartTransferOperation,
                typeof(global::G.RestartTransferOperation),
                StartReshardingOperation,
                typeof(global::G.StartReshardingOperation),
                AbortReshardingOperation,
                typeof(global::G.AbortReshardingOperation),
                ReplicatePointsOperation,
                typeof(global::G.ReplicatePointsOperation),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ClusterOperations other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MoveShardOperation?>.Default.Equals(MoveShardOperation, other.MoveShardOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReplicateShardOperation?>.Default.Equals(ReplicateShardOperation, other.ReplicateShardOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AbortTransferOperation?>.Default.Equals(AbortTransferOperation, other.AbortTransferOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DropReplicaOperation?>.Default.Equals(DropReplicaOperation, other.DropReplicaOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateShardingKeyOperation?>.Default.Equals(CreateShardingKeyOperation, other.CreateShardingKeyOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DropShardingKeyOperation?>.Default.Equals(DropShardingKeyOperation, other.DropShardingKeyOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RestartTransferOperation?>.Default.Equals(RestartTransferOperation, other.RestartTransferOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StartReshardingOperation?>.Default.Equals(StartReshardingOperation, other.StartReshardingOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AbortReshardingOperation?>.Default.Equals(AbortReshardingOperation, other.AbortReshardingOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReplicatePointsOperation?>.Default.Equals(ReplicatePointsOperation, other.ReplicatePointsOperation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ClusterOperations obj1, ClusterOperations obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ClusterOperations>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ClusterOperations obj1, ClusterOperations obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClusterOperations o && Equals(o);
        }
    }
}
