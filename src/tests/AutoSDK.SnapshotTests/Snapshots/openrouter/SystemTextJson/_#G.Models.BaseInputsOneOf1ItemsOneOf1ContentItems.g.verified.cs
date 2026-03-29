//HintName: G.Models.BaseInputsOneOf1ItemsOneOf1ContentItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputsOneOf1ItemsOneOf1ContentItems : global::System.IEquatable<BaseInputsOneOf1ItemsOneOf1ContentItems>
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
        public global::G.InputImage? InputImage { get; init; }
#else
        public global::G.InputImage? InputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

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
        /// Audio input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudio? InputAudio { get; init; }
#else
        public global::G.InputAudio? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf1ContentItems(global::G.InputText value) => new BaseInputsOneOf1ItemsOneOf1ContentItems((global::G.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputText?(BaseInputsOneOf1ItemsOneOf1ContentItems @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1ContentItems(global::G.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf1ContentItems(global::G.InputImage value) => new BaseInputsOneOf1ItemsOneOf1ContentItems((global::G.InputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputImage?(BaseInputsOneOf1ItemsOneOf1ContentItems @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1ContentItems(global::G.InputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf1ContentItems(global::G.InputFile value) => new BaseInputsOneOf1ItemsOneOf1ContentItems((global::G.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputFile?(BaseInputsOneOf1ItemsOneOf1ContentItems @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1ContentItems(global::G.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf1ContentItems(global::G.InputAudio value) => new BaseInputsOneOf1ItemsOneOf1ContentItems((global::G.InputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudio?(BaseInputsOneOf1ItemsOneOf1ContentItems @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1ContentItems(global::G.InputAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1ContentItems(
            global::G.InputText? inputText,
            global::G.InputImage? inputImage,
            global::G.InputFile? inputFile,
            global::G.InputAudio? inputAudio
            )
        {
            InputText = inputText;
            InputImage = inputImage;
            InputFile = inputFile;
            InputAudio = inputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputAudio as object ??
            InputFile as object ??
            InputImage as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputImage?.ToString() ??
            InputFile?.ToString() ??
            InputAudio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage && !IsInputFile && !IsInputAudio || !IsInputText && IsInputImage && !IsInputFile && !IsInputAudio || !IsInputText && !IsInputImage && IsInputFile && !IsInputAudio || !IsInputText && !IsInputImage && !IsInputFile && IsInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputText?, TResult>? inputText = null,
            global::System.Func<global::G.InputImage?, TResult>? inputImage = null,
            global::System.Func<global::G.InputFile?, TResult>? inputFile = null,
            global::System.Func<global::G.InputAudio?, TResult>? inputAudio = null,
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
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }
            else if (IsInputAudio && inputAudio != null)
            {
                return inputAudio(InputAudio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputText?>? inputText = null,
            global::System.Action<global::G.InputImage?>? inputImage = null,
            global::System.Action<global::G.InputFile?>? inputFile = null,
            global::System.Action<global::G.InputAudio?>? inputAudio = null,
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
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
            else if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
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
                InputImage,
                typeof(global::G.InputImage),
                InputFile,
                typeof(global::G.InputFile),
                InputAudio,
                typeof(global::G.InputAudio),
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
        public bool Equals(BaseInputsOneOf1ItemsOneOf1ContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputImage?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputFile?>.Default.Equals(InputFile, other.InputFile) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudio?>.Default.Equals(InputAudio, other.InputAudio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputsOneOf1ItemsOneOf1ContentItems obj1, BaseInputsOneOf1ItemsOneOf1ContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputsOneOf1ItemsOneOf1ContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputsOneOf1ItemsOneOf1ContentItems obj1, BaseInputsOneOf1ItemsOneOf1ContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputsOneOf1ItemsOneOf1ContentItems o && Equals(o);
        }
    }
}
