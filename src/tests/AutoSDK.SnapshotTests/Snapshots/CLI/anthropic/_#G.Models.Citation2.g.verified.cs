﻿//HintName: G.Models.Citation2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Citation2 : global::System.IEquatable<Citation2>
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
        public static implicit operator Citation2(global::G.ResponseCharLocationCitation value) => new Citation2((global::G.ResponseCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCharLocationCitation?(Citation2 @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation2(global::G.ResponseCharLocationCitation? value)
        {
            CharLocation = value;
        }

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
        public static implicit operator Citation2(global::G.ResponsePageLocationCitation value) => new Citation2((global::G.ResponsePageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponsePageLocationCitation?(Citation2 @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation2(global::G.ResponsePageLocationCitation? value)
        {
            PageLocation = value;
        }

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
        public static implicit operator Citation2(global::G.ResponseContentBlockLocationCitation value) => new Citation2((global::G.ResponseContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseContentBlockLocationCitation?(Citation2 @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation2(global::G.ResponseContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Citation2(
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
            global::System.Func<global::G.ResponseCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::G.ResponsePageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::G.ResponseContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
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
            global::System.Action<global::G.ResponseCharLocationCitation?>? charLocation = null,
            global::System.Action<global::G.ResponsePageLocationCitation?>? pageLocation = null,
            global::System.Action<global::G.ResponseContentBlockLocationCitation?>? contentBlockLocation = null,
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
        public bool Equals(Citation2 other)
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
        public static bool operator ==(Citation2 obj1, Citation2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Citation2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Citation2 obj1, Citation2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Citation2 o && Equals(o);
        }
    }
}
