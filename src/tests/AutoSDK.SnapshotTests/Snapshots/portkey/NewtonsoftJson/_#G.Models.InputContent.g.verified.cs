//HintName: G.Models.InputContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputContent : global::System.IEquatable<InputContent>
    {
        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputText? TextInput { get; init; }
#else
        public global::G.InputText? TextInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextInput))]
#endif
        public bool IsTextInput => TextInput != null;

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputImage? ImageInput { get; init; }
#else
        public global::G.InputImage? ImageInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageInput))]
#endif
        public bool IsImageInput => ImageInput != null;

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputFile? FileInput { get; init; }
#else
        public global::G.InputFile? FileInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileInput))]
#endif
        public bool IsFileInput => FileInput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::G.InputText value) => new InputContent((global::G.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputText?(InputContent @this) => @this.TextInput;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::G.InputText? value)
        {
            TextInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::G.InputImage value) => new InputContent((global::G.InputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputImage?(InputContent @this) => @this.ImageInput;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::G.InputImage? value)
        {
            ImageInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::G.InputFile value) => new InputContent((global::G.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputFile?(InputContent @this) => @this.FileInput;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::G.InputFile? value)
        {
            FileInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputContent(
            global::G.InputText? textInput,
            global::G.InputImage? imageInput,
            global::G.InputFile? fileInput
            )
        {
            TextInput = textInput;
            ImageInput = imageInput;
            FileInput = fileInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileInput as object ??
            ImageInput as object ??
            TextInput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextInput?.ToString() ??
            ImageInput?.ToString() ??
            FileInput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextInput && !IsImageInput && !IsFileInput || !IsTextInput && IsImageInput && !IsFileInput || !IsTextInput && !IsImageInput && IsFileInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputText?, TResult>? textInput = null,
            global::System.Func<global::G.InputImage?, TResult>? imageInput = null,
            global::System.Func<global::G.InputFile?, TResult>? fileInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextInput && textInput != null)
            {
                return textInput(TextInput!);
            }
            else if (IsImageInput && imageInput != null)
            {
                return imageInput(ImageInput!);
            }
            else if (IsFileInput && fileInput != null)
            {
                return fileInput(FileInput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputText?>? textInput = null,
            global::System.Action<global::G.InputImage?>? imageInput = null,
            global::System.Action<global::G.InputFile?>? fileInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextInput)
            {
                textInput?.Invoke(TextInput!);
            }
            else if (IsImageInput)
            {
                imageInput?.Invoke(ImageInput!);
            }
            else if (IsFileInput)
            {
                fileInput?.Invoke(FileInput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextInput,
                typeof(global::G.InputText),
                ImageInput,
                typeof(global::G.InputImage),
                FileInput,
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
        public bool Equals(InputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputText?>.Default.Equals(TextInput, other.TextInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputImage?>.Default.Equals(ImageInput, other.ImageInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputFile?>.Default.Equals(FileInput, other.FileInput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputContent obj1, InputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputContent obj1, InputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputContent o && Equals(o);
        }
    }
}
