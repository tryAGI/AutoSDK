//HintName: G.Models.FunctionCallOutputItemOutputOneOf1Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionCallOutputItemOutputOneOf1Items : global::System.IEquatable<FunctionCallOutputItemOutputOneOf1Items>
    {
        /// <summary>
        /// Text input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputText? InputText { get; init; }
#else
        public global::G.InputText? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// Image input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionCallOutputItemOutputOneOf1Items1? FunctionCallOutputItemOutputOneOf1Items1 { get; init; }
#else
        public global::G.FunctionCallOutputItemOutputOneOf1Items1? FunctionCallOutputItemOutputOneOf1Items1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputItemOutputOneOf1Items1))]
#endif
        public bool IsFunctionCallOutputItemOutputOneOf1Items1 => FunctionCallOutputItemOutputOneOf1Items1 != null;

        /// <summary>
        /// File input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputFile? InputFile { get; init; }
#else
        public global::G.InputFile? InputFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFile))]
#endif
        public bool IsInputFile => InputFile != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::G.InputText value) => new FunctionCallOutputItemOutputOneOf1Items((global::G.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputText?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::G.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::G.FunctionCallOutputItemOutputOneOf1Items1 value) => new FunctionCallOutputItemOutputOneOf1Items((global::G.FunctionCallOutputItemOutputOneOf1Items1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionCallOutputItemOutputOneOf1Items1?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.FunctionCallOutputItemOutputOneOf1Items1;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::G.FunctionCallOutputItemOutputOneOf1Items1? value)
        {
            FunctionCallOutputItemOutputOneOf1Items1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::G.InputFile value) => new FunctionCallOutputItemOutputOneOf1Items((global::G.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputFile?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::G.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(
            global::G.InputText? inputText,
            global::G.FunctionCallOutputItemOutputOneOf1Items1? functionCallOutputItemOutputOneOf1Items1,
            global::G.InputFile? inputFile
            )
        {
            InputText = inputText;
            FunctionCallOutputItemOutputOneOf1Items1 = functionCallOutputItemOutputOneOf1Items1;
            InputFile = inputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputFile as object ??
            FunctionCallOutputItemOutputOneOf1Items1 as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            FunctionCallOutputItemOutputOneOf1Items1?.ToString() ??
            InputFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsFunctionCallOutputItemOutputOneOf1Items1 && !IsInputFile || !IsInputText && IsFunctionCallOutputItemOutputOneOf1Items1 && !IsInputFile || !IsInputText && !IsFunctionCallOutputItemOutputOneOf1Items1 && IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputText?, TResult>? inputText = null,
            global::System.Func<global::G.FunctionCallOutputItemOutputOneOf1Items1?, TResult>? functionCallOutputItemOutputOneOf1Items1 = null,
            global::System.Func<global::G.InputFile?, TResult>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsFunctionCallOutputItemOutputOneOf1Items1 && functionCallOutputItemOutputOneOf1Items1 != null)
            {
                return functionCallOutputItemOutputOneOf1Items1(FunctionCallOutputItemOutputOneOf1Items1!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputText?>? inputText = null,
            global::System.Action<global::G.FunctionCallOutputItemOutputOneOf1Items1?>? functionCallOutputItemOutputOneOf1Items1 = null,
            global::System.Action<global::G.InputFile?>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsFunctionCallOutputItemOutputOneOf1Items1)
            {
                functionCallOutputItemOutputOneOf1Items1?.Invoke(FunctionCallOutputItemOutputOneOf1Items1!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::G.InputText),
                FunctionCallOutputItemOutputOneOf1Items1,
                typeof(global::G.FunctionCallOutputItemOutputOneOf1Items1),
                InputFile,
                typeof(global::G.InputFile),
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
        public bool Equals(FunctionCallOutputItemOutputOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionCallOutputItemOutputOneOf1Items1?>.Default.Equals(FunctionCallOutputItemOutputOneOf1Items1, other.FunctionCallOutputItemOutputOneOf1Items1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputFile?>.Default.Equals(InputFile, other.InputFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionCallOutputItemOutputOneOf1Items obj1, FunctionCallOutputItemOutputOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallOutputItemOutputOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionCallOutputItemOutputOneOf1Items obj1, FunctionCallOutputItemOutputOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallOutputItemOutputOneOf1Items o && Equals(o);
        }
    }
}
