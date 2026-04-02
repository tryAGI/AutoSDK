//HintName: G.Models.UpdateOpenAILLMRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an OpenAI-compatible Large Language Model connection. All fields are optional.
    /// </summary>
    public readonly partial struct UpdateOpenAILLMRequest : global::System.IEquatable<UpdateOpenAILLMRequest>
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
        public global::G.UpdateOpenAILLMRequestVariant2? UpdateOpenAILLMRequestVariant2 { get; init; }
#else
        public global::G.UpdateOpenAILLMRequestVariant2? UpdateOpenAILLMRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateOpenAILLMRequestVariant2))]
#endif
        public bool IsUpdateOpenAILLMRequestVariant2 => UpdateOpenAILLMRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOpenAILLMRequest(global::G.OpenAILLMUpdateBase value) => new UpdateOpenAILLMRequest((global::G.OpenAILLMUpdateBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAILLMUpdateBase?(UpdateOpenAILLMRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAILLMRequest(global::G.OpenAILLMUpdateBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOpenAILLMRequest(global::G.UpdateOpenAILLMRequestVariant2 value) => new UpdateOpenAILLMRequest((global::G.UpdateOpenAILLMRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateOpenAILLMRequestVariant2?(UpdateOpenAILLMRequest @this) => @this.UpdateOpenAILLMRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAILLMRequest(global::G.UpdateOpenAILLMRequestVariant2? value)
        {
            UpdateOpenAILLMRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAILLMRequest(
            global::G.OpenAILLMUpdateBase? @base,
            global::G.UpdateOpenAILLMRequestVariant2? updateOpenAILLMRequestVariant2
            )
        {
            Base = @base;
            UpdateOpenAILLMRequestVariant2 = updateOpenAILLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateOpenAILLMRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            UpdateOpenAILLMRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsUpdateOpenAILLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OpenAILLMUpdateBase?, TResult>? @base = null,
            global::System.Func<global::G.UpdateOpenAILLMRequestVariant2?, TResult>? updateOpenAILLMRequestVariant2 = null,
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
            else if (IsUpdateOpenAILLMRequestVariant2 && updateOpenAILLMRequestVariant2 != null)
            {
                return updateOpenAILLMRequestVariant2(UpdateOpenAILLMRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OpenAILLMUpdateBase?>? @base = null,
            global::System.Action<global::G.UpdateOpenAILLMRequestVariant2?>? updateOpenAILLMRequestVariant2 = null,
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
            else if (IsUpdateOpenAILLMRequestVariant2)
            {
                updateOpenAILLMRequestVariant2?.Invoke(UpdateOpenAILLMRequestVariant2!);
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
                UpdateOpenAILLMRequestVariant2,
                typeof(global::G.UpdateOpenAILLMRequestVariant2),
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
        public bool Equals(UpdateOpenAILLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAILLMUpdateBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateOpenAILLMRequestVariant2?>.Default.Equals(UpdateOpenAILLMRequestVariant2, other.UpdateOpenAILLMRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateOpenAILLMRequest obj1, UpdateOpenAILLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateOpenAILLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateOpenAILLMRequest obj1, UpdateOpenAILLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateOpenAILLMRequest o && Equals(o);
        }
    }
}
