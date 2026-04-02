//HintName: G.Models.LemurStringResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// LeMUR string response<br/>
    /// Example: {"request_id":"5e1b27c2-691f-4414-8bc5-f14678442f9e","response":"Based on the transcript, the following locations were mentioned as being affected by wildfire smoke from Canada:\n\n- Maine\n- Maryland\n- Minnesota\n- Mid Atlantic region\n- Northeast region\n- New York City\n- Baltimore\n","usage":{"input_tokens":27,"output_tokens":3}}
    /// </summary>
    public readonly partial struct LemurStringResponse : global::System.IEquatable<LemurStringResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurStringResponseVariant1? LemurStringResponseVariant1 { get; init; }
#else
        public global::G.LemurStringResponseVariant1? LemurStringResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LemurStringResponseVariant1))]
#endif
        public bool IsLemurStringResponseVariant1 => LemurStringResponseVariant1 != null;

        /// <summary>
        /// LeMUR base response<br/>
        /// Example: {"request_id":"5e1b27c2-691f-4414-8bc5-f14678442f9e","usage":{"input_tokens":27,"output_tokens":3}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurBaseResponse? Base { get; init; }
#else
        public global::G.LemurBaseResponse? Base { get; }
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
        public static implicit operator LemurStringResponse(global::G.LemurStringResponseVariant1 value) => new LemurStringResponse((global::G.LemurStringResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurStringResponseVariant1?(LemurStringResponse @this) => @this.LemurStringResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public LemurStringResponse(global::G.LemurStringResponseVariant1? value)
        {
            LemurStringResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurStringResponse(global::G.LemurBaseResponse value) => new LemurStringResponse((global::G.LemurBaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurBaseResponse?(LemurStringResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LemurStringResponse(global::G.LemurBaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurStringResponse(
            global::G.LemurStringResponseVariant1? lemurStringResponseVariant1,
            global::G.LemurBaseResponse? @base
            )
        {
            LemurStringResponseVariant1 = lemurStringResponseVariant1;
            Base = @base;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base as object ??
            LemurStringResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LemurStringResponseVariant1?.ToString() ??
            Base?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLemurStringResponseVariant1 && IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurStringResponseVariant1?, TResult>? lemurStringResponseVariant1 = null,
            global::System.Func<global::G.LemurBaseResponse?, TResult>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLemurStringResponseVariant1 && lemurStringResponseVariant1 != null)
            {
                return lemurStringResponseVariant1(LemurStringResponseVariant1!);
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
            global::System.Action<global::G.LemurStringResponseVariant1?>? lemurStringResponseVariant1 = null,
            global::System.Action<global::G.LemurBaseResponse?>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLemurStringResponseVariant1)
            {
                lemurStringResponseVariant1?.Invoke(LemurStringResponseVariant1!);
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
                LemurStringResponseVariant1,
                typeof(global::G.LemurStringResponseVariant1),
                Base,
                typeof(global::G.LemurBaseResponse),
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
        public bool Equals(LemurStringResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurStringResponseVariant1?>.Default.Equals(LemurStringResponseVariant1, other.LemurStringResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LemurBaseResponse?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurStringResponse obj1, LemurStringResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurStringResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurStringResponse obj1, LemurStringResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurStringResponse o && Equals(o);
        }
    }
}
