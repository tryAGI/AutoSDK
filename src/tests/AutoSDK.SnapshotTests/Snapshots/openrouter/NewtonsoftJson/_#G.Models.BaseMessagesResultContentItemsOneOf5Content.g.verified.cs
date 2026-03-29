//HintName: G.Models.BaseMessagesResultContentItemsOneOf5Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf5Content : global::System.IEquatable<BaseMessagesResultContentItemsOneOf5Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>? BaseMessagesResultContentItemsOneOf5Content0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>? BaseMessagesResultContentItemsOneOf5Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf5Content0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf5Content0 => BaseMessagesResultContentItemsOneOf5Content0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf5Content1? BaseMessagesResultContentItemsOneOf5Content1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf5Content1? BaseMessagesResultContentItemsOneOf5Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf5Content1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf5Content1 => BaseMessagesResultContentItemsOneOf5Content1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf5Content(global::G.BaseMessagesResultContentItemsOneOf5Content1 value) => new BaseMessagesResultContentItemsOneOf5Content((global::G.BaseMessagesResultContentItemsOneOf5Content1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf5Content1?(BaseMessagesResultContentItemsOneOf5Content @this) => @this.BaseMessagesResultContentItemsOneOf5Content1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Content(global::G.BaseMessagesResultContentItemsOneOf5Content1? value)
        {
            BaseMessagesResultContentItemsOneOf5Content1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Content(
            global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>? baseMessagesResultContentItemsOneOf5Content0,
            global::G.BaseMessagesResultContentItemsOneOf5Content1? baseMessagesResultContentItemsOneOf5Content1
            )
        {
            BaseMessagesResultContentItemsOneOf5Content0 = baseMessagesResultContentItemsOneOf5Content0;
            BaseMessagesResultContentItemsOneOf5Content1 = baseMessagesResultContentItemsOneOf5Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf5Content1 as object ??
            BaseMessagesResultContentItemsOneOf5Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf5Content0?.ToString() ??
            BaseMessagesResultContentItemsOneOf5Content1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf5Content0 && !IsBaseMessagesResultContentItemsOneOf5Content1 || !IsBaseMessagesResultContentItemsOneOf5Content0 && IsBaseMessagesResultContentItemsOneOf5Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>?, TResult>? baseMessagesResultContentItemsOneOf5Content0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf5Content1?, TResult>? baseMessagesResultContentItemsOneOf5Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf5Content0 && baseMessagesResultContentItemsOneOf5Content0 != null)
            {
                return baseMessagesResultContentItemsOneOf5Content0(BaseMessagesResultContentItemsOneOf5Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf5Content1 && baseMessagesResultContentItemsOneOf5Content1 != null)
            {
                return baseMessagesResultContentItemsOneOf5Content1(BaseMessagesResultContentItemsOneOf5Content1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>?>? baseMessagesResultContentItemsOneOf5Content0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf5Content1?>? baseMessagesResultContentItemsOneOf5Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf5Content0)
            {
                baseMessagesResultContentItemsOneOf5Content0?.Invoke(BaseMessagesResultContentItemsOneOf5Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf5Content1)
            {
                baseMessagesResultContentItemsOneOf5Content1?.Invoke(BaseMessagesResultContentItemsOneOf5Content1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf5Content0,
                typeof(global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>),
                BaseMessagesResultContentItemsOneOf5Content1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf5Content1),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf5Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>?>.Default.Equals(BaseMessagesResultContentItemsOneOf5Content0, other.BaseMessagesResultContentItemsOneOf5Content0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf5Content1?>.Default.Equals(BaseMessagesResultContentItemsOneOf5Content1, other.BaseMessagesResultContentItemsOneOf5Content1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf5Content obj1, BaseMessagesResultContentItemsOneOf5Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf5Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf5Content obj1, BaseMessagesResultContentItemsOneOf5Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf5Content o && Equals(o);
        }
    }
}
