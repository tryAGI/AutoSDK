//HintName: G.Models.OutputItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An output item from the response
    /// </summary>
    public readonly partial struct OutputItems : global::System.IEquatable<OutputItems>
    {
        /// <summary>
        /// An output message item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessageItem? OutputMessageItem { get; init; }
#else
        public global::G.OutputMessageItem? OutputMessageItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageItem))]
#endif
        public bool IsOutputMessageItem => OutputMessageItem != null;

        /// <summary>
        /// An output item containing reasoning
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputReasoningItem? OutputReasoningItem { get; init; }
#else
        public global::G.OutputReasoningItem? OutputReasoningItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputReasoningItem))]
#endif
        public bool IsOutputReasoningItem => OutputReasoningItem != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputFunctionCallItem? OutputFunctionCallItem { get; init; }
#else
        public global::G.OutputFunctionCallItem? OutputFunctionCallItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFunctionCallItem))]
#endif
        public bool IsOutputFunctionCallItem => OutputFunctionCallItem != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputWebSearchCallItem? OutputWebSearchCallItem { get; init; }
#else
        public global::G.OutputWebSearchCallItem? OutputWebSearchCallItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputWebSearchCallItem))]
#endif
        public bool IsOutputWebSearchCallItem => OutputWebSearchCallItem != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputFileSearchCallItem? OutputFileSearchCallItem { get; init; }
#else
        public global::G.OutputFileSearchCallItem? OutputFileSearchCallItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFileSearchCallItem))]
#endif
        public bool IsOutputFileSearchCallItem => OutputFileSearchCallItem != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputImageGenerationCallItem? OutputImageGenerationCallItem { get; init; }
#else
        public global::G.OutputImageGenerationCallItem? OutputImageGenerationCallItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputImageGenerationCallItem))]
#endif
        public bool IsOutputImageGenerationCallItem => OutputImageGenerationCallItem != null;

        /// <summary>
        /// A generic OpenRouter server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputServerToolItem? OutputServerToolItem { get; init; }
#else
        public global::G.OutputServerToolItem? OutputServerToolItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputServerToolItem))]
