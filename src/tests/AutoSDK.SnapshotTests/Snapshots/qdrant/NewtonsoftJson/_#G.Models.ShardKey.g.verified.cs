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
        /// 
        /// </summary>
        public bool TryPickShardKeyVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ShardKeyVariant1;
            return IsShardKeyVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickShardKeyVariant1() => ShardKeyVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShardKeyVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Example: 12
        /// </summary>
#if NET6_0_OR_GREATER
        public long? ShardKeyVariant2 { get; init; }
#else
        public long? ShardKeyVariant2 { get; }
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
        public bool TryPickShardKeyVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out long? value)
        {
            value = ShardKeyVariant2;
            return IsShardKeyVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public long PickShardKeyVariant2() => ShardKeyVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShardKeyVariant2' but the value was {ToString()}.");
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
        public static ShardKey FromShardKeyVariant1(string? value) => new ShardKey(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardKey(long value) => new ShardKey((long?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator long?(ShardKey @this) => @this.ShardKeyVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ShardKey(long? value)
        {
            ShardKeyVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ShardKey FromShardKeyVariant2(long? value) => new ShardKey(value);

        /// <summary>
        /// 
        /// </summary>
        public ShardKey(
            string? shardKeyVariant1,
            long? shardKeyVariant2
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
            global::System.Func<string, TResult>? shardKeyVariant1 = null,
            global::System.Func<long?, TResult>? shardKeyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ShardKeyVariant1 is { } __value0 && shardKeyVariant1 != null)
            {
                return shardKeyVariant1(__value0);
            }
            else if (ShardKeyVariant2 is { } __value1 && shardKeyVariant2 != null)
            {
                return shardKeyVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? shardKeyVariant1 = null,

            global::System.Action<long?>? shardKeyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ShardKeyVariant1 is { } __value0)
            {
                shardKeyVariant1?.Invoke(__value0);
            }
            else if (ShardKeyVariant2 is { } __value1)
            {
                shardKeyVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? shardKeyVariant1 = null,
            global::System.Action<long?>? shardKeyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ShardKeyVariant1 is { } __value0)
            {
                shardKeyVariant1?.Invoke(__value0);
            }
            else if (ShardKeyVariant2 is { } __value1)
            {
                shardKeyVariant2?.Invoke(__value1);
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
                typeof(long),
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
                global::System.Collections.Generic.EqualityComparer<long?>.Default.Equals(ShardKeyVariant2, other.ShardKeyVariant2) 
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
