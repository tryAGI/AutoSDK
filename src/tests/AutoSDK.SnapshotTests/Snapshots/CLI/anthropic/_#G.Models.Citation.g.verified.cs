//HintName: G.Models.Citation.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Citation : global::System.IEquatable<Citation>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CitationsDeltaCitationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCharLocationCitation? CharLocation { get; init; }
#else
        public global::G.ResponseCharLocationCitation? CharLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CharLocation))]
#endif
        public bool IsCharLocation => CharLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCharLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseCharLocationCitation? value)
        {
            value = CharLocation;
            return IsCharLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCharLocationCitation PickCharLocation() => CharLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CharLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponsePageLocationCitation? PageLocation { get; init; }
#else
        public global::G.ResponsePageLocationCitation? PageLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PageLocation))]
#endif
        public bool IsPageLocation => PageLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPageLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponsePageLocationCitation? value)
        {
            value = PageLocation;
            return IsPageLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponsePageLocationCitation PickPageLocation() => PageLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PageLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseContentBlockLocationCitation? ContentBlockLocation { get; init; }
#else
        public global::G.ResponseContentBlockLocationCitation? ContentBlockLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockLocation))]
#endif
        public bool IsContentBlockLocation => ContentBlockLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContentBlockLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseContentBlockLocationCitation? value)
        {
            value = ContentBlockLocation;
            return IsContentBlockLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseContentBlockLocationCitation PickContentBlockLocation() => ContentBlockLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockLocation' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Citation(global::G.ResponseCharLocationCitation value) => new Citation((global::G.ResponseCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCharLocationCitation?(Citation @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::G.ResponseCharLocationCitation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Citation FromCharLocation(global::G.ResponseCharLocationCitation? value) => new Citation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Citation(global::G.ResponsePageLocationCitation value) => new Citation((global::G.ResponsePageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponsePageLocationCitation?(Citation @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::G.ResponsePageLocationCitation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Citation FromPageLocation(global::G.ResponsePageLocationCitation? value) => new Citation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Citation(global::G.ResponseContentBlockLocationCitation value) => new Citation((global::G.ResponseContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseContentBlockLocationCitation?(Citation @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::G.ResponseContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Citation FromContentBlockLocation(global::G.ResponseContentBlockLocationCitation? value) => new Citation(value);

        /// <summary>
        /// 
        /// </summary>
        public Citation(
            global::G.CitationsDeltaCitationDiscriminatorType? type,
            global::G.ResponseCharLocationCitation? charLocation,
            global::G.ResponsePageLocationCitation? pageLocation,
            global::G.ResponseContentBlockLocationCitation? contentBlockLocation
            )
        {
            Type = type;

            CharLocation = charLocation;
            PageLocation = pageLocation;
            ContentBlockLocation = contentBlockLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContentBlockLocation as object ??
            PageLocation as object ??
            CharLocation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CharLocation?.ToString() ??
            PageLocation?.ToString() ??
            ContentBlockLocation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCharLocation && !IsPageLocation && !IsContentBlockLocation || !IsCharLocation && IsPageLocation && !IsContentBlockLocation || !IsCharLocation && !IsPageLocation && IsContentBlockLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseCharLocationCitation, TResult>? charLocation = null,
            global::System.Func<global::G.ResponsePageLocationCitation, TResult>? pageLocation = null,
            global::System.Func<global::G.ResponseContentBlockLocationCitation, TResult>? contentBlockLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CharLocation is { } __value0 && charLocation != null)
            {
                return charLocation(__value0);
            }
            else if (PageLocation is { } __value1 && pageLocation != null)
            {
                return pageLocation(__value1);
            }
            else if (ContentBlockLocation is { } __value2 && contentBlockLocation != null)
            {
                return contentBlockLocation(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseCharLocationCitation>? charLocation = null,

            global::System.Action<global::G.ResponsePageLocationCitation>? pageLocation = null,

            global::System.Action<global::G.ResponseContentBlockLocationCitation>? contentBlockLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CharLocation is { } __value0)
            {
                charLocation?.Invoke(__value0);
            }
            else if (PageLocation is { } __value1)
            {
                pageLocation?.Invoke(__value1);
            }
            else if (ContentBlockLocation is { } __value2)
            {
                contentBlockLocation?.Invoke(__value2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ResponseCharLocationCitation>? charLocation = null,
            global::System.Action<global::G.ResponsePageLocationCitation>? pageLocation = null,
            global::System.Action<global::G.ResponseContentBlockLocationCitation>? contentBlockLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CharLocation is { } __value0)
            {
                charLocation?.Invoke(__value0);
            }
            else if (PageLocation is { } __value1)
            {
                pageLocation?.Invoke(__value1);
            }
            else if (ContentBlockLocation is { } __value2)
            {
                contentBlockLocation?.Invoke(__value2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CharLocation,
                typeof(global::G.ResponseCharLocationCitation),
                PageLocation,
                typeof(global::G.ResponsePageLocationCitation),
                ContentBlockLocation,
                typeof(global::G.ResponseContentBlockLocationCitation),
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
        public bool Equals(Citation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponsePageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Citation obj1, Citation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Citation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Citation obj1, Citation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Citation o && Equals(o);
        }
    }
}
