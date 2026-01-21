//HintName: G.Models.CitationsVariant1Item3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CitationsVariant1Item3 : global::System.IEquatable<CitationsVariant1Item3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RequestTextBlockCitationsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestCharLocationCitation? CharLocation { get; init; }
#else
        public global::G.RequestCharLocationCitation? CharLocation { get; }
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
        public global::G.RequestPageLocationCitation? PageLocation { get; init; }
#else
        public global::G.RequestPageLocationCitation? PageLocation { get; }
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
        public global::G.RequestContentBlockLocationCitation? ContentBlockLocation { get; init; }
#else
        public global::G.RequestContentBlockLocationCitation? ContentBlockLocation { get; }
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
        public static implicit operator CitationsVariant1Item3(global::G.RequestCharLocationCitation value) => new CitationsVariant1Item3((global::G.RequestCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestCharLocationCitation?(CitationsVariant1Item3 @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item3(global::G.RequestCharLocationCitation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item3(global::G.RequestPageLocationCitation value) => new CitationsVariant1Item3((global::G.RequestPageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestPageLocationCitation?(CitationsVariant1Item3 @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item3(global::G.RequestPageLocationCitation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item3(global::G.RequestContentBlockLocationCitation value) => new CitationsVariant1Item3((global::G.RequestContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestContentBlockLocationCitation?(CitationsVariant1Item3 @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item3(global::G.RequestContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item3(
            global::G.RequestTextBlockCitationsVariant1ItemDiscriminatorType? type,
            global::G.RequestCharLocationCitation? charLocation,
            global::G.RequestPageLocationCitation? pageLocation,
            global::G.RequestContentBlockLocationCitation? contentBlockLocation
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
            global::System.Func<global::G.RequestCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::G.RequestPageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::G.RequestContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
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
            global::System.Action<global::G.RequestCharLocationCitation?>? charLocation = null,
            global::System.Action<global::G.RequestPageLocationCitation?>? pageLocation = null,
            global::System.Action<global::G.RequestContentBlockLocationCitation?>? contentBlockLocation = null,
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
                typeof(global::G.RequestCharLocationCitation),
                PageLocation,
                typeof(global::G.RequestPageLocationCitation),
                ContentBlockLocation,
                typeof(global::G.RequestContentBlockLocationCitation),
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
        public bool Equals(CitationsVariant1Item3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestPageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationsVariant1Item3 obj1, CitationsVariant1Item3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationsVariant1Item3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationsVariant1Item3 obj1, CitationsVariant1Item3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationsVariant1Item3 o && Equals(o);
        }
    }
}
