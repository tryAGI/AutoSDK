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
        public int? Value1 { get; init; }
#else
        public int? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of nodes<br/>
        /// * `all` - send requests to all nodes and return points which present on all nodes
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReadConsistencyType? Value2 { get; init; }
#else
        public global::G.ReadConsistencyType? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadConsistency(int value) => new ReadConsistency((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(ReadConsistency @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ReadConsistency(int? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadConsistency(global::G.ReadConsistencyType value) => new ReadConsistency((global::G.ReadConsistencyType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReadConsistencyType?(ReadConsistency @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ReadConsistency(global::G.ReadConsistencyType? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadConsistency(
            int? value1,
            global::G.ReadConsistencyType? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? value1 = null,
            global::System.Func<global::G.ReadConsistencyType?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<int?>? value1 = null,
            global::System.Action<global::G.ReadConsistencyType?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(int),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReadConsistencyType?>.Default.Equals(Value2, other.Value2) 
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
