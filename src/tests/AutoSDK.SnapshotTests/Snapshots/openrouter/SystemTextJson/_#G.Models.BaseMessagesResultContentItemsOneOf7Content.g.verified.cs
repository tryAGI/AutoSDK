//HintName: G.Models.BaseMessagesResultContentItemsOneOf7Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf7Content : global::System.IEquatable<BaseMessagesResultContentItemsOneOf7Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf7Content0? BaseMessagesResultContentItemsOneOf7Content0 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf7Content0? BaseMessagesResultContentItemsOneOf7Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf7Content0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf7Content0 => BaseMessagesResultContentItemsOneOf7Content0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf7Content1? BaseMessagesResultContentItemsOneOf7Content1 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf7Content1? BaseMessagesResultContentItemsOneOf7Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf7Content1))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf7Content1 => BaseMessagesResultContentItemsOneOf7Content1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseMessagesResultContentItemsOneOf7Content2? BaseMessagesResultContentItemsOneOf7Content2 { get; init; }
#else
        public global::G.BaseMessagesResultContentItemsOneOf7Content2? BaseMessagesResultContentItemsOneOf7Content2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf7Content2))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf7Content2 => BaseMessagesResultContentItemsOneOf7Content2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf7Content(global::G.BaseMessagesResultContentItemsOneOf7Content0 value) => new BaseMessagesResultContentItemsOneOf7Content((global::G.BaseMessagesResultContentItemsOneOf7Content0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf7Content0?(BaseMessagesResultContentItemsOneOf7Content @this) => @this.BaseMessagesResultContentItemsOneOf7Content0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf7Content(global::G.BaseMessagesResultContentItemsOneOf7Content0? value)
        {
            BaseMessagesResultContentItemsOneOf7Content0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf7Content(global::G.BaseMessagesResultContentItemsOneOf7Content1 value) => new BaseMessagesResultContentItemsOneOf7Content((global::G.BaseMessagesResultContentItemsOneOf7Content1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf7Content1?(BaseMessagesResultContentItemsOneOf7Content @this) => @this.BaseMessagesResultContentItemsOneOf7Content1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf7Content(global::G.BaseMessagesResultContentItemsOneOf7Content1? value)
        {
            BaseMessagesResultContentItemsOneOf7Content1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf7Content(global::G.BaseMessagesResultContentItemsOneOf7Content2 value) => new BaseMessagesResultContentItemsOneOf7Content((global::G.BaseMessagesResultContentItemsOneOf7Content2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseMessagesResultContentItemsOneOf7Content2?(BaseMessagesResultContentItemsOneOf7Content @this) => @this.BaseMessagesResultContentItemsOneOf7Content2;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf7Content(global::G.BaseMessagesResultContentItemsOneOf7Content2? value)
        {
            BaseMessagesResultContentItemsOneOf7Content2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf7Content(
            global::G.BaseMessagesResultContentItemsOneOf7Content0? baseMessagesResultContentItemsOneOf7Content0,
            global::G.BaseMessagesResultContentItemsOneOf7Content1? baseMessagesResultContentItemsOneOf7Content1,
            global::G.BaseMessagesResultContentItemsOneOf7Content2? baseMessagesResultContentItemsOneOf7Content2
            )
        {
            BaseMessagesResultContentItemsOneOf7Content0 = baseMessagesResultContentItemsOneOf7Content0;
            BaseMessagesResultContentItemsOneOf7Content1 = baseMessagesResultContentItemsOneOf7Content1;
            BaseMessagesResultContentItemsOneOf7Content2 = baseMessagesResultContentItemsOneOf7Content2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultContentItemsOneOf7Content2 as object ??
            BaseMessagesResultContentItemsOneOf7Content1 as object ??
            BaseMessagesResultContentItemsOneOf7Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf7Content0?.ToString() ??
            BaseMessagesResultContentItemsOneOf7Content1?.ToString() ??
            BaseMessagesResultContentItemsOneOf7Content2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf7Content0 && !IsBaseMessagesResultContentItemsOneOf7Content1 && !IsBaseMessagesResultContentItemsOneOf7Content2 || !IsBaseMessagesResultContentItemsOneOf7Content0 && IsBaseMessagesResultContentItemsOneOf7Content1 && !IsBaseMessagesResultContentItemsOneOf7Content2 || !IsBaseMessagesResultContentItemsOneOf7Content0 && !IsBaseMessagesResultContentItemsOneOf7Content1 && IsBaseMessagesResultContentItemsOneOf7Content2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf7Content0?, TResult>? baseMessagesResultContentItemsOneOf7Content0 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf7Content1?, TResult>? baseMessagesResultContentItemsOneOf7Content1 = null,
            global::System.Func<global::G.BaseMessagesResultContentItemsOneOf7Content2?, TResult>? baseMessagesResultContentItemsOneOf7Content2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf7Content0 && baseMessagesResultContentItemsOneOf7Content0 != null)
            {
                return baseMessagesResultContentItemsOneOf7Content0(BaseMessagesResultContentItemsOneOf7Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf7Content1 && baseMessagesResultContentItemsOneOf7Content1 != null)
            {
                return baseMessagesResultContentItemsOneOf7Content1(BaseMessagesResultContentItemsOneOf7Content1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf7Content2 && baseMessagesResultContentItemsOneOf7Content2 != null)
            {
                return baseMessagesResultContentItemsOneOf7Content2(BaseMessagesResultContentItemsOneOf7Content2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf7Content0?>? baseMessagesResultContentItemsOneOf7Content0 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf7Content1?>? baseMessagesResultContentItemsOneOf7Content1 = null,
            global::System.Action<global::G.BaseMessagesResultContentItemsOneOf7Content2?>? baseMessagesResultContentItemsOneOf7Content2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf7Content0)
            {
                baseMessagesResultContentItemsOneOf7Content0?.Invoke(BaseMessagesResultContentItemsOneOf7Content0!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf7Content1)
            {
                baseMessagesResultContentItemsOneOf7Content1?.Invoke(BaseMessagesResultContentItemsOneOf7Content1!);
            }
            else if (IsBaseMessagesResultContentItemsOneOf7Content2)
            {
                baseMessagesResultContentItemsOneOf7Content2?.Invoke(BaseMessagesResultContentItemsOneOf7Content2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf7Content0,
                typeof(global::G.BaseMessagesResultContentItemsOneOf7Content0),
                BaseMessagesResultContentItemsOneOf7Content1,
                typeof(global::G.BaseMessagesResultContentItemsOneOf7Content1),
                BaseMessagesResultContentItemsOneOf7Content2,
                typeof(global::G.BaseMessagesResultContentItemsOneOf7Content2),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf7Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf7Content0?>.Default.Equals(BaseMessagesResultContentItemsOneOf7Content0, other.BaseMessagesResultContentItemsOneOf7Content0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf7Content1?>.Default.Equals(BaseMessagesResultContentItemsOneOf7Content1, other.BaseMessagesResultContentItemsOneOf7Content1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseMessagesResultContentItemsOneOf7Content2?>.Default.Equals(BaseMessagesResultContentItemsOneOf7Content2, other.BaseMessagesResultContentItemsOneOf7Content2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf7Content obj1, BaseMessagesResultContentItemsOneOf7Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf7Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf7Content obj1, BaseMessagesResultContentItemsOneOf7Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf7Content o && Equals(o);
        }
    }
}
