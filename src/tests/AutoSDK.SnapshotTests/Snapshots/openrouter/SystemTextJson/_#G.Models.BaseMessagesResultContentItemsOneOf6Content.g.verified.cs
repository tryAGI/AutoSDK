//HintName: G.Models.BaseMessagesResultContentItemsOneOf6Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf6Content : global::System.IEquatable<BaseMessagesResultContentItemsOneOf6Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf6Content0? BaseMessagesResultContentItemsOneOf6Content0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf6Content0? BaseMessagesResultContentItemsOneOf6Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf6Content0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf6Content0 => BaseMessagesResultContentItemsOneOf6Content0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf6Content1? BaseMessagesResultContentItemsOneOf6Content1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf6Content1? BaseMessagesResultContentItemsOneOf6Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf6Content1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf6Content1 => BaseMessagesResultContentItemsOneOf6Content1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6Content(global::G.BaseMessagesResultContentItemsOneOf6Content0 value) => new BaseMessagesResultContentItemsOneOf6Content((global::G.BaseMessagesResultContentItemsOneOf6Content0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf6Content0?(BaseMessagesResultContentItemsOneOf6Content @this) => @this.BaseMessagesResultContentItemsOneOf6Content0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Content(global::G.BaseMessagesResultContentItemsOneOf6Content0? value)
        {
            BaseMessagesResultContentItemsOneOf6Content0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6Content(global::G.BaseMessagesResultContentItemsOneOf6Content1 value) => new BaseMessagesResultContentItemsOneOf6Content((global::G.BaseMessagesResultContentItemsOneOf6Content1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf6Content1?(BaseMessagesResultContentItemsOneOf6Content @this) => @this.BaseMessagesResultContentItemsOneOf6Content1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Content(global::G.BaseMessagesResultContentItemsOneOf6Content1? value)
        {
            BaseMessagesResultContentItemsOneOf6Content1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Content(
            global::G.BaseMessagesResultContentItemsOneOf6Content0? baseMessagesResultContentItemsOneOf6Content0,
            global::G.BaseMessagesResultContentItemsOneOf6Content1? baseMessagesResultContentItemsOneOf6Content1
            )
        {
            BaseMessagesResultContentItemsOneOf6Content0 = baseMessagesResultContentItemsOneOf6Content0;
            BaseMessagesResultContentItemsOneOf6Content1 = baseMessagesResultContentItemsOneOf6Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf6Content1 as object ??
            BaseMessagesResultContentItemsOneOf6Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf6Content0?.ToString() ??
            BaseMessagesResultContentItemsOneOf6Content1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf6Content0 && !IsBaseMessagesResultContentItemsOneOf6Content1 || !IsBaseMessagesResultContentItemsOneOf6Content0 && IsBaseMessagesResultContentItemsOneOf6Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf6Content0?, TResult>? baseMessagesResultContentItemsOneOf6Content0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf6Content1?, TResult>? baseMessagesResultContentItemsOneOf6Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf6Content0 && baseMessagesResultContentItemsOneOf6Content0 != null)
            {
                return baseMessagesResultContentItemsOneOf6Content0(BaseMessagesResultContentItemsOneOf6Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf6Content1 && baseMessagesResultContentItemsOneOf6Content1 != null)
            {
                return baseMessagesResultContentItemsOneOf6Content1(BaseMessagesResultContentItemsOneOf6Content1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf6Content0?>? baseMessagesResultContentItemsOneOf6Content0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf6Content1?>? baseMessagesResultContentItemsOneOf6Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf6Content0)
            {
                baseMessagesResultContentItemsOneOf6Content0?.Invoke(BaseMessagesResultContentItemsOneOf6Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf6Content1)
            {
                baseMessagesResultContentItemsOneOf6Content1?.Invoke(BaseMessagesResultContentItemsOneOf6Content1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf6Content0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf6Content0),
                BaseMessagesResultContentItemsOneOf6Content1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf6Content1),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf6Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf6Content0?>.Default.Equals(BaseMessagesResultContentItemsOneOf6Content0, other.BaseMessagesResultContentItemsOneOf6Content0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf6Content1?>.Default.Equals(BaseMessagesResultContentItemsOneOf6Content1, other.BaseMessagesResultContentItemsOneOf6Content1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf6Content obj1, BaseMessagesResultContentItemsOneOf6Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf6Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf6Content obj1, BaseMessagesResultContentItemsOneOf6Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf6Content o && Equals(o);
        }
    }
}
