//HintName: G.Models.BaseMessagesResultContentItemsOneOf4Caller.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf4Caller : global::System.IEquatable<BaseMessagesResultContentItemsOneOf4Caller>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf4Caller0? BaseMessagesResultContentItemsOneOf4Caller0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf4Caller0? BaseMessagesResultContentItemsOneOf4Caller0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf4Caller0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf4Caller0 => BaseMessagesResultContentItemsOneOf4Caller0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf4Caller1? BaseMessagesResultContentItemsOneOf4Caller1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf4Caller1? BaseMessagesResultContentItemsOneOf4Caller1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf4Caller1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf4Caller1 => BaseMessagesResultContentItemsOneOf4Caller1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf4Caller2? BaseMessagesResultContentItemsOneOf4Caller2 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf4Caller2? BaseMessagesResultContentItemsOneOf4Caller2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf4Caller2))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf4Caller2 => BaseMessagesResultContentItemsOneOf4Caller2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf4Caller(global::G.BaseMessagesResultContentItemsOneOf4Caller0 value) => new BaseMessagesResultContentItemsOneOf4Caller((global::G.BaseMessagesResultContentItemsOneOf4Caller0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf4Caller0?(BaseMessagesResultContentItemsOneOf4Caller @this) => @this.BaseMessagesResultContentItemsOneOf4Caller0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf4Caller(global::G.BaseMessagesResultContentItemsOneOf4Caller0? value)
        {
            BaseMessagesResultContentItemsOneOf4Caller0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf4Caller(global::G.BaseMessagesResultContentItemsOneOf4Caller1 value) => new BaseMessagesResultContentItemsOneOf4Caller((global::G.BaseMessagesResultContentItemsOneOf4Caller1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf4Caller1?(BaseMessagesResultContentItemsOneOf4Caller @this) => @this.BaseMessagesResultContentItemsOneOf4Caller1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf4Caller(global::G.BaseMessagesResultContentItemsOneOf4Caller1? value)
        {
            BaseMessagesResultContentItemsOneOf4Caller1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf4Caller(global::G.BaseMessagesResultContentItemsOneOf4Caller2 value) => new BaseMessagesResultContentItemsOneOf4Caller((global::G.BaseMessagesResultContentItemsOneOf4Caller2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf4Caller2?(BaseMessagesResultContentItemsOneOf4Caller @this) => @this.BaseMessagesResultContentItemsOneOf4Caller2;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf4Caller(global::G.BaseMessagesResultContentItemsOneOf4Caller2? value)
        {
            BaseMessagesResultContentItemsOneOf4Caller2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf4Caller(
            global::G.BaseMessagesResultContentItemsOneOf4Caller0? baseMessagesResultContentItemsOneOf4Caller0,
            global::G.BaseMessagesResultContentItemsOneOf4Caller1? baseMessagesResultContentItemsOneOf4Caller1,
            global::G.BaseMessagesResultContentItemsOneOf4Caller2? baseMessagesResultContentItemsOneOf4Caller2
            )
        {
            BaseMessagesResultContentItemsOneOf4Caller0 = baseMessagesResultContentItemsOneOf4Caller0;
            BaseMessagesResultContentItemsOneOf4Caller1 = baseMessagesResultContentItemsOneOf4Caller1;
            BaseMessagesResultContentItemsOneOf4Caller2 = baseMessagesResultContentItemsOneOf4Caller2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf4Caller2 as object ??
            BaseMessagesResultContentItemsOneOf4Caller1 as object ??
            BaseMessagesResultContentItemsOneOf4Caller0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf4Caller0?.ToString() ??
            BaseMessagesResultContentItemsOneOf4Caller1?.ToString() ??
            BaseMessagesResultContentItemsOneOf4Caller2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf4Caller0 && !IsBaseMessagesResultContentItemsOneOf4Caller1 && !IsBaseMessagesResultContentItemsOneOf4Caller2 || !IsBaseMessagesResultContentItemsOneOf4Caller0 && IsBaseMessagesResultContentItemsOneOf4Caller1 && !IsBaseMessagesResultContentItemsOneOf4Caller2 || !IsBaseMessagesResultContentItemsOneOf4Caller0 && !IsBaseMessagesResultContentItemsOneOf4Caller1 && IsBaseMessagesResultContentItemsOneOf4Caller2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf4Caller0?, TResult>? baseMessagesResultContentItemsOneOf4Caller0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf4Caller1?, TResult>? baseMessagesResultContentItemsOneOf4Caller1 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf4Caller2?, TResult>? baseMessagesResultContentItemsOneOf4Caller2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf4Caller0 && baseMessagesResultContentItemsOneOf4Caller0 != null)
            {
                return baseMessagesResultContentItemsOneOf4Caller0(BaseMessagesResultContentItemsOneOf4Caller0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf4Caller1 && baseMessagesResultContentItemsOneOf4Caller1 != null)
            {
                return baseMessagesResultContentItemsOneOf4Caller1(BaseMessagesResultContentItemsOneOf4Caller1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf4Caller2 && baseMessagesResultContentItemsOneOf4Caller2 != null)
            {
                return baseMessagesResultContentItemsOneOf4Caller2(BaseMessagesResultContentItemsOneOf4Caller2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf4Caller0?>? baseMessagesResultContentItemsOneOf4Caller0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf4Caller1?>? baseMessagesResultContentItemsOneOf4Caller1 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf4Caller2?>? baseMessagesResultContentItemsOneOf4Caller2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf4Caller0)
            {
                baseMessagesResultContentItemsOneOf4Caller0?.Invoke(BaseMessagesResultContentItemsOneOf4Caller0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf4Caller1)
            {
                baseMessagesResultContentItemsOneOf4Caller1?.Invoke(BaseMessagesResultContentItemsOneOf4Caller1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf4Caller2)
            {
                baseMessagesResultContentItemsOneOf4Caller2?.Invoke(BaseMessagesResultContentItemsOneOf4Caller2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf4Caller0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf4Caller0),
                BaseMessagesResultContentItemsOneOf4Caller1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf4Caller1),
                BaseMessagesResultContentItemsOneOf4Caller2,
                typeof(global::G.BaseMessagesResultContentItemsOneOf4Caller2),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf4Caller other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf4Caller0?>.Default.Equals(BaseMessagesResultContentItemsOneOf4Caller0, other.BaseMessagesResultContentItemsOneOf4Caller0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf4Caller1?>.Default.Equals(BaseMessagesResultContentItemsOneOf4Caller1, other.BaseMessagesResultContentItemsOneOf4Caller1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf4Caller2?>.Default.Equals(BaseMessagesResultContentItemsOneOf4Caller2, other.BaseMessagesResultContentItemsOneOf4Caller2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf4Caller obj1, BaseMessagesResultContentItemsOneOf4Caller obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf4Caller>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf4Caller obj1, BaseMessagesResultContentItemsOneOf4Caller obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf4Caller o && Equals(o);
        }
    }
}
