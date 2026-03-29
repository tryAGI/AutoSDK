//HintName: G.Models.BaseMessagesResultContentItemsOneOf1Caller.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf1Caller : global::System.IEquatable<BaseMessagesResultContentItemsOneOf1Caller>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf1Caller0? BaseMessagesResultContentItemsOneOf1Caller0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf1Caller0? BaseMessagesResultContentItemsOneOf1Caller0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf1Caller0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf1Caller0 => BaseMessagesResultContentItemsOneOf1Caller0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf1Caller1? BaseMessagesResultContentItemsOneOf1Caller1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf1Caller1? BaseMessagesResultContentItemsOneOf1Caller1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf1Caller1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf1Caller1 => BaseMessagesResultContentItemsOneOf1Caller1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf1Caller2? BaseMessagesResultContentItemsOneOf1Caller2 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf1Caller2? BaseMessagesResultContentItemsOneOf1Caller2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf1Caller2))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf1Caller2 => BaseMessagesResultContentItemsOneOf1Caller2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf1Caller(global::G.BaseMessagesResultContentItemsOneOf1Caller0 value) => new BaseMessagesResultContentItemsOneOf1Caller((global::G.BaseMessagesResultContentItemsOneOf1Caller0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf1Caller0?(BaseMessagesResultContentItemsOneOf1Caller @this) => @this.BaseMessagesResultContentItemsOneOf1Caller0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf1Caller(global::G.BaseMessagesResultContentItemsOneOf1Caller0? value)
        {
            BaseMessagesResultContentItemsOneOf1Caller0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf1Caller(global::G.BaseMessagesResultContentItemsOneOf1Caller1 value) => new BaseMessagesResultContentItemsOneOf1Caller((global::G.BaseMessagesResultContentItemsOneOf1Caller1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf1Caller1?(BaseMessagesResultContentItemsOneOf1Caller @this) => @this.BaseMessagesResultContentItemsOneOf1Caller1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf1Caller(global::G.BaseMessagesResultContentItemsOneOf1Caller1? value)
        {
            BaseMessagesResultContentItemsOneOf1Caller1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf1Caller(global::G.BaseMessagesResultContentItemsOneOf1Caller2 value) => new BaseMessagesResultContentItemsOneOf1Caller((global::G.BaseMessagesResultContentItemsOneOf1Caller2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf1Caller2?(BaseMessagesResultContentItemsOneOf1Caller @this) => @this.BaseMessagesResultContentItemsOneOf1Caller2;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf1Caller(global::G.BaseMessagesResultContentItemsOneOf1Caller2? value)
        {
            BaseMessagesResultContentItemsOneOf1Caller2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf1Caller(
            global::G.BaseMessagesResultContentItemsOneOf1Caller0? baseMessagesResultContentItemsOneOf1Caller0,
            global::G.BaseMessagesResultContentItemsOneOf1Caller1? baseMessagesResultContentItemsOneOf1Caller1,
            global::G.BaseMessagesResultContentItemsOneOf1Caller2? baseMessagesResultContentItemsOneOf1Caller2
            )
        {
            BaseMessagesResultContentItemsOneOf1Caller0 = baseMessagesResultContentItemsOneOf1Caller0;
            BaseMessagesResultContentItemsOneOf1Caller1 = baseMessagesResultContentItemsOneOf1Caller1;
            BaseMessagesResultContentItemsOneOf1Caller2 = baseMessagesResultContentItemsOneOf1Caller2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf1Caller2 as object ??
            BaseMessagesResultContentItemsOneOf1Caller1 as object ??
            BaseMessagesResultContentItemsOneOf1Caller0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf1Caller0?.ToString() ??
            BaseMessagesResultContentItemsOneOf1Caller1?.ToString() ??
            BaseMessagesResultContentItemsOneOf1Caller2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf1Caller0 && !IsBaseMessagesResultContentItemsOneOf1Caller1 && !IsBaseMessagesResultContentItemsOneOf1Caller2 || !IsBaseMessagesResultContentItemsOneOf1Caller0 && IsBaseMessagesResultContentItemsOneOf1Caller1 && !IsBaseMessagesResultContentItemsOneOf1Caller2 || !IsBaseMessagesResultContentItemsOneOf1Caller0 && !IsBaseMessagesResultContentItemsOneOf1Caller1 && IsBaseMessagesResultContentItemsOneOf1Caller2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf1Caller0?, TResult>? baseMessagesResultContentItemsOneOf1Caller0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf1Caller1?, TResult>? baseMessagesResultContentItemsOneOf1Caller1 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf1Caller2?, TResult>? baseMessagesResultContentItemsOneOf1Caller2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf1Caller0 && baseMessagesResultContentItemsOneOf1Caller0 != null)
            {
                return baseMessagesResultContentItemsOneOf1Caller0(BaseMessagesResultContentItemsOneOf1Caller0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf1Caller1 && baseMessagesResultContentItemsOneOf1Caller1 != null)
            {
                return baseMessagesResultContentItemsOneOf1Caller1(BaseMessagesResultContentItemsOneOf1Caller1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf1Caller2 && baseMessagesResultContentItemsOneOf1Caller2 != null)
            {
                return baseMessagesResultContentItemsOneOf1Caller2(BaseMessagesResultContentItemsOneOf1Caller2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf1Caller0?>? baseMessagesResultContentItemsOneOf1Caller0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf1Caller1?>? baseMessagesResultContentItemsOneOf1Caller1 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf1Caller2?>? baseMessagesResultContentItemsOneOf1Caller2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf1Caller0)
            {
                baseMessagesResultContentItemsOneOf1Caller0?.Invoke(BaseMessagesResultContentItemsOneOf1Caller0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf1Caller1)
            {
                baseMessagesResultContentItemsOneOf1Caller1?.Invoke(BaseMessagesResultContentItemsOneOf1Caller1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf1Caller2)
            {
                baseMessagesResultContentItemsOneOf1Caller2?.Invoke(BaseMessagesResultContentItemsOneOf1Caller2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf1Caller0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf1Caller0),
                BaseMessagesResultContentItemsOneOf1Caller1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf1Caller1),
                BaseMessagesResultContentItemsOneOf1Caller2,
                typeof(global::G.BaseMessagesResultContentItemsOneOf1Caller2),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf1Caller other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf1Caller0?>.Default.Equals(BaseMessagesResultContentItemsOneOf1Caller0, other.BaseMessagesResultContentItemsOneOf1Caller0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf1Caller1?>.Default.Equals(BaseMessagesResultContentItemsOneOf1Caller1, other.BaseMessagesResultContentItemsOneOf1Caller1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf1Caller2?>.Default.Equals(BaseMessagesResultContentItemsOneOf1Caller2, other.BaseMessagesResultContentItemsOneOf1Caller2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf1Caller obj1, BaseMessagesResultContentItemsOneOf1Caller obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf1Caller>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf1Caller obj1, BaseMessagesResultContentItemsOneOf1Caller obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf1Caller o && Equals(o);
        }
    }
}
