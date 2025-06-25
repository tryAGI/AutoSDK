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
        public global::G.BetaCitationsDeltaCitationDiscriminatorType? Type { get; }

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
        public static implicit operator Citation(global::G.BetaResponseCharLocationCitation value) => new Citation((global::G.BetaResponseCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseCharLocationCitation?(Citation @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::G.BetaResponseCharLocationCitation? value)
        {
            CharLocation = value;
        }

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
        public static implicit operator Citation(global::G.BetaResponsePageLocationCitation value) => new Citation((global::G.BetaResponsePageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponsePageLocationCitation?(Citation @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::G.BetaResponsePageLocationCitation? value)
        {
            PageLocation = value;
        }

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
        public static implicit operator Citation(global::G.BetaResponseContentBlockLocationCitation value) => new Citation((global::G.BetaResponseContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseContentBlockLocationCitation?(Citation @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::G.BetaResponseContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Citation(
            global::G.BetaCitationsDeltaCitationDiscriminatorType? type,
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
            global::System.Func<global::G.BetaResponseCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::G.BetaResponsePageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::G.BetaResponseContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
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
            global::System.Action<global::G.BetaResponseCharLocationCitation?>? charLocation = null,
            global::System.Action<global::G.BetaResponsePageLocationCitation?>? pageLocation = null,
            global::System.Action<global::G.BetaResponseContentBlockLocationCitation?>? contentBlockLocation = null,
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
        public bool Equals(Citation other)
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
