//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource : global::System.IEquatable<BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 => BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1? BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1? BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 => BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 value) => new BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource((global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource @this) => @this.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? value)
        {
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 value) => new BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource((global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1?(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource @this) => @this.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1? value)
        {
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1
            )
        {
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0;
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 = baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 as object ??
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?.ToString() ??
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 && !IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 || !IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 && IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?, TResult>? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1?, TResult>? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 && baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 != null)
            {
                return baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 && baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 != null)
            {
                return baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?>? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1?>? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0)
            {
                baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?.Invoke(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1)
            {
                baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1?.Invoke(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0),
                BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?>.Default.Equals(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0, other.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1?>.Default.Equals(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1, other.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource obj1, BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource obj1, BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource o && Equals(o);
        }
    }
}
