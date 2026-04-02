//HintName: G.Models.LemurQuestionAnswerResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// LeMUR question &amp; answer response<br/>
    /// Example: {"request_id":"5e1b27c2-691f-4414-8bc5-f14678442f9e","response":[{"answer":"CA, US","question":"Where are there wildfires?"},{"answer":"yes","question":"Is global warming affecting wildfires?"}],"usage":{"input_tokens":27,"output_tokens":3}}
    /// </summary>
    public readonly partial struct LemurQuestionAnswerResponse : global::System.IEquatable<LemurQuestionAnswerResponse>
    {
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
#if NET6_0_OR_GREATER
        public global::G.LemurQuestionAnswerResponseVariant2? LemurQuestionAnswerResponseVariant2 { get; init; }
#else
        public global::G.LemurQuestionAnswerResponseVariant2? LemurQuestionAnswerResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LemurQuestionAnswerResponseVariant2))]
#endif
        public bool IsLemurQuestionAnswerResponseVariant2 => LemurQuestionAnswerResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurQuestionAnswerResponse(global::G.LemurBaseResponse value) => new LemurQuestionAnswerResponse((global::G.LemurBaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurBaseResponse?(LemurQuestionAnswerResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerResponse(global::G.LemurBaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurQuestionAnswerResponse(global::G.LemurQuestionAnswerResponseVariant2 value) => new LemurQuestionAnswerResponse((global::G.LemurQuestionAnswerResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurQuestionAnswerResponseVariant2?(LemurQuestionAnswerResponse @this) => @this.LemurQuestionAnswerResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerResponse(global::G.LemurQuestionAnswerResponseVariant2? value)
        {
            LemurQuestionAnswerResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerResponse(
            global::G.LemurBaseResponse? @base,
            global::G.LemurQuestionAnswerResponseVariant2? lemurQuestionAnswerResponseVariant2
            )
        {
            Base = @base;
            LemurQuestionAnswerResponseVariant2 = lemurQuestionAnswerResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LemurQuestionAnswerResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            LemurQuestionAnswerResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsLemurQuestionAnswerResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurBaseResponse?, TResult>? @base = null,
            global::System.Func<global::G.LemurQuestionAnswerResponseVariant2?, TResult>? lemurQuestionAnswerResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsLemurQuestionAnswerResponseVariant2 && lemurQuestionAnswerResponseVariant2 != null)
            {
                return lemurQuestionAnswerResponseVariant2(LemurQuestionAnswerResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurBaseResponse?>? @base = null,
            global::System.Action<global::G.LemurQuestionAnswerResponseVariant2?>? lemurQuestionAnswerResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsLemurQuestionAnswerResponseVariant2)
            {
                lemurQuestionAnswerResponseVariant2?.Invoke(LemurQuestionAnswerResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.LemurBaseResponse),
                LemurQuestionAnswerResponseVariant2,
                typeof(global::G.LemurQuestionAnswerResponseVariant2),
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
        public bool Equals(LemurQuestionAnswerResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurBaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LemurQuestionAnswerResponseVariant2?>.Default.Equals(LemurQuestionAnswerResponseVariant2, other.LemurQuestionAnswerResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurQuestionAnswerResponse obj1, LemurQuestionAnswerResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurQuestionAnswerResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurQuestionAnswerResponse obj1, LemurQuestionAnswerResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurQuestionAnswerResponse o && Equals(o);
        }
    }
}
