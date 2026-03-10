//HintName: G.Models.ParametersItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ParametersItem : global::System.IEquatable<ParametersItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WhatsAppTemplateTextParam? Text { get; init; }
#else
        public global::G.WhatsAppTemplateTextParam? Text { get; }
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
#if NET6_0_OR_GREATER
        public global::G.WhatsAppTemplateImageParam? Image { get; init; }
#else
        public global::G.WhatsAppTemplateImageParam? Image { get; }
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
#if NET6_0_OR_GREATER
        public global::G.WhatsAppTemplateDocumentParam? Document { get; init; }
#else
        public global::G.WhatsAppTemplateDocumentParam? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WhatsAppTemplateLocationParam? Location { get; init; }
#else
        public global::G.WhatsAppTemplateLocationParam? Location { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Location))]
#endif
        public bool IsLocation => Location != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::G.WhatsAppTemplateTextParam value) => new ParametersItem((global::G.WhatsAppTemplateTextParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WhatsAppTemplateTextParam?(ParametersItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::G.WhatsAppTemplateTextParam? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::G.WhatsAppTemplateImageParam value) => new ParametersItem((global::G.WhatsAppTemplateImageParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WhatsAppTemplateImageParam?(ParametersItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::G.WhatsAppTemplateImageParam? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::G.WhatsAppTemplateDocumentParam value) => new ParametersItem((global::G.WhatsAppTemplateDocumentParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WhatsAppTemplateDocumentParam?(ParametersItem @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::G.WhatsAppTemplateDocumentParam? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::G.WhatsAppTemplateLocationParam value) => new ParametersItem((global::G.WhatsAppTemplateLocationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WhatsAppTemplateLocationParam?(ParametersItem @this) => @this.Location;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::G.WhatsAppTemplateLocationParam? value)
        {
            Location = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(
            global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? type,
            global::G.WhatsAppTemplateTextParam? text,
            global::G.WhatsAppTemplateImageParam? image,
            global::G.WhatsAppTemplateDocumentParam? document,
            global::G.WhatsAppTemplateLocationParam? location
            )
        {
            Type = type;

            Text = text;
            Image = image;
            Document = document;
            Location = location;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Location as object ??
            Document as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            Document?.ToString() ??
            Location?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsDocument && !IsLocation || !IsText && IsImage && !IsDocument && !IsLocation || !IsText && !IsImage && IsDocument && !IsLocation || !IsText && !IsImage && !IsDocument && IsLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WhatsAppTemplateTextParam?, TResult>? text = null,
            global::System.Func<global::G.WhatsAppTemplateImageParam?, TResult>? image = null,
            global::System.Func<global::G.WhatsAppTemplateDocumentParam?, TResult>? document = null,
            global::System.Func<global::G.WhatsAppTemplateLocationParam?, TResult>? location = null,
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
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }
            else if (IsLocation && location != null)
            {
                return location(Location!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WhatsAppTemplateTextParam?>? text = null,
            global::System.Action<global::G.WhatsAppTemplateImageParam?>? image = null,
            global::System.Action<global::G.WhatsAppTemplateDocumentParam?>? document = null,
            global::System.Action<global::G.WhatsAppTemplateLocationParam?>? location = null,
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
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsLocation)
            {
                location?.Invoke(Location!);
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
                typeof(global::G.WhatsAppTemplateTextParam),
                Image,
                typeof(global::G.WhatsAppTemplateImageParam),
                Document,
                typeof(global::G.WhatsAppTemplateDocumentParam),
                Location,
                typeof(global::G.WhatsAppTemplateLocationParam),
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
        public bool Equals(ParametersItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WhatsAppTemplateTextParam?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WhatsAppTemplateImageParam?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WhatsAppTemplateDocumentParam?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WhatsAppTemplateLocationParam?>.Default.Equals(Location, other.Location) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ParametersItem obj1, ParametersItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ParametersItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ParametersItem obj1, ParametersItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParametersItem o && Equals(o);
        }
    }
}
