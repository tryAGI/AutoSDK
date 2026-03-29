//HintName: G.Models.V2CallResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2CallResponse : global::System.IEquatable<V2CallResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.V2WebCallResponse? Web { get; init; }
#else
        public global::G.V2WebCallResponse? Web { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Web))]
#endif
        public bool IsWeb => Web != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.V2PhoneCallResponse? Phone { get; init; }
#else
        public global::G.V2PhoneCallResponse? Phone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Phone))]
#endif
        public bool IsPhone => Phone != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2CallResponse(global::G.V2WebCallResponse value) => new V2CallResponse((global::G.V2WebCallResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.V2WebCallResponse?(V2CallResponse @this) => @this.Web;

        /// <summary>
        /// 
        /// </summary>
        public V2CallResponse(global::G.V2WebCallResponse? value)
        {
            Web = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2CallResponse(global::G.V2PhoneCallResponse value) => new V2CallResponse((global::G.V2PhoneCallResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.V2PhoneCallResponse?(V2CallResponse @this) => @this.Phone;

        /// <summary>
        /// 
        /// </summary>
        public V2CallResponse(global::G.V2PhoneCallResponse? value)
        {
            Phone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V2CallResponse(
            global::G.V2WebCallResponse? web,
            global::G.V2PhoneCallResponse? phone
            )
        {
            Web = web;
            Phone = phone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Phone as object ??
            Web as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Web?.ToString() ??
            Phone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWeb && !IsPhone || !IsWeb && IsPhone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.V2WebCallResponse?, TResult>? web = null,
            global::System.Func<global::G.V2PhoneCallResponse?, TResult>? phone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWeb && web != null)
            {
                return web(Web!);
            }
            else if (IsPhone && phone != null)
            {
                return phone(Phone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.V2WebCallResponse?>? web = null,
            global::System.Action<global::G.V2PhoneCallResponse?>? phone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWeb)
            {
                web?.Invoke(Web!);
            }
            else if (IsPhone)
            {
                phone?.Invoke(Phone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Web,
                typeof(global::G.V2WebCallResponse),
                Phone,
                typeof(global::G.V2PhoneCallResponse),
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
        public bool Equals(V2CallResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.V2WebCallResponse?>.Default.Equals(Web, other.Web) &&
                global::System.Collections.Generic.EqualityComparer<global::G.V2PhoneCallResponse?>.Default.Equals(Phone, other.Phone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2CallResponse obj1, V2CallResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2CallResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2CallResponse obj1, V2CallResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2CallResponse o && Equals(o);
        }
    }
}
