//HintName: G.Models.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items : global::System.IEquatable<BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>
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
        /// 
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputText PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputImage PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

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
        public bool TryPickInputFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputFile? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputFile PickInputFile() => IsInputFile
            ? InputFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(global::G.InputText value) => new BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items((global::G.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputText?(BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(global::G.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items FromInputText(global::G.InputText? value) => new BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(global::G.InputImage value) => new BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items((global::G.InputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputImage?(BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(global::G.InputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items FromInputImage(global::G.InputImage? value) => new BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(global::G.InputFile value) => new BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items((global::G.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputFile?(BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(global::G.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items FromInputFile(global::G.InputFile? value) => new BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items(
            global::G.InputText? inputText,
            global::G.InputImage? inputImage,
            global::G.InputFile? inputFile
            )
        {
            InputText = inputText;
            InputImage = inputImage;
            InputFile = inputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            InputFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage && !IsInputFile || !IsInputText && IsInputImage && !IsInputFile || !IsInputText && !IsInputImage && IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputText, TResult>? inputText = null,
            global::System.Func<global::G.InputImage, TResult>? inputImage = null,
            global::System.Func<global::G.InputFile, TResult>? inputFile = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputText>? inputText = null,

            global::System.Action<global::G.InputImage>? inputImage = null,

            global::System.Action<global::G.InputFile>? inputFile = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.InputText>? inputText = null,
            global::System.Action<global::G.InputImage>? inputImage = null,
            global::System.Action<global::G.InputFile>? inputFile = null,
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
        public bool Equals(BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputImage?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputFile?>.Default.Equals(InputFile, other.InputFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items obj1, BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items obj1, BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items o && Equals(o);
        }
    }
}
