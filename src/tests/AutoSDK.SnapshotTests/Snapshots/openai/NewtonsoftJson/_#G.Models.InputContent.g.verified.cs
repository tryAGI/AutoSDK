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
        public global::G.InputTextContent? Text { get; init; }
#else
        public global::G.InputTextContent? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::G.InputTextContent value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputTextContent?(InputContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::G.InputTextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputImageContent? Image { get; init; }
#else
        public global::G.InputImageContent? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::G.InputImageContent value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputImageContent?(InputContent @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::G.InputImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputFileContent? File { get; init; }
#else
        public global::G.InputFileContent? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::G.InputFileContent value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputFileContent?(InputContent @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::G.InputFileContent? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputContent(
            global::G.InputTextContent? text,
            global::G.InputImageContent? image,
            global::G.InputFileContent? file
            )
        {
            Text = text;
            Image = image;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsFile || !IsText && IsImage && !IsFile || !IsText && !IsImage && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputTextContent?, TResult>? text = null,
            global::System.Func<global::G.InputImageContent?, TResult>? image = null,
            global::System.Func<global::G.InputFileContent?, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputTextContent?>? text = null,
            global::System.Action<global::G.InputImageContent?>? image = null,
            global::System.Action<global::G.InputFileContent?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.InputTextContent),
                Image,
                typeof(global::G.InputImageContent),
                File,
                typeof(global::G.InputFileContent),
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
                global::System.Collections.Generic.EqualityComparer<global::G.InputTextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputImageContent?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputFileContent?>.Default.Equals(File, other.File) 
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
