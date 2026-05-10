//HintName: G.Models.CitationsVariant1Item2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CitationsVariant1Item2 : global::System.IEquatable<CitationsVariant1Item2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaResponseCharLocationCitation? CharLocation { get; init; }
#else
        public global::G.BetaResponseCharLocationCitation? CharLocation { get; }
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
            out global::G.BetaResponseCharLocationCitation? value)
        {
            value = CharLocation;
            return IsCharLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaResponseCharLocationCitation PickCharLocation() => IsCharLocation
            ? CharLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CharLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaResponsePageLocationCitation? PageLocation { get; init; }
#else
        public global::G.BetaResponsePageLocationCitation? PageLocation { get; }
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
            out global::G.BetaResponsePageLocationCitation? value)
        {
            value = PageLocation;
            return IsPageLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaResponsePageLocationCitation PickPageLocation() => IsPageLocation
            ? PageLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PageLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaResponseContentBlockLocationCitation? ContentBlockLocation { get; init; }
#else
        public global::G.BetaResponseContentBlockLocationCitation? ContentBlockLocation { get; }
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
            out global::G.BetaResponseContentBlockLocationCitation? value)
        {
            value = ContentBlockLocation;
            return IsContentBlockLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaResponseContentBlockLocationCitation PickContentBlockLocation() => IsContentBlockLocation
            ? ContentBlockLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockLocation' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item2(global::G.BetaResponseCharLocationCitation value) => new CitationsVariant1Item2((global::G.BetaResponseCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseCharLocationCitation?(CitationsVariant1Item2 @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item2(global::G.BetaResponseCharLocationCitation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CitationsVariant1Item2 FromCharLocation(global::G.BetaResponseCharLocationCitation? value) => new CitationsVariant1Item2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item2(global::G.BetaResponsePageLocationCitation value) => new CitationsVariant1Item2((global::G.BetaResponsePageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponsePageLocationCitation?(CitationsVariant1Item2 @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item2(global::G.BetaResponsePageLocationCitation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CitationsVariant1Item2 FromPageLocation(global::G.BetaResponsePageLocationCitation? value) => new CitationsVariant1Item2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item2(global::G.BetaResponseContentBlockLocationCitation value) => new CitationsVariant1Item2((global::G.BetaResponseContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseContentBlockLocationCitation?(CitationsVariant1Item2 @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item2(global::G.BetaResponseContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CitationsVariant1Item2 FromContentBlockLocation(global::G.BetaResponseContentBlockLocationCitation? value) => new CitationsVariant1Item2(value);

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item2(
            global::G.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType? type,
            global::G.BetaResponseCharLocationCitation? charLocation,
            global::G.BetaResponsePageLocationCitation? pageLocation,
            global::G.BetaResponseContentBlockLocationCitation? contentBlockLocation
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
            global::System.Func<global::G.BetaResponseCharLocationCitation, TResult>? charLocation = null,
            global::System.Func<global::G.BetaResponsePageLocationCitation, TResult>? pageLocation = null,
            global::System.Func<global::G.BetaResponseContentBlockLocationCitation, TResult>? contentBlockLocation = null,
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
            global::System.Action<global::G.BetaResponseCharLocationCitation>? charLocation = null,

            global::System.Action<global::G.BetaResponsePageLocationCitation>? pageLocation = null,

            global::System.Action<global::G.BetaResponseContentBlockLocationCitation>? contentBlockLocation = null,
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
        public void Switch(
            global::System.Action<global::G.BetaResponseCharLocationCitation>? charLocation = null,
            global::System.Action<global::G.BetaResponsePageLocationCitation>? pageLocation = null,
            global::System.Action<global::G.BetaResponseContentBlockLocationCitation>? contentBlockLocation = null,
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
                typeof(global::G.BetaResponseCharLocationCitation),
                PageLocation,
                typeof(global::G.BetaResponsePageLocationCitation),
                ContentBlockLocation,
                typeof(global::G.BetaResponseContentBlockLocationCitation),
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
        public bool Equals(CitationsVariant1Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponsePageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationsVariant1Item2 obj1, CitationsVariant1Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationsVariant1Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationsVariant1Item2 obj1, CitationsVariant1Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationsVariant1Item2 o && Equals(o);
        }
    }
}
