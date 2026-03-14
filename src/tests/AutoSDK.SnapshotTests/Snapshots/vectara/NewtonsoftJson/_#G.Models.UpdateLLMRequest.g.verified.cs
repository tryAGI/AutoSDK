//HintName: G.Models.UpdateLLMRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update a Large Language Model connection. All fields are optional - only provide fields you want to change. Only the name field is immutable.
    /// </summary>
    public readonly partial struct UpdateLLMRequest : global::System.IEquatable<UpdateLLMRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateLLMRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request to update an OpenAI-compatible Large Language Model connection. All fields are optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateOpenAILLMRequest? OpenaiCompatible { get; init; }
#else
        public global::G.UpdateOpenAILLMRequest? OpenaiCompatible { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiCompatible))]
#endif
        public bool IsOpenaiCompatible => OpenaiCompatible != null;

        /// <summary>
        /// Request to update an OpenAI Responses API Large Language Model connection. All fields are optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateOpenAIResponsesLLMRequest? OpenaiResponses { get; init; }
#else
        public global::G.UpdateOpenAIResponsesLLMRequest? OpenaiResponses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiResponses))]
#endif
        public bool IsOpenaiResponses => OpenaiResponses != null;

        /// <summary>
        /// Request to update a Vertex AI Large Language Model connection. All fields are optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateVertexAILLMRequest? VertexAi { get; init; }
#else
        public global::G.UpdateVertexAILLMRequest? VertexAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexAi))]
#endif
        public bool IsVertexAi => VertexAi != null;

        /// <summary>
        /// Request to update an Anthropic Large Language Model connection. All fields are optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateAnthropicLLMRequest? Anthropic { get; init; }
#else
        public global::G.UpdateAnthropicLLMRequest? Anthropic { get; }
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
        public static implicit operator UpdateLLMRequest(global::G.UpdateOpenAILLMRequest value) => new UpdateLLMRequest((global::G.UpdateOpenAILLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateOpenAILLMRequest?(UpdateLLMRequest @this) => @this.OpenaiCompatible;

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(global::G.UpdateOpenAILLMRequest? value)
        {
            OpenaiCompatible = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateLLMRequest(global::G.UpdateOpenAIResponsesLLMRequest value) => new UpdateLLMRequest((global::G.UpdateOpenAIResponsesLLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateOpenAIResponsesLLMRequest?(UpdateLLMRequest @this) => @this.OpenaiResponses;

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(global::G.UpdateOpenAIResponsesLLMRequest? value)
        {
            OpenaiResponses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateLLMRequest(global::G.UpdateVertexAILLMRequest value) => new UpdateLLMRequest((global::G.UpdateVertexAILLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateVertexAILLMRequest?(UpdateLLMRequest @this) => @this.VertexAi;

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(global::G.UpdateVertexAILLMRequest? value)
        {
            VertexAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateLLMRequest(global::G.UpdateAnthropicLLMRequest value) => new UpdateLLMRequest((global::G.UpdateAnthropicLLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateAnthropicLLMRequest?(UpdateLLMRequest @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(global::G.UpdateAnthropicLLMRequest? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(
            global::G.UpdateLLMRequestDiscriminatorType? type,
            global::G.UpdateOpenAILLMRequest? openaiCompatible,
            global::G.UpdateOpenAIResponsesLLMRequest? openaiResponses,
            global::G.UpdateVertexAILLMRequest? vertexAi,
            global::G.UpdateAnthropicLLMRequest? anthropic
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
            global::System.Func<global::G.UpdateOpenAILLMRequest?, TResult>? openaiCompatible = null,
            global::System.Func<global::G.UpdateOpenAIResponsesLLMRequest?, TResult>? openaiResponses = null,
            global::System.Func<global::G.UpdateVertexAILLMRequest?, TResult>? vertexAi = null,
            global::System.Func<global::G.UpdateAnthropicLLMRequest?, TResult>? anthropic = null,
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
            global::System.Action<global::G.UpdateOpenAILLMRequest?>? openaiCompatible = null,
            global::System.Action<global::G.UpdateOpenAIResponsesLLMRequest?>? openaiResponses = null,
            global::System.Action<global::G.UpdateVertexAILLMRequest?>? vertexAi = null,
            global::System.Action<global::G.UpdateAnthropicLLMRequest?>? anthropic = null,
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
                typeof(global::G.UpdateOpenAILLMRequest),
                OpenaiResponses,
                typeof(global::G.UpdateOpenAIResponsesLLMRequest),
                VertexAi,
                typeof(global::G.UpdateVertexAILLMRequest),
                Anthropic,
                typeof(global::G.UpdateAnthropicLLMRequest),
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
        public bool Equals(UpdateLLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateOpenAILLMRequest?>.Default.Equals(OpenaiCompatible, other.OpenaiCompatible) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateOpenAIResponsesLLMRequest?>.Default.Equals(OpenaiResponses, other.OpenaiResponses) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateVertexAILLMRequest?>.Default.Equals(VertexAi, other.VertexAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateAnthropicLLMRequest?>.Default.Equals(Anthropic, other.Anthropic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateLLMRequest obj1, UpdateLLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateLLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateLLMRequest obj1, UpdateLLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateLLMRequest o && Equals(o);
        }
    }
}
