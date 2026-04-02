//HintName: G.Models.CreateOpenAILLMRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create an OpenAI-compatible Large Language Model connection.
    /// </summary>
    public readonly partial struct CreateOpenAILLMRequest : global::System.IEquatable<CreateOpenAILLMRequest>
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
        public global::G.CreateOpenAILLMRequestVariant2? CreateOpenAILLMRequestVariant2 { get; init; }
#else
        public global::G.CreateOpenAILLMRequestVariant2? CreateOpenAILLMRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateOpenAILLMRequestVariant2))]
#endif
        public bool IsCreateOpenAILLMRequestVariant2 => CreateOpenAILLMRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateOpenAILLMRequest(global::G.OpenAILLMRequestBase value) => new CreateOpenAILLMRequest((global::G.OpenAILLMRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAILLMRequestBase?(CreateOpenAILLMRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAILLMRequest(global::G.OpenAILLMRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateOpenAILLMRequest(global::G.CreateOpenAILLMRequestVariant2 value) => new CreateOpenAILLMRequest((global::G.CreateOpenAILLMRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateOpenAILLMRequestVariant2?(CreateOpenAILLMRequest @this) => @this.CreateOpenAILLMRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAILLMRequest(global::G.CreateOpenAILLMRequestVariant2? value)
        {
            CreateOpenAILLMRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAILLMRequest(
            global::G.OpenAILLMRequestBase? @base,
            global::G.CreateOpenAILLMRequestVariant2? createOpenAILLMRequestVariant2
            )
        {
            Base = @base;
            CreateOpenAILLMRequestVariant2 = createOpenAILLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateOpenAILLMRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateOpenAILLMRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateOpenAILLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OpenAILLMRequestBase?, TResult>? @base = null,
            global::System.Func<global::G.CreateOpenAILLMRequestVariant2?, TResult>? createOpenAILLMRequestVariant2 = null,
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
            else if (IsCreateOpenAILLMRequestVariant2 && createOpenAILLMRequestVariant2 != null)
            {
                return createOpenAILLMRequestVariant2(CreateOpenAILLMRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OpenAILLMRequestBase?>? @base = null,
            global::System.Action<global::G.CreateOpenAILLMRequestVariant2?>? createOpenAILLMRequestVariant2 = null,
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
            else if (IsCreateOpenAILLMRequestVariant2)
            {
                createOpenAILLMRequestVariant2?.Invoke(CreateOpenAILLMRequestVariant2!);
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
                CreateOpenAILLMRequestVariant2,
                typeof(global::G.CreateOpenAILLMRequestVariant2),
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
        public bool Equals(CreateOpenAILLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAILLMRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateOpenAILLMRequestVariant2?>.Default.Equals(CreateOpenAILLMRequestVariant2, other.CreateOpenAILLMRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateOpenAILLMRequest obj1, CreateOpenAILLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateOpenAILLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateOpenAILLMRequest obj1, CreateOpenAILLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateOpenAILLMRequest o && Equals(o);
        }
    }
}
