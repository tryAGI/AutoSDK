//HintName: G.Models.ReadConsistency.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Read consistency parameter<br/>
    /// Defines how many replicas should be queried to get the result<br/>
    /// * `N` - send N random request and return points, which present on all of them<br/>
    /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
    /// * `quorum` - send requests to all nodes and return points which present on majority of them<br/>
    /// * `all` - send requests to all nodes and return points which present on all of them<br/>
    /// Default value is `Factor(1)`
    /// </summary>
    public readonly partial struct ReadConsistency : global::System.IEquatable<ReadConsistency>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? ReadConsistencyVariant1 { get; init; }
#else
        public int? ReadConsistencyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReadConsistencyVariant1))]
#endif
        public bool IsReadConsistencyVariant1 => ReadConsistencyVariant1 != null;

        /// <summary>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of nodes<br/>
        /// * `all` - send requests to all nodes and return points which present on all nodes
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReadConsistencyType? Type { get; init; }
#else
        public global::G.ReadConsistencyType? Type { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Type))]
#endif
        public bool IsType => Type != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadConsistency(int value) => new ReadConsistency((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(ReadConsistency @this) => @this.ReadConsistencyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ReadConsistency(int? value)
        {
            ReadConsistencyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadConsistency(global::G.ReadConsistencyType value) => new ReadConsistency((global::G.ReadConsistencyType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReadConsistencyType?(ReadConsistency @this) => @this.Type;

        /// <summary>
        /// 
        /// </summary>
        public ReadConsistency(global::G.ReadConsistencyType? value)
        {
            Type = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadConsistency(
            int? readConsistencyVariant1,
            global::G.ReadConsistencyType? type
            )
        {
            ReadConsistencyVariant1 = readConsistencyVariant1;
            Type = type;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Type as object ??
            ReadConsistencyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReadConsistencyVariant1?.ToString() ??
            Type?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReadConsistencyVariant1 || IsType;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? readConsistencyVariant1 = null,
            global::System.Func<global::G.ReadConsistencyType?, TResult>? type = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReadConsistencyVariant1 && readConsistencyVariant1 != null)
            {
                return readConsistencyVariant1(ReadConsistencyVariant1!);
            }
            else if (IsType && type != null)
            {
                return type(Type!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<int?>? readConsistencyVariant1 = null,
            global::System.Action<global::G.ReadConsistencyType?>? type = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReadConsistencyVariant1)
            {
                readConsistencyVariant1?.Invoke(ReadConsistencyVariant1!);
            }
            else if (IsType)
            {
                type?.Invoke(Type!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReadConsistencyVariant1,
                typeof(int),
                Type,
                typeof(global::G.ReadConsistencyType),
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
        public bool Equals(ReadConsistency other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(ReadConsistencyVariant1, other.ReadConsistencyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReadConsistencyType?>.Default.Equals(Type, other.Type) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReadConsistency obj1, ReadConsistency obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReadConsistency>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReadConsistency obj1, ReadConsistency obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReadConsistency o && Equals(o);
        }
    }
}
