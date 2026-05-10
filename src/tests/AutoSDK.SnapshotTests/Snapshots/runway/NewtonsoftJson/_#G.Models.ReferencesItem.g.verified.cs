//HintName: G.Models.ReferencesItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ReferencesItem : global::System.IEquatable<ReferencesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorType? Type { get; }

        /// <summary>
        /// Passing an image reference allows the model to emulate the style or content of the reference in the output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference? Image { get; init; }
#else
        public global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference? Image { get; }
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
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReferencesItem(global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference value) => new ReferencesItem((global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference?(ReferencesItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ReferencesItem(global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReferencesItem FromImage(global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference? value) => new ReferencesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public ReferencesItem(
            global::G.CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorType? type,
            global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference? image
            )
        {
            Type = type;

            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Image,
                typeof(global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference),
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
        public bool Equals(ReferencesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReferencesItem obj1, ReferencesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReferencesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReferencesItem obj1, ReferencesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReferencesItem o && Equals(o);
        }
    }
}
