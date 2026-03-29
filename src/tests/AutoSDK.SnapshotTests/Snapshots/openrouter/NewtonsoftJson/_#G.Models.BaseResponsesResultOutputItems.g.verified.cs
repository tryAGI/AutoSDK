//HintName: G.Models.BaseResponsesResultOutputItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseResponsesResultOutputItems : global::System.IEquatable<BaseResponsesResultOutputItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessage? OutputMessage { get; init; }
#else
        public global::G.OutputMessage? OutputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessage))]
#endif
        public bool IsOutputMessage => OutputMessage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemReasoning? OutputItemReasoning { get; init; }
#else
        public global::G.OutputItemReasoning? OutputItemReasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemReasoning))]
#endif
        public bool IsOutputItemReasoning => OutputItemReasoning != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemFunctionCall? OutputItemFunctionCall { get; init; }
#else
        public global::G.OutputItemFunctionCall? OutputItemFunctionCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemFunctionCall))]
#endif
        public bool IsOutputItemFunctionCall => OutputItemFunctionCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemWebSearchCall? OutputItemWebSearchCall { get; init; }
#else
        public global::G.OutputItemWebSearchCall? OutputItemWebSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemWebSearchCall))]
#endif
        public bool IsOutputItemWebSearchCall => OutputItemWebSearchCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemFileSearchCall? OutputItemFileSearchCall { get; init; }
#else
        public global::G.OutputItemFileSearchCall? OutputItemFileSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemFileSearchCall))]
#endif
        public bool IsOutputItemFileSearchCall => OutputItemFileSearchCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemImageGenerationCall? OutputItemImageGenerationCall { get; init; }
#else
        public global::G.OutputItemImageGenerationCall? OutputItemImageGenerationCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemImageGenerationCall))]
