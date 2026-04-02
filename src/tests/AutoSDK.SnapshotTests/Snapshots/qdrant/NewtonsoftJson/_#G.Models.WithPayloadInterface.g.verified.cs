//HintName: G.Models.WithPayloadInterface.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Options for specifying which payload to include or not
    /// </summary>
    public readonly partial struct WithPayloadInterface : global::System.IEquatable<WithPayloadInterface>
    {
        /// <summary>
        /// If `true` - return all payload, If `false` - do not return payload
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? WithPayloadInterfaceVariant1 { get; init; }
#else
        public bool? WithPayloadInterfaceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithPayloadInterfaceVariant1))]
#endif
        public bool IsWithPayloadInterfaceVariant1 => WithPayloadInterfaceVariant1 != null;

        /// <summary>
        /// Specify which fields to return
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? WithPayloadInterfaceVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? WithPayloadInterfaceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithPayloadInterfaceVariant2))]
#endif
        public bool IsWithPayloadInterfaceVariant2 => WithPayloadInterfaceVariant2 != null;

        /// <summary>
        /// Specifies how to treat payload selector
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadSelector? Selector { get; init; }
#else
        public global::G.PayloadSelector? Selector { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Selector))]
#endif
        public bool IsSelector => Selector != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WithPayloadInterface(bool value) => new WithPayloadInterface((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(WithPayloadInterface @this) => @this.WithPayloadInterfaceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WithPayloadInterface(bool? value)
        {
            WithPayloadInterfaceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WithPayloadInterface(global::G.PayloadSelector value) => new WithPayloadInterface((global::G.PayloadSelector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadSelector?(WithPayloadInterface @this) => @this.Selector;

        /// <summary>
        /// 
        /// </summary>
        public WithPayloadInterface(global::G.PayloadSelector? value)
        {
            Selector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WithPayloadInterface(
            bool? withPayloadInterfaceVariant1,
            global::System.Collections.Generic.IList<string>? withPayloadInterfaceVariant2,
            global::G.PayloadSelector? selector
            )
        {
            WithPayloadInterfaceVariant1 = withPayloadInterfaceVariant1;
            WithPayloadInterfaceVariant2 = withPayloadInterfaceVariant2;
            Selector = selector;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Selector as object ??
            WithPayloadInterfaceVariant2 as object ??
            WithPayloadInterfaceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WithPayloadInterfaceVariant1?.ToString().ToLowerInvariant() ??
            WithPayloadInterfaceVariant2?.ToString() ??
            Selector?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWithPayloadInterfaceVariant1 || IsWithPayloadInterfaceVariant2 || IsSelector;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? withPayloadInterfaceVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? withPayloadInterfaceVariant2 = null,
            global::System.Func<global::G.PayloadSelector?, TResult>? selector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWithPayloadInterfaceVariant1 && withPayloadInterfaceVariant1 != null)
            {
                return withPayloadInterfaceVariant1(WithPayloadInterfaceVariant1!);
            }
            else if (IsWithPayloadInterfaceVariant2 && withPayloadInterfaceVariant2 != null)
            {
                return withPayloadInterfaceVariant2(WithPayloadInterfaceVariant2!);
            }
            else if (IsSelector && selector != null)
            {
                return selector(Selector!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? withPayloadInterfaceVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? withPayloadInterfaceVariant2 = null,
            global::System.Action<global::G.PayloadSelector?>? selector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWithPayloadInterfaceVariant1)
            {
                withPayloadInterfaceVariant1?.Invoke(WithPayloadInterfaceVariant1!);
            }
            else if (IsWithPayloadInterfaceVariant2)
            {
                withPayloadInterfaceVariant2?.Invoke(WithPayloadInterfaceVariant2!);
            }
            else if (IsSelector)
            {
                selector?.Invoke(Selector!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WithPayloadInterfaceVariant1,
                typeof(bool),
                WithPayloadInterfaceVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
                Selector,
                typeof(global::G.PayloadSelector),
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
        public bool Equals(WithPayloadInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(WithPayloadInterfaceVariant1, other.WithPayloadInterfaceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(WithPayloadInterfaceVariant2, other.WithPayloadInterfaceVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadSelector?>.Default.Equals(Selector, other.Selector) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WithPayloadInterface obj1, WithPayloadInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WithPayloadInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WithPayloadInterface obj1, WithPayloadInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WithPayloadInterface o && Equals(o);
        }
    }
}
