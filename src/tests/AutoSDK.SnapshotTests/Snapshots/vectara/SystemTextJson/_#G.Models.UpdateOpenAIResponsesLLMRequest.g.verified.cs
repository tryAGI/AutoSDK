//HintName: G.Models.UpdateOpenAIResponsesLLMRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an OpenAI Responses API Large Language Model connection. All fields are optional.
    /// </summary>
    public readonly partial struct UpdateOpenAIResponsesLLMRequest : global::System.IEquatable<UpdateOpenAIResponsesLLMRequest>
    {
        /// <summary>
        /// Common updatable fields for OpenAI-compatible and Responses API LLM requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAILLMUpdateBase? Base { get; init; }
#else
        public global::G.OpenAILLMUpdateBase? Base { get; }
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
        public global::G.UpdateOpenAIResponsesLLMRequestVariant2? UpdateOpenAIResponsesLLMRequestVariant2 { get; init; }
#else
        public global::G.UpdateOpenAIResponsesLLMRequestVariant2? UpdateOpenAIResponsesLLMRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateOpenAIResponsesLLMRequestVariant2))]
#endif
        public bool IsUpdateOpenAIResponsesLLMRequestVariant2 => UpdateOpenAIResponsesLLMRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOpenAIResponsesLLMRequest(global::G.OpenAILLMUpdateBase value) => new UpdateOpenAIResponsesLLMRequest((global::G.OpenAILLMUpdateBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAILLMUpdateBase?(UpdateOpenAIResponsesLLMRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAIResponsesLLMRequest(global::G.OpenAILLMUpdateBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOpenAIResponsesLLMRequest(global::G.UpdateOpenAIResponsesLLMRequestVariant2 value) => new UpdateOpenAIResponsesLLMRequest((global::G.UpdateOpenAIResponsesLLMRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateOpenAIResponsesLLMRequestVariant2?(UpdateOpenAIResponsesLLMRequest @this) => @this.UpdateOpenAIResponsesLLMRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAIResponsesLLMRequest(global::G.UpdateOpenAIResponsesLLMRequestVariant2? value)
        {
            UpdateOpenAIResponsesLLMRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAIResponsesLLMRequest(
            global::G.OpenAILLMUpdateBase? @base,
            global::G.UpdateOpenAIResponsesLLMRequestVariant2? updateOpenAIResponsesLLMRequestVariant2
            )
        {
            Base = @base;
            UpdateOpenAIResponsesLLMRequestVariant2 = updateOpenAIResponsesLLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateOpenAIResponsesLLMRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            UpdateOpenAIResponsesLLMRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsUpdateOpenAIResponsesLLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OpenAILLMUpdateBase?, TResult>? @base = null,
            global::System.Func<global::G.UpdateOpenAIResponsesLLMRequestVariant2?, TResult>? updateOpenAIResponsesLLMRequestVariant2 = null,
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
            else if (IsUpdateOpenAIResponsesLLMRequestVariant2 && updateOpenAIResponsesLLMRequestVariant2 != null)
            {
                return updateOpenAIResponsesLLMRequestVariant2(UpdateOpenAIResponsesLLMRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OpenAILLMUpdateBase?>? @base = null,
            global::System.Action<global::G.UpdateOpenAIResponsesLLMRequestVariant2?>? updateOpenAIResponsesLLMRequestVariant2 = null,
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
            else if (IsUpdateOpenAIResponsesLLMRequestVariant2)
            {
                updateOpenAIResponsesLLMRequestVariant2?.Invoke(UpdateOpenAIResponsesLLMRequestVariant2!);
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
                typeof(global::G.OpenAILLMUpdateBase),
                UpdateOpenAIResponsesLLMRequestVariant2,
                typeof(global::G.UpdateOpenAIResponsesLLMRequestVariant2),
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
        public bool Equals(UpdateOpenAIResponsesLLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAILLMUpdateBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateOpenAIResponsesLLMRequestVariant2?>.Default.Equals(UpdateOpenAIResponsesLLMRequestVariant2, other.UpdateOpenAIResponsesLLMRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateOpenAIResponsesLLMRequest obj1, UpdateOpenAIResponsesLLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateOpenAIResponsesLLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateOpenAIResponsesLLMRequest obj1, UpdateOpenAIResponsesLLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateOpenAIResponsesLLMRequest o && Equals(o);
        }
    }
}
