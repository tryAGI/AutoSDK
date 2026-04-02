//HintName: G.Models.ShardSnapshotLocation.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ShardSnapshotLocation : global::System.IEquatable<ShardSnapshotLocation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ShardSnapshotLocationVariant1 { get; init; }
#else
        public string? ShardSnapshotLocationVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShardSnapshotLocationVariant1))]
#endif
        public bool IsShardSnapshotLocationVariant1 => ShardSnapshotLocationVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ShardSnapshotLocationVariant2 { get; init; }
#else
        public string? ShardSnapshotLocationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShardSnapshotLocationVariant2))]
#endif
        public bool IsShardSnapshotLocationVariant2 => ShardSnapshotLocationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardSnapshotLocation(string value) => new ShardSnapshotLocation((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ShardSnapshotLocation @this) => @this.ShardSnapshotLocationVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ShardSnapshotLocation(string? value)
        {
            ShardSnapshotLocationVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ShardSnapshotLocation(
            string? shardSnapshotLocationVariant1,
            string? shardSnapshotLocationVariant2
            )
        {
            ShardSnapshotLocationVariant1 = shardSnapshotLocationVariant1;
            ShardSnapshotLocationVariant2 = shardSnapshotLocationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ShardSnapshotLocationVariant2 as object ??
            ShardSnapshotLocationVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ShardSnapshotLocationVariant1?.ToString() ??
            ShardSnapshotLocationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShardSnapshotLocationVariant1 || IsShardSnapshotLocationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? shardSnapshotLocationVariant1 = null,
            global::System.Func<string?, TResult>? shardSnapshotLocationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShardSnapshotLocationVariant1 && shardSnapshotLocationVariant1 != null)
            {
                return shardSnapshotLocationVariant1(ShardSnapshotLocationVariant1!);
            }
            else if (IsShardSnapshotLocationVariant2 && shardSnapshotLocationVariant2 != null)
            {
                return shardSnapshotLocationVariant2(ShardSnapshotLocationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? shardSnapshotLocationVariant1 = null,
            global::System.Action<string?>? shardSnapshotLocationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShardSnapshotLocationVariant1)
            {
                shardSnapshotLocationVariant1?.Invoke(ShardSnapshotLocationVariant1!);
            }
            else if (IsShardSnapshotLocationVariant2)
            {
                shardSnapshotLocationVariant2?.Invoke(ShardSnapshotLocationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ShardSnapshotLocationVariant1,
                typeof(string),
                ShardSnapshotLocationVariant2,
                typeof(string),
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
        public bool Equals(ShardSnapshotLocation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ShardSnapshotLocationVariant1, other.ShardSnapshotLocationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ShardSnapshotLocationVariant2, other.ShardSnapshotLocationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ShardSnapshotLocation obj1, ShardSnapshotLocation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShardSnapshotLocation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShardSnapshotLocation obj1, ShardSnapshotLocation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShardSnapshotLocation o && Equals(o);
        }
    }
}
