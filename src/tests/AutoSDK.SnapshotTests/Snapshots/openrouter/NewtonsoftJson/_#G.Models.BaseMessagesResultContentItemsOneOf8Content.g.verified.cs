//HintName: G.Models.BaseMessagesResultContentItemsOneOf8Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf8Content : global::System.IEquatable<BaseMessagesResultContentItemsOneOf8Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf8Content0? BaseMessagesResultContentItemsOneOf8Content0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf8Content0? BaseMessagesResultContentItemsOneOf8Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf8Content0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf8Content0 => BaseMessagesResultContentItemsOneOf8Content0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf8Content1? BaseMessagesResultContentItemsOneOf8Content1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf8Content1? BaseMessagesResultContentItemsOneOf8Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf8Content1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf8Content1 => BaseMessagesResultContentItemsOneOf8Content1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf8Content(global::G.BaseMessagesResultContentItemsOneOf8Content0 value) => new BaseMessagesResultContentItemsOneOf8Content((global::G.BaseMessagesResultContentItemsOneOf8Content0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf8Content0?(BaseMessagesResultContentItemsOneOf8Content @this) => @this.BaseMessagesResultContentItemsOneOf8Content0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf8Content(global::G.BaseMessagesResultContentItemsOneOf8Content0? value)
        {
            BaseMessagesResultContentItemsOneOf8Content0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf8Content(global::G.BaseMessagesResultContentItemsOneOf8Content1 value) => new BaseMessagesResultContentItemsOneOf8Content((global::G.BaseMessagesResultContentItemsOneOf8Content1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf8Content1?(BaseMessagesResultContentItemsOneOf8Content @this) => @this.BaseMessagesResultContentItemsOneOf8Content1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf8Content(global::G.BaseMessagesResultContentItemsOneOf8Content1? value)
        {
            BaseMessagesResultContentItemsOneOf8Content1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf8Content(
            global::G.BaseMessagesResultContentItemsOneOf8Content0? baseMessagesResultContentItemsOneOf8Content0,
            global::G.BaseMessagesResultContentItemsOneOf8Content1? baseMessagesResultContentItemsOneOf8Content1
            )
        {
            BaseMessagesResultContentItemsOneOf8Content0 = baseMessagesResultContentItemsOneOf8Content0;
            BaseMessagesResultContentItemsOneOf8Content1 = baseMessagesResultContentItemsOneOf8Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf8Content1 as object ??
            BaseMessagesResultContentItemsOneOf8Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf8Content0?.ToString() ??
            BaseMessagesResultContentItemsOneOf8Content1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf8Content0 && !IsBaseMessagesResultContentItemsOneOf8Content1 || !IsBaseMessagesResultContentItemsOneOf8Content0 && IsBaseMessagesResultContentItemsOneOf8Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf8Content0?, TResult>? baseMessagesResultContentItemsOneOf8Content0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf8Content1?, TResult>? baseMessagesResultContentItemsOneOf8Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf8Content0 && baseMessagesResultContentItemsOneOf8Content0 != null)
            {
                return baseMessagesResultContentItemsOneOf8Content0(BaseMessagesResultContentItemsOneOf8Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf8Content1 && baseMessagesResultContentItemsOneOf8Content1 != null)
            {
                return baseMessagesResultContentItemsOneOf8Content1(BaseMessagesResultContentItemsOneOf8Content1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf8Content0?>? baseMessagesResultContentItemsOneOf8Content0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf8Content1?>? baseMessagesResultContentItemsOneOf8Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf8Content0)
            {
                baseMessagesResultContentItemsOneOf8Content0?.Invoke(BaseMessagesResultContentItemsOneOf8Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf8Content1)
            {
                baseMessagesResultContentItemsOneOf8Content1?.Invoke(BaseMessagesResultContentItemsOneOf8Content1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf8Content0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf8Content0),
                BaseMessagesResultContentItemsOneOf8Content1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf8Content1),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf8Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf8Content0?>.Default.Equals(BaseMessagesResultContentItemsOneOf8Content0, other.BaseMessagesResultContentItemsOneOf8Content0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf8Content1?>.Default.Equals(BaseMessagesResultContentItemsOneOf8Content1, other.BaseMessagesResultContentItemsOneOf8Content1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf8Content obj1, BaseMessagesResultContentItemsOneOf8Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf8Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf8Content obj1, BaseMessagesResultContentItemsOneOf8Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf8Content o && Equals(o);
        }
    }
}
