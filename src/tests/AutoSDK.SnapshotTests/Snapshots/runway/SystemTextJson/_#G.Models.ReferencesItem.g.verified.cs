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
        /// Passing an image reference allows the model to emulate the style or content of the reference in the output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestGen4AlephReferenceImageReference? Image { get; init; }
#else
        public global::G.RequestGen4AlephReferenceImageReference? Image { get; }
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
        public static implicit operator ReferencesItem(global::G.RequestGen4AlephReferenceImageReference value) => new ReferencesItem((global::G.RequestGen4AlephReferenceImageReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestGen4AlephReferenceImageReference?(ReferencesItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ReferencesItem(global::G.RequestGen4AlephReferenceImageReference? value)
        {
            Image = value;
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
            global::System.Func<global::G.RequestGen4AlephReferenceImageReference?, TResult>? image = null,
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
            global::System.Action<global::G.RequestGen4AlephReferenceImageReference?>? image = null,
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
                typeof(global::G.RequestGen4AlephReferenceImageReference),
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
                global::System.Collections.Generic.EqualityComparer<global::G.RequestGen4AlephReferenceImageReference?>.Default.Equals(Image, other.Image) 
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
