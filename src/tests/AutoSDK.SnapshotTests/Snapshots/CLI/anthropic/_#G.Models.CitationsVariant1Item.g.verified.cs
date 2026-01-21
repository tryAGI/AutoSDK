//HintName: G.Models.CitationsVariant1Item.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CitationsVariant1Item : global::System.IEquatable<CitationsVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestCharLocationCitation? CharLocation { get; init; }
#else
        public global::G.BetaRequestCharLocationCitation? CharLocation { get; }
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
#if NET6_0_OR_GREATER
        public global::G.BetaRequestPageLocationCitation? PageLocation { get; init; }
#else
        public global::G.BetaRequestPageLocationCitation? PageLocation { get; }
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
#if NET6_0_OR_GREATER
        public global::G.BetaRequestContentBlockLocationCitation? ContentBlockLocation { get; init; }
#else
        public global::G.BetaRequestContentBlockLocationCitation? ContentBlockLocation { get; }
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
        public static implicit operator CitationsVariant1Item(global::G.BetaRequestCharLocationCitation value) => new CitationsVariant1Item((global::G.BetaRequestCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestCharLocationCitation?(CitationsVariant1Item @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item(global::G.BetaRequestCharLocationCitation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item(global::G.BetaRequestPageLocationCitation value) => new CitationsVariant1Item((global::G.BetaRequestPageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestPageLocationCitation?(CitationsVariant1Item @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item(global::G.BetaRequestPageLocationCitation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item(global::G.BetaRequestContentBlockLocationCitation value) => new CitationsVariant1Item((global::G.BetaRequestContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestContentBlockLocationCitation?(CitationsVariant1Item @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item(global::G.BetaRequestContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item(
            global::G.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? type,
            global::G.BetaRequestCharLocationCitation? charLocation,
            global::G.BetaRequestPageLocationCitation? pageLocation,
            global::G.BetaRequestContentBlockLocationCitation? contentBlockLocation
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
            global::System.Func<global::G.BetaRequestCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::G.BetaRequestPageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::G.BetaRequestContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCharLocation && charLocation != null)
            {
                return charLocation(CharLocation!);
            }
            else if (IsPageLocation && pageLocation != null)
            {
                return pageLocation(PageLocation!);
            }
            else if (IsContentBlockLocation && contentBlockLocation != null)
            {
                return contentBlockLocation(ContentBlockLocation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaRequestCharLocationCitation?>? charLocation = null,
            global::System.Action<global::G.BetaRequestPageLocationCitation?>? pageLocation = null,
            global::System.Action<global::G.BetaRequestContentBlockLocationCitation?>? contentBlockLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCharLocation)
            {
                charLocation?.Invoke(CharLocation!);
            }
            else if (IsPageLocation)
            {
                pageLocation?.Invoke(PageLocation!);
            }
            else if (IsContentBlockLocation)
            {
                contentBlockLocation?.Invoke(ContentBlockLocation!);
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
                typeof(global::G.BetaRequestCharLocationCitation),
                PageLocation,
                typeof(global::G.BetaRequestPageLocationCitation),
                ContentBlockLocation,
                typeof(global::G.BetaRequestContentBlockLocationCitation),
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
        public bool Equals(CitationsVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestPageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationsVariant1Item obj1, CitationsVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationsVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationsVariant1Item obj1, CitationsVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationsVariant1Item o && Equals(o);
        }
    }
}
