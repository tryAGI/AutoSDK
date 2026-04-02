//HintName: G.Models.CreateOpenAIResponsesLLMRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create an OpenAI Responses API Large Language Model connection for reasoning models like o1, o3.
    /// </summary>
    public readonly partial struct CreateOpenAIResponsesLLMRequest : global::System.IEquatable<CreateOpenAIResponsesLLMRequest>
    {
        /// <summary>
        /// Common fields for OpenAI-compatible and Responses API LLM requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAILLMRequestBase? Base { get; init; }
#else
        public global::G.OpenAILLMRequestBase? Base { get; }
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
        public global::G.CreateOpenAIResponsesLLMRequestVariant2? CreateOpenAIResponsesLLMRequestVariant2 { get; init; }
#else
        public global::G.CreateOpenAIResponsesLLMRequestVariant2? CreateOpenAIResponsesLLMRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateOpenAIResponsesLLMRequestVariant2))]
#endif
        public bool IsCreateOpenAIResponsesLLMRequestVariant2 => CreateOpenAIResponsesLLMRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateOpenAIResponsesLLMRequest(global::G.OpenAILLMRequestBase value) => new CreateOpenAIResponsesLLMRequest((global::G.OpenAILLMRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAILLMRequestBase?(CreateOpenAIResponsesLLMRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAIResponsesLLMRequest(global::G.OpenAILLMRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateOpenAIResponsesLLMRequest(global::G.CreateOpenAIResponsesLLMRequestVariant2 value) => new CreateOpenAIResponsesLLMRequest((global::G.CreateOpenAIResponsesLLMRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateOpenAIResponsesLLMRequestVariant2?(CreateOpenAIResponsesLLMRequest @this) => @this.CreateOpenAIResponsesLLMRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAIResponsesLLMRequest(global::G.CreateOpenAIResponsesLLMRequestVariant2? value)
        {
            CreateOpenAIResponsesLLMRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAIResponsesLLMRequest(
            global::G.OpenAILLMRequestBase? @base,
            global::G.CreateOpenAIResponsesLLMRequestVariant2? createOpenAIResponsesLLMRequestVariant2
            )
        {
            Base = @base;
            CreateOpenAIResponsesLLMRequestVariant2 = createOpenAIResponsesLLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateOpenAIResponsesLLMRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateOpenAIResponsesLLMRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateOpenAIResponsesLLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OpenAILLMRequestBase?, TResult>? @base = null,
            global::System.Func<global::G.CreateOpenAIResponsesLLMRequestVariant2?, TResult>? createOpenAIResponsesLLMRequestVariant2 = null,
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
            else if (IsCreateOpenAIResponsesLLMRequestVariant2 && createOpenAIResponsesLLMRequestVariant2 != null)
            {
                return createOpenAIResponsesLLMRequestVariant2(CreateOpenAIResponsesLLMRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OpenAILLMRequestBase?>? @base = null,
            global::System.Action<global::G.CreateOpenAIResponsesLLMRequestVariant2?>? createOpenAIResponsesLLMRequestVariant2 = null,
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
            else if (IsCreateOpenAIResponsesLLMRequestVariant2)
            {
                createOpenAIResponsesLLMRequestVariant2?.Invoke(CreateOpenAIResponsesLLMRequestVariant2!);
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
                typeof(global::G.OpenAILLMRequestBase),
                CreateOpenAIResponsesLLMRequestVariant2,
                typeof(global::G.CreateOpenAIResponsesLLMRequestVariant2),
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
        public bool Equals(CreateOpenAIResponsesLLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAILLMRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateOpenAIResponsesLLMRequestVariant2?>.Default.Equals(CreateOpenAIResponsesLLMRequestVariant2, other.CreateOpenAIResponsesLLMRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateOpenAIResponsesLLMRequest obj1, CreateOpenAIResponsesLLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateOpenAIResponsesLLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateOpenAIResponsesLLMRequest obj1, CreateOpenAIResponsesLLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateOpenAIResponsesLLMRequest o && Equals(o);
        }
    }
}