#endif
        public bool IsOutputServerToolItem => OutputServerToolItem != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::G.OutputMessageItem value) => new OutputItems((global::G.OutputMessageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessageItem?(OutputItems @this) => @this.OutputMessageItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::G.OutputMessageItem? value)
        {
            OutputMessageItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::G.OutputReasoningItem value) => new OutputItems((global::G.OutputReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputReasoningItem?(OutputItems @this) => @this.OutputReasoningItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::G.OutputReasoningItem? value)
        {
            OutputReasoningItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::G.OutputFunctionCallItem value) => new OutputItems((global::G.OutputFunctionCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputFunctionCallItem?(OutputItems @this) => @this.OutputFunctionCallItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::G.OutputFunctionCallItem? value)
        {
            OutputFunctionCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::G.OutputWebSearchCallItem value) => new OutputItems((global::G.OutputWebSearchCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputWebSearchCallItem?(OutputItems @this) => @this.OutputWebSearchCallItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::G.OutputWebSearchCallItem? value)
        {
            OutputWebSearchCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::G.OutputFileSearchCallItem value) => new OutputItems((global::G.OutputFileSearchCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputFileSearchCallItem?(OutputItems @this) => @this.OutputFileSearchCallItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::G.OutputFileSearchCallItem? value)
        {
            OutputFileSearchCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::G.OutputImageGenerationCallItem value) => new OutputItems((global::G.OutputImageGenerationCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputImageGenerationCallItem?(OutputItems @this) => @this.OutputImageGenerationCallItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::G.OutputImageGenerationCallItem? value)
        {
            OutputImageGenerationCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::G.OutputServerToolItem value) => new OutputItems((global::G.OutputServerToolItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputServerToolItem?(OutputItems @this) => @this.OutputServerToolItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::G.OutputServerToolItem? value)
        {
            OutputServerToolItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(
            global::G.OutputMessageItem? outputMessageItem,
            global::G.OutputReasoningItem? outputReasoningItem,
            global::G.OutputFunctionCallItem? outputFunctionCallItem,
            global::G.OutputWebSearchCallItem? outputWebSearchCallItem,
            global::G.OutputFileSearchCallItem? outputFileSearchCallItem,
            global::G.OutputImageGenerationCallItem? outputImageGenerationCallItem,
            global::G.OutputServerToolItem? outputServerToolItem
            )
        {
            OutputMessageItem = outputMessageItem;
            OutputReasoningItem = outputReasoningItem;
            OutputFunctionCallItem = outputFunctionCallItem;
            OutputWebSearchCallItem = outputWebSearchCallItem;
            OutputFileSearchCallItem = outputFileSearchCallItem;
            OutputImageGenerationCallItem = outputImageGenerationCallItem;
            OutputServerToolItem = outputServerToolItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputServerToolItem as object ??
            OutputImageGenerationCallItem as object ??
            OutputFileSearchCallItem as object ??
            OutputWebSearchCallItem as object ??
            OutputFunctionCallItem as object ??
            OutputReasoningItem as object ??
            OutputMessageItem as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputMessageItem?.ToString() ??
            OutputReasoningItem?.ToString() ??
            OutputFunctionCallItem?.ToString() ??
            OutputWebSearchCallItem?.ToString() ??
            OutputFileSearchCallItem?.ToString() ??
            OutputImageGenerationCallItem?.ToString() ??
            OutputServerToolItem?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && IsOutputServerToolItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputMessageItem?, TResult>? outputMessageItem = null,
            global::System.Func<global::G.OutputReasoningItem?, TResult>? outputReasoningItem = null,
            global::System.Func<global::G.OutputFunctionCallItem?, TResult>? outputFunctionCallItem = null,
            global::System.Func<global::G.OutputWebSearchCallItem?, TResult>? outputWebSearchCallItem = null,
            global::System.Func<global::G.OutputFileSearchCallItem?, TResult>? outputFileSearchCallItem = null,
            global::System.Func<global::G.OutputImageGenerationCallItem?, TResult>? outputImageGenerationCallItem = null,
            global::System.Func<global::G.OutputServerToolItem?, TResult>? outputServerToolItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItem && outputMessageItem != null)
            {
                return outputMessageItem(OutputMessageItem!);
            }
            else if (IsOutputReasoningItem && outputReasoningItem != null)
            {
                return outputReasoningItem(OutputReasoningItem!);
            }
            else if (IsOutputFunctionCallItem && outputFunctionCallItem != null)
            {
                return outputFunctionCallItem(OutputFunctionCallItem!);
            }
            else if (IsOutputWebSearchCallItem && outputWebSearchCallItem != null)
            {
                return outputWebSearchCallItem(OutputWebSearchCallItem!);
            }
            else if (IsOutputFileSearchCallItem && outputFileSearchCallItem != null)
            {
                return outputFileSearchCallItem(OutputFileSearchCallItem!);
            }
            else if (IsOutputImageGenerationCallItem && outputImageGenerationCallItem != null)
            {
                return outputImageGenerationCallItem(OutputImageGenerationCallItem!);
            }
            else if (IsOutputServerToolItem && outputServerToolItem != null)
            {
                return outputServerToolItem(OutputServerToolItem!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputMessageItem?>? outputMessageItem = null,
            global::System.Action<global::G.OutputReasoningItem?>? outputReasoningItem = null,
            global::System.Action<global::G.OutputFunctionCallItem?>? outputFunctionCallItem = null,
            global::System.Action<global::G.OutputWebSearchCallItem?>? outputWebSearchCallItem = null,
            global::System.Action<global::G.OutputFileSearchCallItem?>? outputFileSearchCallItem = null,
            global::System.Action<global::G.OutputImageGenerationCallItem?>? outputImageGenerationCallItem = null,
            global::System.Action<global::G.OutputServerToolItem?>? outputServerToolItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItem)
            {
                outputMessageItem?.Invoke(OutputMessageItem!);
            }
            else if (IsOutputReasoningItem)
            {
                outputReasoningItem?.Invoke(OutputReasoningItem!);
            }
            else if (IsOutputFunctionCallItem)
            {
                outputFunctionCallItem?.Invoke(OutputFunctionCallItem!);
            }
            else if (IsOutputWebSearchCallItem)
            {
                outputWebSearchCallItem?.Invoke(OutputWebSearchCallItem!);
            }
            else if (IsOutputFileSearchCallItem)
            {
                outputFileSearchCallItem?.Invoke(OutputFileSearchCallItem!);
            }
            else if (IsOutputImageGenerationCallItem)
            {
                outputImageGenerationCallItem?.Invoke(OutputImageGenerationCallItem!);
            }
            else if (IsOutputServerToolItem)
            {
                outputServerToolItem?.Invoke(OutputServerToolItem!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessageItem,
                typeof(global::G.OutputMessageItem),
                OutputReasoningItem,
                typeof(global::G.OutputReasoningItem),
                OutputFunctionCallItem,
                typeof(global::G.OutputFunctionCallItem),
                OutputWebSearchCallItem,
                typeof(global::G.OutputWebSearchCallItem),
                OutputFileSearchCallItem,
                typeof(global::G.OutputFileSearchCallItem),
                OutputImageGenerationCallItem,
                typeof(global::G.OutputImageGenerationCallItem),
                OutputServerToolItem,
                typeof(global::G.OutputServerToolItem),
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
        public bool Equals(OutputItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessageItem?>.Default.Equals(OutputMessageItem, other.OutputMessageItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputReasoningItem?>.Default.Equals(OutputReasoningItem, other.OutputReasoningItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputFunctionCallItem?>.Default.Equals(OutputFunctionCallItem, other.OutputFunctionCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputWebSearchCallItem?>.Default.Equals(OutputWebSearchCallItem, other.OutputWebSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputFileSearchCallItem?>.Default.Equals(OutputFileSearchCallItem, other.OutputFileSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputImageGenerationCallItem?>.Default.Equals(OutputImageGenerationCallItem, other.OutputImageGenerationCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputServerToolItem?>.Default.Equals(OutputServerToolItem, other.OutputServerToolItem) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputItems obj1, OutputItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputItems obj1, OutputItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItems o && Equals(o);
        }
    }
}
