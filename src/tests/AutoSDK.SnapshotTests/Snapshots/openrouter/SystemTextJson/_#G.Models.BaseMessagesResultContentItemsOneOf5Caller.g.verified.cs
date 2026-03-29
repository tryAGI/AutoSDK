//HintName: G.Models.BaseMessagesResultContentItemsOneOf5Caller.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf5Caller : global::System.IEquatable<BaseMessagesResultContentItemsOneOf5Caller>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf5Caller0? BaseMessagesResultContentItemsOneOf5Caller0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf5Caller0? BaseMessagesResultContentItemsOneOf5Caller0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf5Caller0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf5Caller0 => BaseMessagesResultContentItemsOneOf5Caller0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf5Caller1? BaseMessagesResultContentItemsOneOf5Caller1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf5Caller1? BaseMessagesResultContentItemsOneOf5Caller1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf5Caller1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf5Caller1 => BaseMessagesResultContentItemsOneOf5Caller1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf5Caller2? BaseMessagesResultContentItemsOneOf5Caller2 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf5Caller2? BaseMessagesResultContentItemsOneOf5Caller2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf5Caller2))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf5Caller2 => BaseMessagesResultContentItemsOneOf5Caller2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf5Caller(global::G.BaseMessagesResultContentItemsOneOf5Caller0 value) => new BaseMessagesResultContentItemsOneOf5Caller((global::G.BaseMessagesResultContentItemsOneOf5Caller0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf5Caller0?(BaseMessagesResultContentItemsOneOf5Caller @this) => @this.BaseMessagesResultContentItemsOneOf5Caller0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Caller(global::G.BaseMessagesResultContentItemsOneOf5Caller0? value)
        {
            BaseMessagesResultContentItemsOneOf5Caller0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf5Caller(global::G.BaseMessagesResultContentItemsOneOf5Caller1 value) => new BaseMessagesResultContentItemsOneOf5Caller((global::G.BaseMessagesResultContentItemsOneOf5Caller1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf5Caller1?(BaseMessagesResultContentItemsOneOf5Caller @this) => @this.BaseMessagesResultContentItemsOneOf5Caller1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Caller(global::G.BaseMessagesResultContentItemsOneOf5Caller1? value)
        {
            BaseMessagesResultContentItemsOneOf5Caller1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf5Caller(global::G.BaseMessagesResultContentItemsOneOf5Caller2 value) => new BaseMessagesResultContentItemsOneOf5Caller((global::G.BaseMessagesResultContentItemsOneOf5Caller2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf5Caller2?(BaseMessagesResultContentItemsOneOf5Caller @this) => @this.BaseMessagesResultContentItemsOneOf5Caller2;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Caller(global::G.BaseMessagesResultContentItemsOneOf5Caller2? value)
        {
            BaseMessagesResultContentItemsOneOf5Caller2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Caller(
            global::G.BaseMessagesResultContentItemsOneOf5Caller0? baseMessagesResultContentItemsOneOf5Caller0,
            global::G.BaseMessagesResultContentItemsOneOf5Caller1? baseMessagesResultContentItemsOneOf5Caller1,
            global::G.BaseMessagesResultContentItemsOneOf5Caller2? baseMessagesResultContentItemsOneOf5Caller2
            )
        {
            BaseMessagesResultContentItemsOneOf5Caller0 = baseMessagesResultContentItemsOneOf5Caller0;
            BaseMessagesResultContentItemsOneOf5Caller1 = baseMessagesResultContentItemsOneOf5Caller1;
            BaseMessagesResultContentItemsOneOf5Caller2 = baseMessagesResultContentItemsOneOf5Caller2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf5Caller2 as object ??
            BaseMessagesResultContentItemsOneOf5Caller1 as object ??
            BaseMessagesResultContentItemsOneOf5Caller0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf5Caller0?.ToString() ??
            BaseMessagesResultContentItemsOneOf5Caller1?.ToString() ??
            BaseMessagesResultContentItemsOneOf5Caller2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf5Caller0 && !IsBaseMessagesResultContentItemsOneOf5Caller1 && !IsBaseMessagesResultContentItemsOneOf5Caller2 || !IsBaseMessagesResultContentItemsOneOf5Caller0 && IsBaseMessagesResultContentItemsOneOf5Caller1 && !IsBaseMessagesResultContentItemsOneOf5Caller2 || !IsBaseMessagesResultContentItemsOneOf5Caller0 && !IsBaseMessagesResultContentItemsOneOf5Caller1 && IsBaseMessagesResultContentItemsOneOf5Caller2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf5Caller0?, TResult>? baseMessagesResultContentItemsOneOf5Caller0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf5Caller1?, TResult>? baseMessagesResultContentItemsOneOf5Caller1 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf5Caller2?, TResult>? baseMessagesResultContentItemsOneOf5Caller2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf5Caller0 && baseMessagesResultContentItemsOneOf5Caller0 != null)
            {
                return baseMessagesResultContentItemsOneOf5Caller0(BaseMessagesResultContentItemsOneOf5Caller0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf5Caller1 && baseMessagesResultContentItemsOneOf5Caller1 != null)
            {
                return baseMessagesResultContentItemsOneOf5Caller1(BaseMessagesResultContentItemsOneOf5Caller1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf5Caller2 && baseMessagesResultContentItemsOneOf5Caller2 != null)
            {
                return baseMessagesResultContentItemsOneOf5Caller2(BaseMessagesResultContentItemsOneOf5Caller2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf5Caller0?>? baseMessagesResultContentItemsOneOf5Caller0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf5Caller1?>? baseMessagesResultContentItemsOneOf5Caller1 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf5Caller2?>? baseMessagesResultContentItemsOneOf5Caller2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf5Caller0)
            {
                baseMessagesResultContentItemsOneOf5Caller0?.Invoke(BaseMessagesResultContentItemsOneOf5Caller0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf5Caller1)
            {
                baseMessagesResultContentItemsOneOf5Caller1?.Invoke(BaseMessagesResultContentItemsOneOf5Caller1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf5Caller2)
            {
                baseMessagesResultContentItemsOneOf5Caller2?.Invoke(BaseMessagesResultContentItemsOneOf5Caller2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf5Caller0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf5Caller0),
                BaseMessagesResultContentItemsOneOf5Caller1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf5Caller1),
                BaseMessagesResultContentItemsOneOf5Caller2,
                typeof(global::G.BaseMessagesResultContentItemsOneOf5Caller2),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf5Caller other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf5Caller0?>.Default.Equals(BaseMessagesResultContentItemsOneOf5Caller0, other.BaseMessagesResultContentItemsOneOf5Caller0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf5Caller1?>.Default.Equals(BaseMessagesResultContentItemsOneOf5Caller1, other.BaseMessagesResultContentItemsOneOf5Caller1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf5Caller2?>.Default.Equals(BaseMessagesResultContentItemsOneOf5Caller2, other.BaseMessagesResultContentItemsOneOf5Caller2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf5Caller obj1, BaseMessagesResultContentItemsOneOf5Caller obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf5Caller>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf5Caller obj1, BaseMessagesResultContentItemsOneOf5Caller obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf5Caller o && Equals(o);
        }
    }
}
