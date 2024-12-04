//HintName: G.Models.InputVariant3Item.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputVariant3Item : global::System.IEquatable<InputVariant3Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateModerationRequestInputVariant3ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// An object describing an image to classify.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateModerationRequestInputVariant3ItemVariant1? ImageUrl { get; init; }
#else
        public global::G.CreateModerationRequestInputVariant3ItemVariant1? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant3Item(global::G.CreateModerationRequestInputVariant3ItemVariant1 value) => new InputVariant3Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateModerationRequestInputVariant3ItemVariant1?(InputVariant3Item @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(global::G.CreateModerationRequestInputVariant3ItemVariant1? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// An object describing text to classify.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateModerationRequestInputVariant3ItemVariant2? Text { get; init; }
#else
        public global::G.CreateModerationRequestInputVariant3ItemVariant2? Text { get; }
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
        public static implicit operator InputVariant3Item(global::G.CreateModerationRequestInputVariant3ItemVariant2 value) => new InputVariant3Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateModerationRequestInputVariant3ItemVariant2?(InputVariant3Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(global::G.CreateModerationRequestInputVariant3ItemVariant2? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(
            global::G.CreateModerationRequestInputVariant3ItemDiscriminatorType? type,
            global::G.CreateModerationRequestInputVariant3ItemVariant1? imageUrl,
            global::G.CreateModerationRequestInputVariant3ItemVariant2? text
            )
        {
            Type = type;

            ImageUrl = imageUrl;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            ImageUrl as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageUrl && !IsText || !IsImageUrl && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateModerationRequestInputVariant3ItemVariant1?, TResult>? imageUrl = null,
            global::System.Func<global::G.CreateModerationRequestInputVariant3ItemVariant2?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
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
            global::System.Action<global::G.CreateModerationRequestInputVariant3ItemVariant1?>? imageUrl = null,
            global::System.Action<global::G.CreateModerationRequestInputVariant3ItemVariant2?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
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
                ImageUrl,
                typeof(global::G.CreateModerationRequestInputVariant3ItemVariant1),
                Text,
                typeof(global::G.CreateModerationRequestInputVariant3ItemVariant2),
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
        public bool Equals(InputVariant3Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateModerationRequestInputVariant3ItemVariant1?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateModerationRequestInputVariant3ItemVariant2?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputVariant3Item obj1, InputVariant3Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputVariant3Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputVariant3Item obj1, InputVariant3Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputVariant3Item o && Equals(o);
        }
    }
}
