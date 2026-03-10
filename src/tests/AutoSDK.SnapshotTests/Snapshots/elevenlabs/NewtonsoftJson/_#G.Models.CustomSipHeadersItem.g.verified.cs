//HintName: G.Models.CustomSipHeadersItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomSipHeadersItem : global::System.IEquatable<CustomSipHeadersItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PhoneNumberTransferCustomSipHeaderDiscriminatorType? Type { get; }

        /// <summary>
        /// Custom SIP header for phone transfers with a static (validated) value.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomSIPHeader? Dynamic1 { get; init; }
#else
        public global::G.CustomSIPHeader? Dynamic1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dynamic1))]
#endif
        public bool IsDynamic1 => Dynamic1 != null;

        /// <summary>
        /// Custom SIP header for phone transfers with a dynamic variable reference.<br/>
        /// The value is a variable name that will be resolved at runtime.<br/>
        /// Value is not validated here since it will be substituted with actual value later.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomSIPHeaderWithDynamicVariable? Dynamic2 { get; init; }
#else
        public global::G.CustomSIPHeaderWithDynamicVariable? Dynamic2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dynamic2))]
#endif
        public bool IsDynamic2 => Dynamic2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomSipHeadersItem(global::G.CustomSIPHeader value) => new CustomSipHeadersItem((global::G.CustomSIPHeader?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomSIPHeader?(CustomSipHeadersItem @this) => @this.Dynamic1;

        /// <summary>
        /// 
        /// </summary>
        public CustomSipHeadersItem(global::G.CustomSIPHeader? value)
        {
            Dynamic1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomSipHeadersItem(global::G.CustomSIPHeaderWithDynamicVariable value) => new CustomSipHeadersItem((global::G.CustomSIPHeaderWithDynamicVariable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomSIPHeaderWithDynamicVariable?(CustomSipHeadersItem @this) => @this.Dynamic2;

        /// <summary>
        /// 
        /// </summary>
        public CustomSipHeadersItem(global::G.CustomSIPHeaderWithDynamicVariable? value)
        {
            Dynamic2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomSipHeadersItem(
            global::G.PhoneNumberTransferCustomSipHeaderDiscriminatorType? type,
            global::G.CustomSIPHeader? dynamic1,
            global::G.CustomSIPHeaderWithDynamicVariable? dynamic2
            )
        {
            Type = type;

            Dynamic1 = dynamic1;
            Dynamic2 = dynamic2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dynamic2 as object ??
            Dynamic1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dynamic1?.ToString() ??
            Dynamic2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDynamic1 && !IsDynamic2 || !IsDynamic1 && IsDynamic2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CustomSIPHeader?, TResult>? dynamic1 = null,
            global::System.Func<global::G.CustomSIPHeaderWithDynamicVariable?, TResult>? dynamic2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamic1 && dynamic1 != null)
            {
                return dynamic1(Dynamic1!);
            }
            else if (IsDynamic2 && dynamic2 != null)
            {
                return dynamic2(Dynamic2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CustomSIPHeader?>? dynamic1 = null,
            global::System.Action<global::G.CustomSIPHeaderWithDynamicVariable?>? dynamic2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamic1)
            {
                dynamic1?.Invoke(Dynamic1!);
            }
            else if (IsDynamic2)
            {
                dynamic2?.Invoke(Dynamic2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dynamic1,
                typeof(global::G.CustomSIPHeader),
                Dynamic2,
                typeof(global::G.CustomSIPHeaderWithDynamicVariable),
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
        public bool Equals(CustomSipHeadersItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CustomSIPHeader?>.Default.Equals(Dynamic1, other.Dynamic1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CustomSIPHeaderWithDynamicVariable?>.Default.Equals(Dynamic2, other.Dynamic2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomSipHeadersItem obj1, CustomSipHeadersItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomSipHeadersItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomSipHeadersItem obj1, CustomSipHeadersItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomSipHeadersItem o && Equals(o);
        }
    }
}
