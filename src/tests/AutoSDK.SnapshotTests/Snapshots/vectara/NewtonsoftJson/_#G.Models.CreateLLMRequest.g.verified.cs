//HintName: G.Models.CreateLLMRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a Large Language Model connection for generative capabilities.
    /// </summary>
    public readonly partial struct CreateLLMRequest : global::System.IEquatable<CreateLLMRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateLLMRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request to create an OpenAI-compatible Large Language Model connection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateOpenAILLMRequest? OpenaiCompatible { get; init; }
#else
        public global::G.CreateOpenAILLMRequest? OpenaiCompatible { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiCompatible))]
#endif
        public bool IsOpenaiCompatible => OpenaiCompatible != null;

        /// <summary>
        /// Request to create an OpenAI Responses API Large Language Model connection for reasoning models like o1, o3.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateOpenAIResponsesLLMRequest? OpenaiResponses { get; init; }
#else
        public global::G.CreateOpenAIResponsesLLMRequest? OpenaiResponses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiResponses))]
#endif
        public bool IsOpenaiResponses => OpenaiResponses != null;

        /// <summary>
        /// Request to create a Vertex AI Large Language Model connection for Gemini models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateVertexAILLMRequest? VertexAi { get; init; }
#else
        public global::G.CreateVertexAILLMRequest? VertexAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexAi))]
#endif
        public bool IsVertexAi => VertexAi != null;

        /// <summary>
        /// Request to create an Anthropic Large Language Model connection for Claude models (direct API, Bedrock, or Vertex).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAnthropicLLMRequest? Anthropic { get; init; }
#else
        public global::G.CreateAnthropicLLMRequest? Anthropic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::G.CreateOpenAILLMRequest value) => new CreateLLMRequest((global::G.CreateOpenAILLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateOpenAILLMRequest?(CreateLLMRequest @this) => @this.OpenaiCompatible;

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(global::G.CreateOpenAILLMRequest? value)
        {
            OpenaiCompatible = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::G.CreateOpenAIResponsesLLMRequest value) => new CreateLLMRequest((global::G.CreateOpenAIResponsesLLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateOpenAIResponsesLLMRequest?(CreateLLMRequest @this) => @this.OpenaiResponses;

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(global::G.CreateOpenAIResponsesLLMRequest? value)
        {
            OpenaiResponses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::G.CreateVertexAILLMRequest value) => new CreateLLMRequest((global::G.CreateVertexAILLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVertexAILLMRequest?(CreateLLMRequest @this) => @this.VertexAi;

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(global::G.CreateVertexAILLMRequest? value)
        {
            VertexAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::G.CreateAnthropicLLMRequest value) => new CreateLLMRequest((global::G.CreateAnthropicLLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAnthropicLLMRequest?(CreateLLMRequest @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(global::G.CreateAnthropicLLMRequest? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(
            global::G.CreateLLMRequestDiscriminatorType? type,
            global::G.CreateOpenAILLMRequest? openaiCompatible,
            global::G.CreateOpenAIResponsesLLMRequest? openaiResponses,
            global::G.CreateVertexAILLMRequest? vertexAi,
            global::G.CreateAnthropicLLMRequest? anthropic
            )
        {
            Type = type;

            OpenaiCompatible = openaiCompatible;
            OpenaiResponses = openaiResponses;
            VertexAi = vertexAi;
            Anthropic = anthropic;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Anthropic as object ??
            VertexAi as object ??
            OpenaiResponses as object ??
            OpenaiCompatible as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenaiCompatible?.ToString() ??
            OpenaiResponses?.ToString() ??
            VertexAi?.ToString() ??
            Anthropic?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenaiCompatible && !IsOpenaiResponses && !IsVertexAi && !IsAnthropic || !IsOpenaiCompatible && IsOpenaiResponses && !IsVertexAi && !IsAnthropic || !IsOpenaiCompatible && !IsOpenaiResponses && IsVertexAi && !IsAnthropic || !IsOpenaiCompatible && !IsOpenaiResponses && !IsVertexAi && IsAnthropic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateOpenAILLMRequest?, TResult>? openaiCompatible = null,
            global::System.Func<global::G.CreateOpenAIResponsesLLMRequest?, TResult>? openaiResponses = null,
            global::System.Func<global::G.CreateVertexAILLMRequest?, TResult>? vertexAi = null,
            global::System.Func<global::G.CreateAnthropicLLMRequest?, TResult>? anthropic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenaiCompatible && openaiCompatible != null)
            {
                return openaiCompatible(OpenaiCompatible!);
            }
            else if (IsOpenaiResponses && openaiResponses != null)
            {
                return openaiResponses(OpenaiResponses!);
            }
            else if (IsVertexAi && vertexAi != null)
            {
                return vertexAi(VertexAi!);
            }
            else if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateOpenAILLMRequest?>? openaiCompatible = null,
            global::System.Action<global::G.CreateOpenAIResponsesLLMRequest?>? openaiResponses = null,
            global::System.Action<global::G.CreateVertexAILLMRequest?>? vertexAi = null,
            global::System.Action<global::G.CreateAnthropicLLMRequest?>? anthropic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenaiCompatible)
            {
                openaiCompatible?.Invoke(OpenaiCompatible!);
            }
            else if (IsOpenaiResponses)
            {
                openaiResponses?.Invoke(OpenaiResponses!);
            }
            else if (IsVertexAi)
            {
                vertexAi?.Invoke(VertexAi!);
            }
            else if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenaiCompatible,
                typeof(global::G.CreateOpenAILLMRequest),
                OpenaiResponses,
                typeof(global::G.CreateOpenAIResponsesLLMRequest),
                VertexAi,
                typeof(global::G.CreateVertexAILLMRequest),
                Anthropic,
                typeof(global::G.CreateAnthropicLLMRequest),
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
        public bool Equals(CreateLLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateOpenAILLMRequest?>.Default.Equals(OpenaiCompatible, other.OpenaiCompatible) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateOpenAIResponsesLLMRequest?>.Default.Equals(OpenaiResponses, other.OpenaiResponses) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVertexAILLMRequest?>.Default.Equals(VertexAi, other.VertexAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAnthropicLLMRequest?>.Default.Equals(Anthropic, other.Anthropic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateLLMRequest obj1, CreateLLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateLLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateLLMRequest obj1, CreateLLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateLLMRequest o && Equals(o);
        }
    }
}
