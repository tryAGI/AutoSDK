//HintName: G.Models.InputsOneOf1Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputsOneOf1Items : global::System.IEquatable<InputsOneOf1Items>
    {
        /// <summary>
        /// Reasoning output item with signature and format extensions
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReasoningItem? ReasoningItem { get; init; }
#else
        public global::G.ReasoningItem? ReasoningItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningItem))]
#endif
        public bool IsReasoningItem => ReasoningItem != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EasyInputMessage? EasyInputMessage { get; init; }
#else
        public global::G.EasyInputMessage? EasyInputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessage))]
#endif
        public bool IsEasyInputMessage => EasyInputMessage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessageItem? InputMessageItem { get; init; }
#else
        public global::G.InputMessageItem? InputMessageItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageItem))]
#endif
        public bool IsInputMessageItem => InputMessageItem != null;

        /// <summary>
        /// A function call initiated by the model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionCallItem? FunctionCallItem { get; init; }
#else
        public global::G.FunctionCallItem? FunctionCallItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallItem))]
#endif
        public bool IsFunctionCallItem => FunctionCallItem != null;

        /// <summary>
        /// The output from a function call execution
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionCallOutputItem? FunctionCallOutputItem { get; init; }
#else
        public global::G.FunctionCallOutputItem? FunctionCallOutputItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputItem))]
#endif
        public bool IsFunctionCallOutputItem => FunctionCallOutputItem != null;

        /// <summary>
        /// An output message item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputsOneOf1Items5? InputsOneOf1Items5 { get; init; }
#else
        public global::G.InputsOneOf1Items5? InputsOneOf1Items5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1Items5))]
#endif
        public bool IsInputsOneOf1Items5 => InputsOneOf1Items5 != null;

        /// <summary>
        /// An output item containing reasoning
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputsOneOf1Items6? InputsOneOf1Items6 { get; init; }
#else
        public global::G.InputsOneOf1Items6? InputsOneOf1Items6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1Items6))]
#endif
        public bool IsInputsOneOf1Items6 => InputsOneOf1Items6 != null;

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
        /// An openrouter:datetime server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputDatetimeItem? OutputDatetimeItem { get; init; }
#else
        public global::G.OutputDatetimeItem? OutputDatetimeItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputDatetimeItem))]
