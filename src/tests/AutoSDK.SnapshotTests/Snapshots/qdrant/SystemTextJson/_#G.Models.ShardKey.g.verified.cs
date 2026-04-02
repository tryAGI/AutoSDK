//HintName: G.Models.ShardKey.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ShardKey : global::System.IEquatable<ShardKey>
    {
        /// <summary>
        /// Example: region_1
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ShardKeyVariant1 { get; init; }
#else
        public string? ShardKeyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShardKeyVariant1))]
#endif
        public bool IsShardKeyVariant1 => ShardKeyVariant1 != null;

        /// <summary>
        /// Example: 12
        /// </summary>
#if NET6_0_OR_GREATER
        public int? ShardKeyVariant2 { get; init; }
#else
        public int? ShardKeyVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShardKeyVariant2))]
#endif
        public bool IsShardKeyVariant2 => ShardKeyVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardKey(string value) => new ShardKey((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ShardKey @this) => @this.ShardKeyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ShardKey(string? value)
        {
            ShardKeyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardKey(int value) => new ShardKey((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(ShardKey @this) => @this.ShardKeyVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ShardKey(int? value)
        {
            ShardKeyVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ShardKey(
            string? shardKeyVariant1,
            int? shardKeyVariant2
            )
        {
            ShardKeyVariant1 = shardKeyVariant1;
            ShardKeyVariant2 = shardKeyVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ShardKeyVariant2 as object ??
            ShardKeyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ShardKeyVariant1?.ToString() ??
            ShardKeyVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShardKeyVariant1 || IsShardKeyVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? shardKeyVariant1 = null,
            global::System.Func<int?, TResult>? shardKeyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShardKeyVariant1 && shardKeyVariant1 != null)
            {
                return shardKeyVariant1(ShardKeyVariant1!);
            }
            else if (IsShardKeyVariant2 && shardKeyVariant2 != null)
            {
                return shardKeyVariant2(ShardKeyVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? shardKeyVariant1 = null,
            global::System.Action<int?>? shardKeyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShardKeyVariant1)
            {
                shardKeyVariant1?.Invoke(ShardKeyVariant1!);
            }
            else if (IsShardKeyVariant2)
            {
                shardKeyVariant2?.Invoke(ShardKeyVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ShardKeyVariant1,
                typeof(string),
                ShardKeyVariant2,
                typeof(int),
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
        public bool Equals(ShardKey other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ShardKeyVariant1, other.ShardKeyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(ShardKeyVariant2, other.ShardKeyVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ShardKey obj1, ShardKey obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShardKey>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShardKey obj1, ShardKey obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShardKey o && Equals(o);
        }
    }
}
