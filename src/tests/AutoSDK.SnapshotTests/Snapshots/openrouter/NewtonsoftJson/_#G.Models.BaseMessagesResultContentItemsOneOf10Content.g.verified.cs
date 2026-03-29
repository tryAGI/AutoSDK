//HintName: G.Models.BaseMessagesResultContentItemsOneOf10Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf10Content : global::System.IEquatable<BaseMessagesResultContentItemsOneOf10Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf10Content0? BaseMessagesResultContentItemsOneOf10Content0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf10Content0? BaseMessagesResultContentItemsOneOf10Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf10Content0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf10Content0 => BaseMessagesResultContentItemsOneOf10Content0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf10Content1? BaseMessagesResultContentItemsOneOf10Content1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf10Content1? BaseMessagesResultContentItemsOneOf10Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf10Content1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf10Content1 => BaseMessagesResultContentItemsOneOf10Content1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf10Content(global::G.BaseMessagesResultContentItemsOneOf10Content0 value) => new BaseMessagesResultContentItemsOneOf10Content((global::G.BaseMessagesResultContentItemsOneOf10Content0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf10Content0?(BaseMessagesResultContentItemsOneOf10Content @this) => @this.BaseMessagesResultContentItemsOneOf10Content0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf10Content(global::G.BaseMessagesResultContentItemsOneOf10Content0? value)
        {
            BaseMessagesResultContentItemsOneOf10Content0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf10Content(global::G.BaseMessagesResultContentItemsOneOf10Content1 value) => new BaseMessagesResultContentItemsOneOf10Content((global::G.BaseMessagesResultContentItemsOneOf10Content1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf10Content1?(BaseMessagesResultContentItemsOneOf10Content @this) => @this.BaseMessagesResultContentItemsOneOf10Content1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf10Content(global::G.BaseMessagesResultContentItemsOneOf10Content1? value)
        {
            BaseMessagesResultContentItemsOneOf10Content1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf10Content(
            global::G.BaseMessagesResultContentItemsOneOf10Content0? baseMessagesResultContentItemsOneOf10Content0,
            global::G.BaseMessagesResultContentItemsOneOf10Content1? baseMessagesResultContentItemsOneOf10Content1
            )
        {
            BaseMessagesResultContentItemsOneOf10Content0 = baseMessagesResultContentItemsOneOf10Content0;
            BaseMessagesResultContentItemsOneOf10Content1 = baseMessagesResultContentItemsOneOf10Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf10Content1 as object ??
            BaseMessagesResultContentItemsOneOf10Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf10Content0?.ToString() ??
            BaseMessagesResultContentItemsOneOf10Content1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf10Content0 && !IsBaseMessagesResultContentItemsOneOf10Content1 || !IsBaseMessagesResultContentItemsOneOf10Content0 && IsBaseMessagesResultContentItemsOneOf10Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf10Content0?, TResult>? baseMessagesResultContentItemsOneOf10Content0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf10Content1?, TResult>? baseMessagesResultContentItemsOneOf10Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf10Content0 && baseMessagesResultContentItemsOneOf10Content0 != null)
            {
                return baseMessagesResultContentItemsOneOf10Content0(BaseMessagesResultContentItemsOneOf10Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf10Content1 && baseMessagesResultContentItemsOneOf10Content1 != null)
            {
                return baseMessagesResultContentItemsOneOf10Content1(BaseMessagesResultContentItemsOneOf10Content1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf10Content0?>? baseMessagesResultContentItemsOneOf10Content0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf10Content1?>? baseMessagesResultContentItemsOneOf10Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf10Content0)
            {
                baseMessagesResultContentItemsOneOf10Content0?.Invoke(BaseMessagesResultContentItemsOneOf10Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf10Content1)
            {
                baseMessagesResultContentItemsOneOf10Content1?.Invoke(BaseMessagesResultContentItemsOneOf10Content1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf10Content0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf10Content0),
                BaseMessagesResultContentItemsOneOf10Content1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf10Content1),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf10Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf10Content0?>.Default.Equals(BaseMessagesResultContentItemsOneOf10Content0, other.BaseMessagesResultContentItemsOneOf10Content0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf10Content1?>.Default.Equals(BaseMessagesResultContentItemsOneOf10Content1, other.BaseMessagesResultContentItemsOneOf10Content1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf10Content obj1, BaseMessagesResultContentItemsOneOf10Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf10Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf10Content obj1, BaseMessagesResultContentItemsOneOf10Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf10Content o && Equals(o);
        }
    }
}