#endif
        public bool IsOutputItemImageGenerationCall => OutputItemImageGenerationCall != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultOutputItems(global::G.OutputMessage value) => new BaseResponsesResultOutputItems((global::G.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessage?(BaseResponsesResultOutputItems @this) => @this.OutputMessage;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultOutputItems(global::G.OutputMessage? value)
        {
            OutputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultOutputItems(global::G.OutputItemReasoning value) => new BaseResponsesResultOutputItems((global::G.OutputItemReasoning?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemReasoning?(BaseResponsesResultOutputItems @this) => @this.OutputItemReasoning;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultOutputItems(global::G.OutputItemReasoning? value)
        {
            OutputItemReasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultOutputItems(global::G.OutputItemFunctionCall value) => new BaseResponsesResultOutputItems((global::G.OutputItemFunctionCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemFunctionCall?(BaseResponsesResultOutputItems @this) => @this.OutputItemFunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultOutputItems(global::G.OutputItemFunctionCall? value)
        {
            OutputItemFunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultOutputItems(global::G.OutputItemWebSearchCall value) => new BaseResponsesResultOutputItems((global::G.OutputItemWebSearchCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemWebSearchCall?(BaseResponsesResultOutputItems @this) => @this.OutputItemWebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultOutputItems(global::G.OutputItemWebSearchCall? value)
        {
            OutputItemWebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultOutputItems(global::G.OutputItemFileSearchCall value) => new BaseResponsesResultOutputItems((global::G.OutputItemFileSearchCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemFileSearchCall?(BaseResponsesResultOutputItems @this) => @this.OutputItemFileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultOutputItems(global::G.OutputItemFileSearchCall? value)
        {
            OutputItemFileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultOutputItems(global::G.OutputItemImageGenerationCall value) => new BaseResponsesResultOutputItems((global::G.OutputItemImageGenerationCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemImageGenerationCall?(BaseResponsesResultOutputItems @this) => @this.OutputItemImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultOutputItems(global::G.OutputItemImageGenerationCall? value)
        {
            OutputItemImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultOutputItems(
            global::G.OutputMessage? outputMessage,
            global::G.OutputItemReasoning? outputItemReasoning,
            global::G.OutputItemFunctionCall? outputItemFunctionCall,
            global::G.OutputItemWebSearchCall? outputItemWebSearchCall,
            global::G.OutputItemFileSearchCall? outputItemFileSearchCall,
            global::G.OutputItemImageGenerationCall? outputItemImageGenerationCall
            )
        {
            OutputMessage = outputMessage;
            OutputItemReasoning = outputItemReasoning;
            OutputItemFunctionCall = outputItemFunctionCall;
            OutputItemWebSearchCall = outputItemWebSearchCall;
            OutputItemFileSearchCall = outputItemFileSearchCall;
            OutputItemImageGenerationCall = outputItemImageGenerationCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputItemImageGenerationCall as object ??
            OutputItemFileSearchCall as object ??
            OutputItemWebSearchCall as object ??
            OutputItemFunctionCall as object ??
            OutputItemReasoning as object ??
            OutputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputMessage?.ToString() ??
            OutputItemReasoning?.ToString() ??
            OutputItemFunctionCall?.ToString() ??
            OutputItemWebSearchCall?.ToString() ??
            OutputItemFileSearchCall?.ToString() ??
            OutputItemImageGenerationCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessage && !IsOutputItemReasoning && !IsOutputItemFunctionCall && !IsOutputItemWebSearchCall && !IsOutputItemFileSearchCall && !IsOutputItemImageGenerationCall || !IsOutputMessage && IsOutputItemReasoning && !IsOutputItemFunctionCall && !IsOutputItemWebSearchCall && !IsOutputItemFileSearchCall && !IsOutputItemImageGenerationCall || !IsOutputMessage && !IsOutputItemReasoning && IsOutputItemFunctionCall && !IsOutputItemWebSearchCall && !IsOutputItemFileSearchCall && !IsOutputItemImageGenerationCall || !IsOutputMessage && !IsOutputItemReasoning && !IsOutputItemFunctionCall && IsOutputItemWebSearchCall && !IsOutputItemFileSearchCall && !IsOutputItemImageGenerationCall || !IsOutputMessage && !IsOutputItemReasoning && !IsOutputItemFunctionCall && !IsOutputItemWebSearchCall && IsOutputItemFileSearchCall && !IsOutputItemImageGenerationCall || !IsOutputMessage && !IsOutputItemReasoning && !IsOutputItemFunctionCall && !IsOutputItemWebSearchCall && !IsOutputItemFileSearchCall && IsOutputItemImageGenerationCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputMessage?, TResult>? outputMessage = null,
            global::System.Func<global::G.OutputItemReasoning?, TResult>? outputItemReasoning = null,
            global::System.Func<global::G.OutputItemFunctionCall?, TResult>? outputItemFunctionCall = null,
            global::System.Func<global::G.OutputItemWebSearchCall?, TResult>? outputItemWebSearchCall = null,
            global::System.Func<global::G.OutputItemFileSearchCall?, TResult>? outputItemFileSearchCall = null,
            global::System.Func<global::G.OutputItemImageGenerationCall?, TResult>? outputItemImageGenerationCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessage && outputMessage != null)
            {
                return outputMessage(OutputMessage!);
            }
            else if (IsOutputItemReasoning && outputItemReasoning != null)
            {
                return outputItemReasoning(OutputItemReasoning!);
            }
            else if (IsOutputItemFunctionCall && outputItemFunctionCall != null)
            {
                return outputItemFunctionCall(OutputItemFunctionCall!);
            }
            else if (IsOutputItemWebSearchCall && outputItemWebSearchCall != null)
            {
                return outputItemWebSearchCall(OutputItemWebSearchCall!);
            }
            else if (IsOutputItemFileSearchCall && outputItemFileSearchCall != null)
            {
                return outputItemFileSearchCall(OutputItemFileSearchCall!);
            }
            else if (IsOutputItemImageGenerationCall && outputItemImageGenerationCall != null)
            {
                return outputItemImageGenerationCall(OutputItemImageGenerationCall!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputMessage?>? outputMessage = null,
            global::System.Action<global::G.OutputItemReasoning?>? outputItemReasoning = null,
            global::System.Action<global::G.OutputItemFunctionCall?>? outputItemFunctionCall = null,
            global::System.Action<global::G.OutputItemWebSearchCall?>? outputItemWebSearchCall = null,
            global::System.Action<global::G.OutputItemFileSearchCall?>? outputItemFileSearchCall = null,
            global::System.Action<global::G.OutputItemImageGenerationCall?>? outputItemImageGenerationCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessage)
            {
                outputMessage?.Invoke(OutputMessage!);
            }
            else if (IsOutputItemReasoning)
            {
                outputItemReasoning?.Invoke(OutputItemReasoning!);
            }
            else if (IsOutputItemFunctionCall)
            {
                outputItemFunctionCall?.Invoke(OutputItemFunctionCall!);
            }
            else if (IsOutputItemWebSearchCall)
            {
                outputItemWebSearchCall?.Invoke(OutputItemWebSearchCall!);
            }
            else if (IsOutputItemFileSearchCall)
            {
                outputItemFileSearchCall?.Invoke(OutputItemFileSearchCall!);
            }
            else if (IsOutputItemImageGenerationCall)
            {
                outputItemImageGenerationCall?.Invoke(OutputItemImageGenerationCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessage,
                typeof(global::G.OutputMessage),
                OutputItemReasoning,
                typeof(global::G.OutputItemReasoning),
                OutputItemFunctionCall,
                typeof(global::G.OutputItemFunctionCall),
                OutputItemWebSearchCall,
                typeof(global::G.OutputItemWebSearchCall),
                OutputItemFileSearchCall,
                typeof(global::G.OutputItemFileSearchCall),
                OutputItemImageGenerationCall,
                typeof(global::G.OutputItemImageGenerationCall),
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
        public bool Equals(BaseResponsesResultOutputItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemReasoning?>.Default.Equals(OutputItemReasoning, other.OutputItemReasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemFunctionCall?>.Default.Equals(OutputItemFunctionCall, other.OutputItemFunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemWebSearchCall?>.Default.Equals(OutputItemWebSearchCall, other.OutputItemWebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemFileSearchCall?>.Default.Equals(OutputItemFileSearchCall, other.OutputItemFileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemImageGenerationCall?>.Default.Equals(OutputItemImageGenerationCall, other.OutputItemImageGenerationCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseResponsesResultOutputItems obj1, BaseResponsesResultOutputItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseResponsesResultOutputItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseResponsesResultOutputItems obj1, BaseResponsesResultOutputItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseResponsesResultOutputItems o && Equals(o);
        }
    }
}
