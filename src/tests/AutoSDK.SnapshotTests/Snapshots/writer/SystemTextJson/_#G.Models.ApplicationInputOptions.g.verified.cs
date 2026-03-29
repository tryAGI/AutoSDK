//HintName: G.Models.ApplicationInputOptions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Type-specific configuration options for input fields.
    /// </summary>
    public readonly partial struct ApplicationInputOptions : global::System.IEquatable<ApplicationInputOptions>
    {
        /// <summary>
        /// Configuration options specific to dropdown-type input fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApplicationInputDropdownOptions? Dropdown { get; init; }
#else
        public global::G.ApplicationInputDropdownOptions? Dropdown { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dropdown))]
#endif
        public bool IsDropdown => Dropdown != null;

        /// <summary>
        /// Configuration options specific to file upload input fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApplicationInputFileOptions? File { get; init; }
#else
        public global::G.ApplicationInputFileOptions? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// Configuration options specific to media upload input fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApplicationInputMediaOptions? Media { get; init; }
#else
        public global::G.ApplicationInputMediaOptions? Media { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Media))]
#endif
        public bool IsMedia => Media != null;

        /// <summary>
        /// Configuration options specific to text input fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApplicationInputTextOptions? Text { get; init; }
#else
        public global::G.ApplicationInputTextOptions? Text { get; }
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
        public static implicit operator ApplicationInputOptions(global::G.ApplicationInputDropdownOptions value) => new ApplicationInputOptions((global::G.ApplicationInputDropdownOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApplicationInputDropdownOptions?(ApplicationInputOptions @this) => @this.Dropdown;

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(global::G.ApplicationInputDropdownOptions? value)
        {
            Dropdown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplicationInputOptions(global::G.ApplicationInputFileOptions value) => new ApplicationInputOptions((global::G.ApplicationInputFileOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApplicationInputFileOptions?(ApplicationInputOptions @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(global::G.ApplicationInputFileOptions? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplicationInputOptions(global::G.ApplicationInputMediaOptions value) => new ApplicationInputOptions((global::G.ApplicationInputMediaOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApplicationInputMediaOptions?(ApplicationInputOptions @this) => @this.Media;

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(global::G.ApplicationInputMediaOptions? value)
        {
            Media = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplicationInputOptions(global::G.ApplicationInputTextOptions value) => new ApplicationInputOptions((global::G.ApplicationInputTextOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApplicationInputTextOptions?(ApplicationInputOptions @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(global::G.ApplicationInputTextOptions? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(
            global::G.ApplicationInputDropdownOptions? dropdown,
            global::G.ApplicationInputFileOptions? file,
            global::G.ApplicationInputMediaOptions? media,
            global::G.ApplicationInputTextOptions? text
            )
        {
            Dropdown = dropdown;
            File = file;
            Media = media;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Media as object ??
            File as object ??
            Dropdown as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dropdown?.ToString() ??
            File?.ToString() ??
            Media?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDropdown && !IsFile && !IsMedia && !IsText || !IsDropdown && IsFile && !IsMedia && !IsText || !IsDropdown && !IsFile && IsMedia && !IsText || !IsDropdown && !IsFile && !IsMedia && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ApplicationInputDropdownOptions?, TResult>? dropdown = null,
            global::System.Func<global::G.ApplicationInputFileOptions?, TResult>? file = null,
            global::System.Func<global::G.ApplicationInputMediaOptions?, TResult>? media = null,
            global::System.Func<global::G.ApplicationInputTextOptions?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDropdown && dropdown != null)
            {
                return dropdown(Dropdown!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsMedia && media != null)
            {
                return media(Media!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ApplicationInputDropdownOptions?>? dropdown = null,
            global::System.Action<global::G.ApplicationInputFileOptions?>? file = null,
            global::System.Action<global::G.ApplicationInputMediaOptions?>? media = null,
            global::System.Action<global::G.ApplicationInputTextOptions?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDropdown)
            {
                dropdown?.Invoke(Dropdown!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsMedia)
            {
                media?.Invoke(Media!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dropdown,
                typeof(global::G.ApplicationInputDropdownOptions),
                File,
                typeof(global::G.ApplicationInputFileOptions),
                Media,
                typeof(global::G.ApplicationInputMediaOptions),
                Text,
                typeof(global::G.ApplicationInputTextOptions),
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
        public bool Equals(ApplicationInputOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ApplicationInputDropdownOptions?>.Default.Equals(Dropdown, other.Dropdown) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ApplicationInputFileOptions?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ApplicationInputMediaOptions?>.Default.Equals(Media, other.Media) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ApplicationInputTextOptions?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApplicationInputOptions obj1, ApplicationInputOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplicationInputOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApplicationInputOptions obj1, ApplicationInputOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplicationInputOptions o && Equals(o);
        }
    }
}