#endif
        public bool IsOutputDatetimeItem => OutputDatetimeItem != null;

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
        public static implicit operator InputsOneOf1Items(global::G.ReasoningItem value) => new InputsOneOf1Items((global::G.ReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningItem?(InputsOneOf1Items @this) => @this.ReasoningItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.ReasoningItem? value)
        {
            ReasoningItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.EasyInputMessage value) => new InputsOneOf1Items((global::G.EasyInputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EasyInputMessage?(InputsOneOf1Items @this) => @this.EasyInputMessage;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.EasyInputMessage? value)
        {
            EasyInputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.InputMessageItem value) => new InputsOneOf1Items((global::G.InputMessageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageItem?(InputsOneOf1Items @this) => @this.InputMessageItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.InputMessageItem? value)
        {
            InputMessageItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.FunctionCallItem value) => new InputsOneOf1Items((global::G.FunctionCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionCallItem?(InputsOneOf1Items @this) => @this.FunctionCallItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.FunctionCallItem? value)
        {
            FunctionCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.FunctionCallOutputItem value) => new InputsOneOf1Items((global::G.FunctionCallOutputItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionCallOutputItem?(InputsOneOf1Items @this) => @this.FunctionCallOutputItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.FunctionCallOutputItem? value)
        {
            FunctionCallOutputItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.InputsOneOf1Items5 value) => new InputsOneOf1Items((global::G.InputsOneOf1Items5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputsOneOf1Items5?(InputsOneOf1Items @this) => @this.InputsOneOf1Items5;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.InputsOneOf1Items5? value)
        {
            InputsOneOf1Items5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.InputsOneOf1Items6 value) => new InputsOneOf1Items((global::G.InputsOneOf1Items6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputsOneOf1Items6?(InputsOneOf1Items @this) => @this.InputsOneOf1Items6;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.InputsOneOf1Items6? value)
        {
            InputsOneOf1Items6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.OutputFunctionCallItem value) => new InputsOneOf1Items((global::G.OutputFunctionCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputFunctionCallItem?(InputsOneOf1Items @this) => @this.OutputFunctionCallItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.OutputFunctionCallItem? value)
        {
            OutputFunctionCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.OutputWebSearchCallItem value) => new InputsOneOf1Items((global::G.OutputWebSearchCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputWebSearchCallItem?(InputsOneOf1Items @this) => @this.OutputWebSearchCallItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.OutputWebSearchCallItem? value)
        {
            OutputWebSearchCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.OutputFileSearchCallItem value) => new InputsOneOf1Items((global::G.OutputFileSearchCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputFileSearchCallItem?(InputsOneOf1Items @this) => @this.OutputFileSearchCallItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.OutputFileSearchCallItem? value)
        {
            OutputFileSearchCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.OutputImageGenerationCallItem value) => new InputsOneOf1Items((global::G.OutputImageGenerationCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputImageGenerationCallItem?(InputsOneOf1Items @this) => @this.OutputImageGenerationCallItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.OutputImageGenerationCallItem? value)
        {
            OutputImageGenerationCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.OutputDatetimeItem value) => new InputsOneOf1Items((global::G.OutputDatetimeItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputDatetimeItem?(InputsOneOf1Items @this) => @this.OutputDatetimeItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.OutputDatetimeItem? value)
        {
            OutputDatetimeItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::G.OutputServerToolItem value) => new InputsOneOf1Items((global::G.OutputServerToolItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputServerToolItem?(InputsOneOf1Items @this) => @this.OutputServerToolItem;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::G.OutputServerToolItem? value)
        {
            OutputServerToolItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(
            global::G.ReasoningItem? reasoningItem,
            global::G.EasyInputMessage? easyInputMessage,
            global::G.InputMessageItem? inputMessageItem,
            global::G.FunctionCallItem? functionCallItem,
            global::G.FunctionCallOutputItem? functionCallOutputItem,
            global::G.InputsOneOf1Items5? inputsOneOf1Items5,
            global::G.InputsOneOf1Items6? inputsOneOf1Items6,
            global::G.OutputFunctionCallItem? outputFunctionCallItem,
            global::G.OutputWebSearchCallItem? outputWebSearchCallItem,
            global::G.OutputFileSearchCallItem? outputFileSearchCallItem,
            global::G.OutputImageGenerationCallItem? outputImageGenerationCallItem,
            global::G.OutputDatetimeItem? outputDatetimeItem,
            global::G.OutputServerToolItem? outputServerToolItem
            )
        {
            ReasoningItem = reasoningItem;
            EasyInputMessage = easyInputMessage;
            InputMessageItem = inputMessageItem;
            FunctionCallItem = functionCallItem;
            FunctionCallOutputItem = functionCallOutputItem;
            InputsOneOf1Items5 = inputsOneOf1Items5;
            InputsOneOf1Items6 = inputsOneOf1Items6;
            OutputFunctionCallItem = outputFunctionCallItem;
            OutputWebSearchCallItem = outputWebSearchCallItem;
            OutputFileSearchCallItem = outputFileSearchCallItem;
            OutputImageGenerationCallItem = outputImageGenerationCallItem;
            OutputDatetimeItem = outputDatetimeItem;
            OutputServerToolItem = outputServerToolItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputServerToolItem as object ??
            OutputDatetimeItem as object ??
            OutputImageGenerationCallItem as object ??
            OutputFileSearchCallItem as object ??
            OutputWebSearchCallItem as object ??
            OutputFunctionCallItem as object ??
            InputsOneOf1Items6 as object ??
            InputsOneOf1Items5 as object ??
            FunctionCallOutputItem as object ??
            FunctionCallItem as object ??
            InputMessageItem as object ??
            EasyInputMessage as object ??
            ReasoningItem as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReasoningItem?.ToString() ??
            EasyInputMessage?.ToString() ??
            InputMessageItem?.ToString() ??
            FunctionCallItem?.ToString() ??
            FunctionCallOutputItem?.ToString() ??
            InputsOneOf1Items5?.ToString() ??
            InputsOneOf1Items6?.ToString() ??
            OutputFunctionCallItem?.ToString() ??
            OutputWebSearchCallItem?.ToString() ??
            OutputFileSearchCallItem?.ToString() ??
            OutputImageGenerationCallItem?.ToString() ??
            OutputDatetimeItem?.ToString() ??
            OutputServerToolItem?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && IsOutputDatetimeItem && !IsOutputServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && IsOutputServerToolItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ReasoningItem?, TResult>? reasoningItem = null,
            global::System.Func<global::G.EasyInputMessage?, TResult>? easyInputMessage = null,
            global::System.Func<global::G.InputMessageItem?, TResult>? inputMessageItem = null,
            global::System.Func<global::G.FunctionCallItem?, TResult>? functionCallItem = null,
            global::System.Func<global::G.FunctionCallOutputItem?, TResult>? functionCallOutputItem = null,
            global::System.Func<global::G.InputsOneOf1Items5?, TResult>? inputsOneOf1Items5 = null,
            global::System.Func<global::G.InputsOneOf1Items6?, TResult>? inputsOneOf1Items6 = null,
            global::System.Func<global::G.OutputFunctionCallItem?, TResult>? outputFunctionCallItem = null,
            global::System.Func<global::G.OutputWebSearchCallItem?, TResult>? outputWebSearchCallItem = null,
            global::System.Func<global::G.OutputFileSearchCallItem?, TResult>? outputFileSearchCallItem = null,
            global::System.Func<global::G.OutputImageGenerationCallItem?, TResult>? outputImageGenerationCallItem = null,
            global::System.Func<global::G.OutputDatetimeItem?, TResult>? outputDatetimeItem = null,
            global::System.Func<global::G.OutputServerToolItem?, TResult>? outputServerToolItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningItem && reasoningItem != null)
            {
                return reasoningItem(ReasoningItem!);
            }
            else if (IsEasyInputMessage && easyInputMessage != null)
            {
                return easyInputMessage(EasyInputMessage!);
            }
            else if (IsInputMessageItem && inputMessageItem != null)
            {
                return inputMessageItem(InputMessageItem!);
            }
            else if (IsFunctionCallItem && functionCallItem != null)
            {
                return functionCallItem(FunctionCallItem!);
            }
            else if (IsFunctionCallOutputItem && functionCallOutputItem != null)
            {
                return functionCallOutputItem(FunctionCallOutputItem!);
            }
            else if (IsInputsOneOf1Items5 && inputsOneOf1Items5 != null)
            {
                return inputsOneOf1Items5(InputsOneOf1Items5!);
            }
            else if (IsInputsOneOf1Items6 && inputsOneOf1Items6 != null)
            {
                return inputsOneOf1Items6(InputsOneOf1Items6!);
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
            else if (IsOutputDatetimeItem && outputDatetimeItem != null)
            {
                return outputDatetimeItem(OutputDatetimeItem!);
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
            global::System.Action<global::G.ReasoningItem?>? reasoningItem = null,
            global::System.Action<global::G.EasyInputMessage?>? easyInputMessage = null,
            global::System.Action<global::G.InputMessageItem?>? inputMessageItem = null,
            global::System.Action<global::G.FunctionCallItem?>? functionCallItem = null,
            global::System.Action<global::G.FunctionCallOutputItem?>? functionCallOutputItem = null,
            global::System.Action<global::G.InputsOneOf1Items5?>? inputsOneOf1Items5 = null,
            global::System.Action<global::G.InputsOneOf1Items6?>? inputsOneOf1Items6 = null,
            global::System.Action<global::G.OutputFunctionCallItem?>? outputFunctionCallItem = null,
            global::System.Action<global::G.OutputWebSearchCallItem?>? outputWebSearchCallItem = null,
            global::System.Action<global::G.OutputFileSearchCallItem?>? outputFileSearchCallItem = null,
            global::System.Action<global::G.OutputImageGenerationCallItem?>? outputImageGenerationCallItem = null,
            global::System.Action<global::G.OutputDatetimeItem?>? outputDatetimeItem = null,
            global::System.Action<global::G.OutputServerToolItem?>? outputServerToolItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningItem)
            {
                reasoningItem?.Invoke(ReasoningItem!);
            }
            else if (IsEasyInputMessage)
            {
                easyInputMessage?.Invoke(EasyInputMessage!);
            }
            else if (IsInputMessageItem)
            {
                inputMessageItem?.Invoke(InputMessageItem!);
            }
            else if (IsFunctionCallItem)
            {
                functionCallItem?.Invoke(FunctionCallItem!);
            }
            else if (IsFunctionCallOutputItem)
            {
                functionCallOutputItem?.Invoke(FunctionCallOutputItem!);
            }
            else if (IsInputsOneOf1Items5)
            {
                inputsOneOf1Items5?.Invoke(InputsOneOf1Items5!);
            }
            else if (IsInputsOneOf1Items6)
            {
                inputsOneOf1Items6?.Invoke(InputsOneOf1Items6!);
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
            else if (IsOutputDatetimeItem)
            {
                outputDatetimeItem?.Invoke(OutputDatetimeItem!);
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
                ReasoningItem,
                typeof(global::G.ReasoningItem),
                EasyInputMessage,
                typeof(global::G.EasyInputMessage),
                InputMessageItem,
                typeof(global::G.InputMessageItem),
                FunctionCallItem,
                typeof(global::G.FunctionCallItem),
                FunctionCallOutputItem,
                typeof(global::G.FunctionCallOutputItem),
                InputsOneOf1Items5,
                typeof(global::G.InputsOneOf1Items5),
                InputsOneOf1Items6,
                typeof(global::G.InputsOneOf1Items6),
                OutputFunctionCallItem,
                typeof(global::G.OutputFunctionCallItem),
                OutputWebSearchCallItem,
                typeof(global::G.OutputWebSearchCallItem),
                OutputFileSearchCallItem,
                typeof(global::G.OutputFileSearchCallItem),
                OutputImageGenerationCallItem,
                typeof(global::G.OutputImageGenerationCallItem),
                OutputDatetimeItem,
                typeof(global::G.OutputDatetimeItem),
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
        public bool Equals(InputsOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningItem?>.Default.Equals(ReasoningItem, other.ReasoningItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EasyInputMessage?>.Default.Equals(EasyInputMessage, other.EasyInputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageItem?>.Default.Equals(InputMessageItem, other.InputMessageItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionCallItem?>.Default.Equals(FunctionCallItem, other.FunctionCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionCallOutputItem?>.Default.Equals(FunctionCallOutputItem, other.FunctionCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputsOneOf1Items5?>.Default.Equals(InputsOneOf1Items5, other.InputsOneOf1Items5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputsOneOf1Items6?>.Default.Equals(InputsOneOf1Items6, other.InputsOneOf1Items6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputFunctionCallItem?>.Default.Equals(OutputFunctionCallItem, other.OutputFunctionCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputWebSearchCallItem?>.Default.Equals(OutputWebSearchCallItem, other.OutputWebSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputFileSearchCallItem?>.Default.Equals(OutputFileSearchCallItem, other.OutputFileSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputImageGenerationCallItem?>.Default.Equals(OutputImageGenerationCallItem, other.OutputImageGenerationCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputDatetimeItem?>.Default.Equals(OutputDatetimeItem, other.OutputDatetimeItem) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputServerToolItem?>.Default.Equals(OutputServerToolItem, other.OutputServerToolItem) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputsOneOf1Items obj1, InputsOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputsOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputsOneOf1Items obj1, InputsOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputsOneOf1Items o && Equals(o);
        }
    }
}
