//HintName: G.Models.BaseMessagesResultContentItemsOneOf6Caller.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf6Caller : global::System.IEquatable<BaseMessagesResultContentItemsOneOf6Caller>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf6Caller0? BaseMessagesResultContentItemsOneOf6Caller0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf6Caller0? BaseMessagesResultContentItemsOneOf6Caller0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf6Caller0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf6Caller0 => BaseMessagesResultContentItemsOneOf6Caller0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf6Caller1? BaseMessagesResultContentItemsOneOf6Caller1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf6Caller1? BaseMessagesResultContentItemsOneOf6Caller1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf6Caller1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf6Caller1 => BaseMessagesResultContentItemsOneOf6Caller1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf6Caller2? BaseMessagesResultContentItemsOneOf6Caller2 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf6Caller2? BaseMessagesResultContentItemsOneOf6Caller2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf6Caller2))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf6Caller2 => BaseMessagesResultContentItemsOneOf6Caller2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6Caller(global::G.BaseMessagesResultContentItemsOneOf6Caller0 value) => new BaseMessagesResultContentItemsOneOf6Caller((global::G.BaseMessagesResultContentItemsOneOf6Caller0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf6Caller0?(BaseMessagesResultContentItemsOneOf6Caller @this) => @this.BaseMessagesResultContentItemsOneOf6Caller0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Caller(global::G.BaseMessagesResultContentItemsOneOf6Caller0? value)
        {
            BaseMessagesResultContentItemsOneOf6Caller0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6Caller(global::G.BaseMessagesResultContentItemsOneOf6Caller1 value) => new BaseMessagesResultContentItemsOneOf6Caller((global::G.BaseMessagesResultContentItemsOneOf6Caller1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf6Caller1?(BaseMessagesResultContentItemsOneOf6Caller @this) => @this.BaseMessagesResultContentItemsOneOf6Caller1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Caller(global::G.BaseMessagesResultContentItemsOneOf6Caller1? value)
        {
            BaseMessagesResultContentItemsOneOf6Caller1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6Caller(global::G.BaseMessagesResultContentItemsOneOf6Caller2 value) => new BaseMessagesResultContentItemsOneOf6Caller((global::G.BaseMessagesResultContentItemsOneOf6Caller2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf6Caller2?(BaseMessagesResultContentItemsOneOf6Caller @this) => @this.BaseMessagesResultContentItemsOneOf6Caller2;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Caller(global::G.BaseMessagesResultContentItemsOneOf6Caller2? value)
        {
            BaseMessagesResultContentItemsOneOf6Caller2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Caller(
            global::G.BaseMessagesResultContentItemsOneOf6Caller0? baseMessagesResultContentItemsOneOf6Caller0,
            global::G.BaseMessagesResultContentItemsOneOf6Caller1? baseMessagesResultContentItemsOneOf6Caller1,
            global::G.BaseMessagesResultContentItemsOneOf6Caller2? baseMessagesResultContentItemsOneOf6Caller2
            )
        {
            BaseMessagesResultContentItemsOneOf6Caller0 = baseMessagesResultContentItemsOneOf6Caller0;
            BaseMessagesResultContentItemsOneOf6Caller1 = baseMessagesResultContentItemsOneOf6Caller1;
            BaseMessagesResultContentItemsOneOf6Caller2 = baseMessagesResultContentItemsOneOf6Caller2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf6Caller2 as object ??
            BaseMessagesResultContentItemsOneOf6Caller1 as object ??
            BaseMessagesResultContentItemsOneOf6Caller0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf6Caller0?.ToString() ??
            BaseMessagesResultContentItemsOneOf6Caller1?.ToString() ??
            BaseMessagesResultContentItemsOneOf6Caller2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf6Caller0 && !IsBaseMessagesResultContentItemsOneOf6Caller1 && !IsBaseMessagesResultContentItemsOneOf6Caller2 || !IsBaseMessagesResultContentItemsOneOf6Caller0 && IsBaseMessagesResultContentItemsOneOf6Caller1 && !IsBaseMessagesResultContentItemsOneOf6Caller2 || !IsBaseMessagesResultContentItemsOneOf6Caller0 && !IsBaseMessagesResultContentItemsOneOf6Caller1 && IsBaseMessagesResultContentItemsOneOf6Caller2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf6Caller0?, TResult>? baseMessagesResultContentItemsOneOf6Caller0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf6Caller1?, TResult>? baseMessagesResultContentItemsOneOf6Caller1 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf6Caller2?, TResult>? baseMessagesResultContentItemsOneOf6Caller2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf6Caller0 && baseMessagesResultContentItemsOneOf6Caller0 != null)
            {
                return baseMessagesResultContentItemsOneOf6Caller0(BaseMessagesResultContentItemsOneOf6Caller0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf6Caller1 && baseMessagesResultContentItemsOneOf6Caller1 != null)
            {
                return baseMessagesResultContentItemsOneOf6Caller1(BaseMessagesResultContentItemsOneOf6Caller1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf6Caller2 && baseMessagesResultContentItemsOneOf6Caller2 != null)
            {
                return baseMessagesResultContentItemsOneOf6Caller2(BaseMessagesResultContentItemsOneOf6Caller2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf6Caller0?>? baseMessagesResultContentItemsOneOf6Caller0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf6Caller1?>? baseMessagesResultContentItemsOneOf6Caller1 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf6Caller2?>? baseMessagesResultContentItemsOneOf6Caller2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf6Caller0)
            {
                baseMessagesResultContentItemsOneOf6Caller0?.Invoke(BaseMessagesResultContentItemsOneOf6Caller0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf6Caller1)
            {
                baseMessagesResultContentItemsOneOf6Caller1?.Invoke(BaseMessagesResultContentItemsOneOf6Caller1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf6Caller2)
            {
                baseMessagesResultContentItemsOneOf6Caller2?.Invoke(BaseMessagesResultContentItemsOneOf6Caller2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf6Caller0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf6Caller0),
                BaseMessagesResultContentItemsOneOf6Caller1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf6Caller1),
                BaseMessagesResultContentItemsOneOf6Caller2,
                typeof(global::G.BaseMessagesResultContentItemsOneOf6Caller2),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf6Caller other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf6Caller0?>.Default.Equals(BaseMessagesResultContentItemsOneOf6Caller0, other.BaseMessagesResultContentItemsOneOf6Caller0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf6Caller1?>.Default.Equals(BaseMessagesResultContentItemsOneOf6Caller1, other.BaseMessagesResultContentItemsOneOf6Caller1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf6Caller2?>.Default.Equals(BaseMessagesResultContentItemsOneOf6Caller2, other.BaseMessagesResultContentItemsOneOf6Caller2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf6Caller obj1, BaseMessagesResultContentItemsOneOf6Caller obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf6Caller>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf6Caller obj1, BaseMessagesResultContentItemsOneOf6Caller obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf6Caller o && Equals(o);
        }
    }
}
