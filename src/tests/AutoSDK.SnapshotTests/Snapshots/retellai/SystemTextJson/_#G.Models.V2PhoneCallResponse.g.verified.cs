//HintName: G.Models.V2PhoneCallResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2PhoneCallResponse : global::System.IEquatable<V2PhoneCallResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.V2PhoneCallResponseVariant1? V2PhoneCallResponseVariant1 { get; init; }
#else
        public global::G.V2PhoneCallResponseVariant1? V2PhoneCallResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2PhoneCallResponseVariant1))]
#endif
        public bool IsV2PhoneCallResponseVariant1 => V2PhoneCallResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.V2CallBase? Base { get; init; }
#else
        public global::G.V2CallBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2PhoneCallResponse(global::G.V2PhoneCallResponseVariant1 value) => new V2PhoneCallResponse((global::G.V2PhoneCallResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.V2PhoneCallResponseVariant1?(V2PhoneCallResponse @this) => @this.V2PhoneCallResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V2PhoneCallResponse(global::G.V2PhoneCallResponseVariant1? value)
        {
            V2PhoneCallResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2PhoneCallResponse(global::G.V2CallBase value) => new V2PhoneCallResponse((global::G.V2CallBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.V2CallBase?(V2PhoneCallResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public V2PhoneCallResponse(global::G.V2CallBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V2PhoneCallResponse(
            global::G.V2PhoneCallResponseVariant1? v2PhoneCallResponseVariant1,
            global::G.V2CallBase? @base
            )
        {
            V2PhoneCallResponseVariant1 = v2PhoneCallResponseVariant1;
            Base = @base;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base as object ??
            V2PhoneCallResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V2PhoneCallResponseVariant1?.ToString() ??
            Base?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV2PhoneCallResponseVariant1 && IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.V2PhoneCallResponseVariant1?, TResult>? v2PhoneCallResponseVariant1 = null,
            global::System.Func<global::G.V2CallBase?, TResult>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2PhoneCallResponseVariant1 && v2PhoneCallResponseVariant1 != null)
            {
                return v2PhoneCallResponseVariant1(V2PhoneCallResponseVariant1!);
            }
            else if (IsBase && @base != null)
            {
                return @base(Base!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.V2PhoneCallResponseVariant1?>? v2PhoneCallResponseVariant1 = null,
            global::System.Action<global::G.V2CallBase?>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2PhoneCallResponseVariant1)
            {
                v2PhoneCallResponseVariant1?.Invoke(V2PhoneCallResponseVariant1!);
            }
            else if (IsBase)
            {
                @base?.Invoke(Base!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V2PhoneCallResponseVariant1,
                typeof(global::G.V2PhoneCallResponseVariant1),
                Base,
                typeof(global::G.V2CallBase),
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
        public bool Equals(V2PhoneCallResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.V2PhoneCallResponseVariant1?>.Default.Equals(V2PhoneCallResponseVariant1, other.V2PhoneCallResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.V2CallBase?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2PhoneCallResponse obj1, V2PhoneCallResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2PhoneCallResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2PhoneCallResponse obj1, V2PhoneCallResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2PhoneCallResponse o && Equals(o);
        }
    }
}
