//HintName: G.Models.StoredPromptTemplateVariables.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StoredPromptTemplateVariables : global::System.IEquatable<StoredPromptTemplateVariables>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StoredPromptTemplateVariablesVariant1 { get; init; }
#else
        public string? StoredPromptTemplateVariablesVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StoredPromptTemplateVariablesVariant1))]
#endif
        public bool IsStoredPromptTemplateVariablesVariant1 => StoredPromptTemplateVariablesVariant1 != null;

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
        /// 
        /// </summary>
        public static implicit operator StoredPromptTemplateVariables(string value) => new StoredPromptTemplateVariables((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StoredPromptTemplateVariables @this) => @this.StoredPromptTemplateVariablesVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(string? value)
        {
            StoredPromptTemplateVariablesVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StoredPromptTemplateVariables(global::G.InputText value) => new StoredPromptTemplateVariables((global::G.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputText?(StoredPromptTemplateVariables @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(global::G.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StoredPromptTemplateVariables(global::G.InputImage value) => new StoredPromptTemplateVariables((global::G.InputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputImage?(StoredPromptTemplateVariables @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(global::G.InputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StoredPromptTemplateVariables(global::G.InputFile value) => new StoredPromptTemplateVariables((global::G.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputFile?(StoredPromptTemplateVariables @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(global::G.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(
            string? storedPromptTemplateVariablesVariant1,
            global::G.InputText? inputText,
            global::G.InputImage? inputImage,
            global::G.InputFile? inputFile
            )
        {
            StoredPromptTemplateVariablesVariant1 = storedPromptTemplateVariablesVariant1;
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
            InputText as object ??
            StoredPromptTemplateVariablesVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StoredPromptTemplateVariablesVariant1?.ToString() ??
            InputText?.ToString() ??
            InputImage?.ToString() ??
            InputFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStoredPromptTemplateVariablesVariant1 && !IsInputText && !IsInputImage && !IsInputFile || !IsStoredPromptTemplateVariablesVariant1 && IsInputText && !IsInputImage && !IsInputFile || !IsStoredPromptTemplateVariablesVariant1 && !IsInputText && IsInputImage && !IsInputFile || !IsStoredPromptTemplateVariablesVariant1 && !IsInputText && !IsInputImage && IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? storedPromptTemplateVariablesVariant1 = null,
            global::System.Func<global::G.InputText?, TResult>? inputText = null,
            global::System.Func<global::G.InputImage?, TResult>? inputImage = null,
            global::System.Func<global::G.InputFile?, TResult>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStoredPromptTemplateVariablesVariant1 && storedPromptTemplateVariablesVariant1 != null)
            {
                return storedPromptTemplateVariablesVariant1(StoredPromptTemplateVariablesVariant1!);
            }
            else if (IsInputText && inputText != null)
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
            global::System.Action<string?>? storedPromptTemplateVariablesVariant1 = null,
            global::System.Action<global::G.InputText?>? inputText = null,
            global::System.Action<global::G.InputImage?>? inputImage = null,
            global::System.Action<global::G.InputFile?>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStoredPromptTemplateVariablesVariant1)
            {
                storedPromptTemplateVariablesVariant1?.Invoke(StoredPromptTemplateVariablesVariant1!);
            }
            else if (IsInputText)
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
                StoredPromptTemplateVariablesVariant1,
                typeof(string),
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
        public bool Equals(StoredPromptTemplateVariables other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StoredPromptTemplateVariablesVariant1, other.StoredPromptTemplateVariablesVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputImage?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputFile?>.Default.Equals(InputFile, other.InputFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StoredPromptTemplateVariables obj1, StoredPromptTemplateVariables obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StoredPromptTemplateVariables>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StoredPromptTemplateVariables obj1, StoredPromptTemplateVariables obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StoredPromptTemplateVariables o && Equals(o);
        }
    }
}
