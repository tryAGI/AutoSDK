//HintName: G.Models.Ann.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to create an approximate nearest neighbor index for the attribute. Can be a boolean or a detailed configuration object.
    /// </summary>
    public readonly partial struct Ann : global::System.IEquatable<Ann>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? Value1 { get; init; }
#else
        public bool? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Configuration options for ANN (Approximate Nearest Neighbor) indexing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnnConfig? Value2 { get; init; }
#else
        public global::G.AnnConfig? Value2 { get; }
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
        public static implicit operator Ann(bool value) => new Ann((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(Ann @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Ann(bool? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Ann(global::G.AnnConfig value) => new Ann((global::G.AnnConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnnConfig?(Ann @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Ann(global::G.AnnConfig? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Ann(
            bool? value1,
            global::G.AnnConfig? value2
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
            Value1?.ToString().ToLowerInvariant() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? value1 = null,
            global::System.Func<global::G.AnnConfig?, TResult>? value2 = null,
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
            global::System.Action<bool?>? value1 = null,
            global::System.Action<global::G.AnnConfig?>? value2 = null,
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
                typeof(bool),
                Value2,
                typeof(global::G.AnnConfig),
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
        public bool Equals(Ann other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnnConfig?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Ann obj1, Ann obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Ann>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Ann obj1, Ann obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Ann o && Equals(o);
        }
    }
}
