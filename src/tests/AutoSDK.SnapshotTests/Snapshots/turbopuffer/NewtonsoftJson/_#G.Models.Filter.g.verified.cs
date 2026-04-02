//HintName: G.Models.Filter.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Filter : global::System.IEquatable<Filter>
    {
        /// <summary>
        /// Exact match for attribute value. If `null`, matches documents missing the attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant1 { get; init; }
#else
        public byte[]? FilterVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant1))]
#endif
        public bool IsFilterVariant1 => FilterVariant1 != null;

        /// <summary>
        /// Inverse of `Eq`. If value is `null`, matches documents with the attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant2 { get; init; }
#else
        public byte[]? FilterVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant2))]
#endif
        public bool IsFilterVariant2 => FilterVariant2 != null;

        /// <summary>
        /// Matches any attribute value contained in the provided list.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant3 { get; init; }
#else
        public byte[]? FilterVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant3))]
#endif
        public bool IsFilterVariant3 => FilterVariant3 != null;

        /// <summary>
        /// Inverse of `In`, matches any attributes values not contained in the provided list.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant4 { get; init; }
#else
        public byte[]? FilterVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant4))]
#endif
        public bool IsFilterVariant4 => FilterVariant4 != null;

        /// <summary>
        /// Checks whether the selected array attribute contains the provided value.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant5 { get; init; }
#else
        public byte[]? FilterVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant5))]
#endif
        public bool IsFilterVariant5 => FilterVariant5 != null;

        /// <summary>
        /// Inverse of Contains
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant6 { get; init; }
#else
        public byte[]? FilterVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant6))]
#endif
        public bool IsFilterVariant6 => FilterVariant6 != null;

        /// <summary>
        /// Checks whether the selected array attribute contains any of the values provided (intersection filter).
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant7 { get; init; }
#else
        public byte[]? FilterVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant7))]
#endif
        public bool IsFilterVariant7 => FilterVariant7 != null;

        /// <summary>
        /// Inverse of ContainsAny.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant8 { get; init; }
#else
        public byte[]? FilterVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant8))]
#endif
        public bool IsFilterVariant8 => FilterVariant8 != null;

        /// <summary>
        /// For ints, this is a numeric less-than. For strings, lexicographic less-than. For datetimes, numeric less-than on millisecond representation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant9 { get; init; }
#else
        public byte[]? FilterVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant9))]
#endif
        public bool IsFilterVariant9 => FilterVariant9 != null;

        /// <summary>
        /// For ints, this is a numeric less-than-or-equal. For strings, lexicographic less-than-or-equal. For datetimes, numeric less-than-or-equal on millisecond representation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant10 { get; init; }
#else
        public byte[]? FilterVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant10))]
#endif
        public bool IsFilterVariant10 => FilterVariant10 != null;

        /// <summary>
        /// For ints, this is a numeric greater-than. For strings, lexicographic greater-than. For datetimes, numeric greater-than on millisecond representation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant11 { get; init; }
#else
        public byte[]? FilterVariant11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant11))]
#endif
        public bool IsFilterVariant11 => FilterVariant11 != null;

        /// <summary>
        /// For ints, this is a numeric greater-than-or-equal. For strings, lexicographic greater-than-or-equal. For datetimes, numeric greater-than-or-equal on millisecond representation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant12 { get; init; }
#else
        public byte[]? FilterVariant12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant12))]
#endif
        public bool IsFilterVariant12 => FilterVariant12 != null;

        /// <summary>
        /// Checks whether any element of an array attribute is less than the provided value, using the same rules as `Lt`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant13 { get; init; }
#else
        public byte[]? FilterVariant13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant13))]
#endif
        public bool IsFilterVariant13 => FilterVariant13 != null;

        /// <summary>
        /// Checks whether any element of an array attribute is less than or equal to the provided value, using the same rules as `Lte`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant14 { get; init; }
#else
        public byte[]? FilterVariant14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant14))]
#endif
        public bool IsFilterVariant14 => FilterVariant14 != null;

        /// <summary>
        /// Checks whether any element of an array attribute is greater than the provided value, using the same rules as `Gt`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant15 { get; init; }
#else
        public byte[]? FilterVariant15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant15))]
#endif
        public bool IsFilterVariant15 => FilterVariant15 != null;

        /// <summary>
        /// Checks whether any element of an array attribute is greater than or equal to the provided value, using the same rules as `Gte`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant16 { get; init; }
#else
        public byte[]? FilterVariant16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant16))]
#endif
        public bool IsFilterVariant16 => FilterVariant16 != null;

        /// <summary>
        /// Unix-style glob match against string values. The full syntax is described in the Rust `globset` crate documentation. Glob patterns with a concrete prefix like "foo*" internally compile to efficient range queries.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant17 { get; init; }
#else
        public byte[]? FilterVariant17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant17))]
#endif
        public bool IsFilterVariant17 => FilterVariant17 != null;

        /// <summary>
        /// Inverse of `Glob`, Unix-style glob filters against string attributes values. The full syntax is described in the Rust `globset` crate documentation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant18 { get; init; }
#else
        public byte[]? FilterVariant18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant18))]
#endif
        public bool IsFilterVariant18 => FilterVariant18 != null;

        /// <summary>
        /// Case insensitive version of `Glob`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant19 { get; init; }
#else
        public byte[]? FilterVariant19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant19))]
#endif
        public bool IsFilterVariant19 => FilterVariant19 != null;

        /// <summary>
        /// Case insensitive version of `NotGlob`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant20 { get; init; }
#else
        public byte[]? FilterVariant20 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant20))]
#endif
        public bool IsFilterVariant20 => FilterVariant20 != null;

        /// <summary>
        /// Regular expression match against string values. Requires the regex schema attribute to be enabled before use.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant21 { get; init; }
#else
        public byte[]? FilterVariant21 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant21))]
#endif
        public bool IsFilterVariant21 => FilterVariant21 != null;

        /// <summary>
        /// Matches if all tokens in the input string are present in the attributes value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant22 { get; init; }
#else
        public byte[]? FilterVariant22 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant22))]
#endif
        public bool IsFilterVariant22 => FilterVariant22 != null;

        /// <summary>
        /// Matches if all tokens in the input string are present in the attributes value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant23 { get; init; }
#else
        public byte[]? FilterVariant23 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant23))]
#endif
        public bool IsFilterVariant23 => FilterVariant23 != null;

        /// <summary>
        /// Matches if all tokens in the input string are present in the attributes value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant24 { get; init; }
#else
        public byte[]? FilterVariant24 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant24))]
#endif
        public bool IsFilterVariant24 => FilterVariant24 != null;

        /// <summary>
        /// Matches if all tokens in the input string are present in the attributes value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant25 { get; init; }
#else
        public byte[]? FilterVariant25 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant25))]
#endif
        public bool IsFilterVariant25 => FilterVariant25 != null;

        /// <summary>
        /// Matches if any of the tokens in the input string are present in the attribute value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant26 { get; init; }
#else
        public byte[]? FilterVariant26 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant26))]
#endif
        public bool IsFilterVariant26 => FilterVariant26 != null;

        /// <summary>
        /// Matches if any of the tokens in the input string array are present in the attribute value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant27 { get; init; }
#else
        public byte[]? FilterVariant27 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant27))]
#endif
        public bool IsFilterVariant27 => FilterVariant27 != null;

        /// <summary>
        /// Matches if any of the tokens in the input string are present in the attribute value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant28 { get; init; }
#else
        public byte[]? FilterVariant28 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant28))]
#endif
        public bool IsFilterVariant28 => FilterVariant28 != null;

        /// <summary>
        /// Matches if any of the tokens in the input string array are present in the attribute value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant29 { get; init; }
#else
        public byte[]? FilterVariant29 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant29))]
#endif
        public bool IsFilterVariant29 => FilterVariant29 != null;

        /// <summary>
        /// Matches if all the tokens in the input string are present in the attribute value, in the correct order (i.e., as a phrase). Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant30 { get; init; }
#else
        public byte[]? FilterVariant30 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant30))]
#endif
        public bool IsFilterVariant30 => FilterVariant30 != null;

        /// <summary>
        /// Matches if all the tokens in the input string are present in the attribute value, in the correct order (i.e., as a phrase). Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant31 { get; init; }
#else
        public byte[]? FilterVariant31 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant31))]
#endif
        public bool IsFilterVariant31 => FilterVariant31 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant32 { get; init; }
#else
        public byte[]? FilterVariant32 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant32))]
#endif
        public bool IsFilterVariant32 => FilterVariant32 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant33 { get; init; }
#else
        public byte[]? FilterVariant33 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant33))]
#endif
        public bool IsFilterVariant33 => FilterVariant33 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? FilterVariant34 { get; init; }
#else
        public byte[]? FilterVariant34 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilterVariant34))]
#endif
        public bool IsFilterVariant34 => FilterVariant34 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Filter(byte[] value) => new Filter((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(Filter @this) => @this.FilterVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Filter(byte[]? value)
        {
            FilterVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Filter(
            byte[]? filterVariant1,
            byte[]? filterVariant2,
            byte[]? filterVariant3,
            byte[]? filterVariant4,
            byte[]? filterVariant5,
            byte[]? filterVariant6,
            byte[]? filterVariant7,
            byte[]? filterVariant8,
            byte[]? filterVariant9,
            byte[]? filterVariant10,
            byte[]? filterVariant11,
            byte[]? filterVariant12,
            byte[]? filterVariant13,
            byte[]? filterVariant14,
            byte[]? filterVariant15,
            byte[]? filterVariant16,
            byte[]? filterVariant17,
            byte[]? filterVariant18,
            byte[]? filterVariant19,
            byte[]? filterVariant20,
            byte[]? filterVariant21,
            byte[]? filterVariant22,
            byte[]? filterVariant23,
            byte[]? filterVariant24,
            byte[]? filterVariant25,
            byte[]? filterVariant26,
            byte[]? filterVariant27,
            byte[]? filterVariant28,
            byte[]? filterVariant29,
            byte[]? filterVariant30,
            byte[]? filterVariant31,
            byte[]? filterVariant32,
            byte[]? filterVariant33,
            byte[]? filterVariant34
            )
        {
            FilterVariant1 = filterVariant1;
            FilterVariant2 = filterVariant2;
            FilterVariant3 = filterVariant3;
            FilterVariant4 = filterVariant4;
            FilterVariant5 = filterVariant5;
            FilterVariant6 = filterVariant6;
            FilterVariant7 = filterVariant7;
            FilterVariant8 = filterVariant8;
            FilterVariant9 = filterVariant9;
            FilterVariant10 = filterVariant10;
            FilterVariant11 = filterVariant11;
            FilterVariant12 = filterVariant12;
            FilterVariant13 = filterVariant13;
            FilterVariant14 = filterVariant14;
            FilterVariant15 = filterVariant15;
            FilterVariant16 = filterVariant16;
            FilterVariant17 = filterVariant17;
            FilterVariant18 = filterVariant18;
            FilterVariant19 = filterVariant19;
            FilterVariant20 = filterVariant20;
            FilterVariant21 = filterVariant21;
            FilterVariant22 = filterVariant22;
            FilterVariant23 = filterVariant23;
            FilterVariant24 = filterVariant24;
            FilterVariant25 = filterVariant25;
            FilterVariant26 = filterVariant26;
            FilterVariant27 = filterVariant27;
            FilterVariant28 = filterVariant28;
            FilterVariant29 = filterVariant29;
            FilterVariant30 = filterVariant30;
            FilterVariant31 = filterVariant31;
            FilterVariant32 = filterVariant32;
            FilterVariant33 = filterVariant33;
            FilterVariant34 = filterVariant34;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FilterVariant34 as object ??
            FilterVariant33 as object ??
            FilterVariant32 as object ??
            FilterVariant31 as object ??
            FilterVariant30 as object ??
            FilterVariant29 as object ??
            FilterVariant28 as object ??
            FilterVariant27 as object ??
            FilterVariant26 as object ??
            FilterVariant25 as object ??
            FilterVariant24 as object ??
            FilterVariant23 as object ??
            FilterVariant22 as object ??
            FilterVariant21 as object ??
            FilterVariant20 as object ??
            FilterVariant19 as object ??
            FilterVariant18 as object ??
            FilterVariant17 as object ??
            FilterVariant16 as object ??
            FilterVariant15 as object ??
            FilterVariant14 as object ??
            FilterVariant13 as object ??
            FilterVariant12 as object ??
            FilterVariant11 as object ??
            FilterVariant10 as object ??
            FilterVariant9 as object ??
            FilterVariant8 as object ??
            FilterVariant7 as object ??
            FilterVariant6 as object ??
            FilterVariant5 as object ??
            FilterVariant4 as object ??
            FilterVariant3 as object ??
            FilterVariant2 as object ??
            FilterVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FilterVariant1?.ToString() ??
            FilterVariant2?.ToString() ??
            FilterVariant3?.ToString() ??
            FilterVariant4?.ToString() ??
            FilterVariant5?.ToString() ??
            FilterVariant6?.ToString() ??
            FilterVariant7?.ToString() ??
            FilterVariant8?.ToString() ??
            FilterVariant9?.ToString() ??
            FilterVariant10?.ToString() ??
            FilterVariant11?.ToString() ??
            FilterVariant12?.ToString() ??
            FilterVariant13?.ToString() ??
            FilterVariant14?.ToString() ??
            FilterVariant15?.ToString() ??
            FilterVariant16?.ToString() ??
            FilterVariant17?.ToString() ??
            FilterVariant18?.ToString() ??
            FilterVariant19?.ToString() ??
            FilterVariant20?.ToString() ??
            FilterVariant21?.ToString() ??
            FilterVariant22?.ToString() ??
            FilterVariant23?.ToString() ??
            FilterVariant24?.ToString() ??
            FilterVariant25?.ToString() ??
            FilterVariant26?.ToString() ??
            FilterVariant27?.ToString() ??
            FilterVariant28?.ToString() ??
            FilterVariant29?.ToString() ??
            FilterVariant30?.ToString() ??
            FilterVariant31?.ToString() ??
            FilterVariant32?.ToString() ??
            FilterVariant33?.ToString() ??
            FilterVariant34?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFilterVariant1 || IsFilterVariant2 || IsFilterVariant3 || IsFilterVariant4 || IsFilterVariant5 || IsFilterVariant6 || IsFilterVariant7 || IsFilterVariant8 || IsFilterVariant9 || IsFilterVariant10 || IsFilterVariant11 || IsFilterVariant12 || IsFilterVariant13 || IsFilterVariant14 || IsFilterVariant15 || IsFilterVariant16 || IsFilterVariant17 || IsFilterVariant18 || IsFilterVariant19 || IsFilterVariant20 || IsFilterVariant21 || IsFilterVariant22 || IsFilterVariant23 || IsFilterVariant24 || IsFilterVariant25 || IsFilterVariant26 || IsFilterVariant27 || IsFilterVariant28 || IsFilterVariant29 || IsFilterVariant30 || IsFilterVariant31 || IsFilterVariant32 || IsFilterVariant33 || IsFilterVariant34;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? filterVariant1 = null,
            global::System.Func<byte[]?, TResult>? filterVariant2 = null,
            global::System.Func<byte[]?, TResult>? filterVariant3 = null,
            global::System.Func<byte[]?, TResult>? filterVariant4 = null,
            global::System.Func<byte[]?, TResult>? filterVariant5 = null,
            global::System.Func<byte[]?, TResult>? filterVariant6 = null,
            global::System.Func<byte[]?, TResult>? filterVariant7 = null,
            global::System.Func<byte[]?, TResult>? filterVariant8 = null,
            global::System.Func<byte[]?, TResult>? filterVariant9 = null,
            global::System.Func<byte[]?, TResult>? filterVariant10 = null,
            global::System.Func<byte[]?, TResult>? filterVariant11 = null,
            global::System.Func<byte[]?, TResult>? filterVariant12 = null,
            global::System.Func<byte[]?, TResult>? filterVariant13 = null,
            global::System.Func<byte[]?, TResult>? filterVariant14 = null,
            global::System.Func<byte[]?, TResult>? filterVariant15 = null,
            global::System.Func<byte[]?, TResult>? filterVariant16 = null,
            global::System.Func<byte[]?, TResult>? filterVariant17 = null,
            global::System.Func<byte[]?, TResult>? filterVariant18 = null,
            global::System.Func<byte[]?, TResult>? filterVariant19 = null,
            global::System.Func<byte[]?, TResult>? filterVariant20 = null,
            global::System.Func<byte[]?, TResult>? filterVariant21 = null,
            global::System.Func<byte[]?, TResult>? filterVariant22 = null,
            global::System.Func<byte[]?, TResult>? filterVariant23 = null,
            global::System.Func<byte[]?, TResult>? filterVariant24 = null,
            global::System.Func<byte[]?, TResult>? filterVariant25 = null,
            global::System.Func<byte[]?, TResult>? filterVariant26 = null,
            global::System.Func<byte[]?, TResult>? filterVariant27 = null,
            global::System.Func<byte[]?, TResult>? filterVariant28 = null,
            global::System.Func<byte[]?, TResult>? filterVariant29 = null,
            global::System.Func<byte[]?, TResult>? filterVariant30 = null,
            global::System.Func<byte[]?, TResult>? filterVariant31 = null,
            global::System.Func<byte[]?, TResult>? filterVariant32 = null,
            global::System.Func<byte[]?, TResult>? filterVariant33 = null,
            global::System.Func<byte[]?, TResult>? filterVariant34 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFilterVariant1 && filterVariant1 != null)
            {
                return filterVariant1(FilterVariant1!);
            }
            else if (IsFilterVariant2 && filterVariant2 != null)
            {
                return filterVariant2(FilterVariant2!);
            }
            else if (IsFilterVariant3 && filterVariant3 != null)
            {
                return filterVariant3(FilterVariant3!);
            }
            else if (IsFilterVariant4 && filterVariant4 != null)
            {
                return filterVariant4(FilterVariant4!);
            }
            else if (IsFilterVariant5 && filterVariant5 != null)
            {
                return filterVariant5(FilterVariant5!);
            }
            else if (IsFilterVariant6 && filterVariant6 != null)
            {
                return filterVariant6(FilterVariant6!);
            }
            else if (IsFilterVariant7 && filterVariant7 != null)
            {
                return filterVariant7(FilterVariant7!);
            }
            else if (IsFilterVariant8 && filterVariant8 != null)
            {
                return filterVariant8(FilterVariant8!);
            }
            else if (IsFilterVariant9 && filterVariant9 != null)
            {
                return filterVariant9(FilterVariant9!);
            }
            else if (IsFilterVariant10 && filterVariant10 != null)
            {
                return filterVariant10(FilterVariant10!);
            }
            else if (IsFilterVariant11 && filterVariant11 != null)
            {
                return filterVariant11(FilterVariant11!);
            }
            else if (IsFilterVariant12 && filterVariant12 != null)
            {
                return filterVariant12(FilterVariant12!);
            }
            else if (IsFilterVariant13 && filterVariant13 != null)
            {
                return filterVariant13(FilterVariant13!);
            }
            else if (IsFilterVariant14 && filterVariant14 != null)
            {
                return filterVariant14(FilterVariant14!);
            }
            else if (IsFilterVariant15 && filterVariant15 != null)
            {
                return filterVariant15(FilterVariant15!);
            }
            else if (IsFilterVariant16 && filterVariant16 != null)
            {
                return filterVariant16(FilterVariant16!);
            }
            else if (IsFilterVariant17 && filterVariant17 != null)
            {
                return filterVariant17(FilterVariant17!);
            }
            else if (IsFilterVariant18 && filterVariant18 != null)
            {
                return filterVariant18(FilterVariant18!);
            }
            else if (IsFilterVariant19 && filterVariant19 != null)
            {
                return filterVariant19(FilterVariant19!);
            }
            else if (IsFilterVariant20 && filterVariant20 != null)
            {
                return filterVariant20(FilterVariant20!);
            }
            else if (IsFilterVariant21 && filterVariant21 != null)
            {
                return filterVariant21(FilterVariant21!);
            }
            else if (IsFilterVariant22 && filterVariant22 != null)
            {
                return filterVariant22(FilterVariant22!);
            }
            else if (IsFilterVariant23 && filterVariant23 != null)
            {
                return filterVariant23(FilterVariant23!);
            }
            else if (IsFilterVariant24 && filterVariant24 != null)
            {
                return filterVariant24(FilterVariant24!);
            }
            else if (IsFilterVariant25 && filterVariant25 != null)
            {
                return filterVariant25(FilterVariant25!);
            }
            else if (IsFilterVariant26 && filterVariant26 != null)
            {
                return filterVariant26(FilterVariant26!);
            }
            else if (IsFilterVariant27 && filterVariant27 != null)
            {
                return filterVariant27(FilterVariant27!);
            }
            else if (IsFilterVariant28 && filterVariant28 != null)
            {
                return filterVariant28(FilterVariant28!);
            }
            else if (IsFilterVariant29 && filterVariant29 != null)
            {
                return filterVariant29(FilterVariant29!);
            }
            else if (IsFilterVariant30 && filterVariant30 != null)
            {
                return filterVariant30(FilterVariant30!);
            }
            else if (IsFilterVariant31 && filterVariant31 != null)
            {
                return filterVariant31(FilterVariant31!);
            }
            else if (IsFilterVariant32 && filterVariant32 != null)
            {
                return filterVariant32(FilterVariant32!);
            }
            else if (IsFilterVariant33 && filterVariant33 != null)
            {
                return filterVariant33(FilterVariant33!);
            }
            else if (IsFilterVariant34 && filterVariant34 != null)
            {
                return filterVariant34(FilterVariant34!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? filterVariant1 = null,
            global::System.Action<byte[]?>? filterVariant2 = null,
            global::System.Action<byte[]?>? filterVariant3 = null,
            global::System.Action<byte[]?>? filterVariant4 = null,
            global::System.Action<byte[]?>? filterVariant5 = null,
            global::System.Action<byte[]?>? filterVariant6 = null,
            global::System.Action<byte[]?>? filterVariant7 = null,
            global::System.Action<byte[]?>? filterVariant8 = null,
            global::System.Action<byte[]?>? filterVariant9 = null,
            global::System.Action<byte[]?>? filterVariant10 = null,
            global::System.Action<byte[]?>? filterVariant11 = null,
            global::System.Action<byte[]?>? filterVariant12 = null,
            global::System.Action<byte[]?>? filterVariant13 = null,
            global::System.Action<byte[]?>? filterVariant14 = null,
            global::System.Action<byte[]?>? filterVariant15 = null,
            global::System.Action<byte[]?>? filterVariant16 = null,
            global::System.Action<byte[]?>? filterVariant17 = null,
            global::System.Action<byte[]?>? filterVariant18 = null,
            global::System.Action<byte[]?>? filterVariant19 = null,
            global::System.Action<byte[]?>? filterVariant20 = null,
            global::System.Action<byte[]?>? filterVariant21 = null,
            global::System.Action<byte[]?>? filterVariant22 = null,
            global::System.Action<byte[]?>? filterVariant23 = null,
            global::System.Action<byte[]?>? filterVariant24 = null,
            global::System.Action<byte[]?>? filterVariant25 = null,
            global::System.Action<byte[]?>? filterVariant26 = null,
            global::System.Action<byte[]?>? filterVariant27 = null,
            global::System.Action<byte[]?>? filterVariant28 = null,
            global::System.Action<byte[]?>? filterVariant29 = null,
            global::System.Action<byte[]?>? filterVariant30 = null,
            global::System.Action<byte[]?>? filterVariant31 = null,
            global::System.Action<byte[]?>? filterVariant32 = null,
            global::System.Action<byte[]?>? filterVariant33 = null,
            global::System.Action<byte[]?>? filterVariant34 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFilterVariant1)
            {
                filterVariant1?.Invoke(FilterVariant1!);
            }
            else if (IsFilterVariant2)
            {
                filterVariant2?.Invoke(FilterVariant2!);
            }
            else if (IsFilterVariant3)
            {
                filterVariant3?.Invoke(FilterVariant3!);
            }
            else if (IsFilterVariant4)
            {
                filterVariant4?.Invoke(FilterVariant4!);
            }
            else if (IsFilterVariant5)
            {
                filterVariant5?.Invoke(FilterVariant5!);
            }
            else if (IsFilterVariant6)
            {
                filterVariant6?.Invoke(FilterVariant6!);
            }
            else if (IsFilterVariant7)
            {
                filterVariant7?.Invoke(FilterVariant7!);
            }
            else if (IsFilterVariant8)
            {
                filterVariant8?.Invoke(FilterVariant8!);
            }
            else if (IsFilterVariant9)
            {
                filterVariant9?.Invoke(FilterVariant9!);
            }
            else if (IsFilterVariant10)
            {
                filterVariant10?.Invoke(FilterVariant10!);
            }
            else if (IsFilterVariant11)
            {
                filterVariant11?.Invoke(FilterVariant11!);
            }
            else if (IsFilterVariant12)
            {
                filterVariant12?.Invoke(FilterVariant12!);
            }
            else if (IsFilterVariant13)
            {
                filterVariant13?.Invoke(FilterVariant13!);
            }
            else if (IsFilterVariant14)
            {
                filterVariant14?.Invoke(FilterVariant14!);
            }
            else if (IsFilterVariant15)
            {
                filterVariant15?.Invoke(FilterVariant15!);
            }
            else if (IsFilterVariant16)
            {
                filterVariant16?.Invoke(FilterVariant16!);
            }
            else if (IsFilterVariant17)
            {
                filterVariant17?.Invoke(FilterVariant17!);
            }
            else if (IsFilterVariant18)
            {
                filterVariant18?.Invoke(FilterVariant18!);
            }
            else if (IsFilterVariant19)
            {
                filterVariant19?.Invoke(FilterVariant19!);
            }
            else if (IsFilterVariant20)
            {
                filterVariant20?.Invoke(FilterVariant20!);
            }
            else if (IsFilterVariant21)
            {
                filterVariant21?.Invoke(FilterVariant21!);
            }
            else if (IsFilterVariant22)
            {
                filterVariant22?.Invoke(FilterVariant22!);
            }
            else if (IsFilterVariant23)
            {
                filterVariant23?.Invoke(FilterVariant23!);
            }
            else if (IsFilterVariant24)
            {
                filterVariant24?.Invoke(FilterVariant24!);
            }
            else if (IsFilterVariant25)
            {
                filterVariant25?.Invoke(FilterVariant25!);
            }
            else if (IsFilterVariant26)
            {
                filterVariant26?.Invoke(FilterVariant26!);
            }
            else if (IsFilterVariant27)
            {
                filterVariant27?.Invoke(FilterVariant27!);
            }
            else if (IsFilterVariant28)
            {
                filterVariant28?.Invoke(FilterVariant28!);
            }
            else if (IsFilterVariant29)
            {
                filterVariant29?.Invoke(FilterVariant29!);
            }
            else if (IsFilterVariant30)
            {
                filterVariant30?.Invoke(FilterVariant30!);
            }
            else if (IsFilterVariant31)
            {
                filterVariant31?.Invoke(FilterVariant31!);
            }
            else if (IsFilterVariant32)
            {
                filterVariant32?.Invoke(FilterVariant32!);
            }
            else if (IsFilterVariant33)
            {
                filterVariant33?.Invoke(FilterVariant33!);
            }
            else if (IsFilterVariant34)
            {
                filterVariant34?.Invoke(FilterVariant34!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FilterVariant1,
                typeof(byte[]),
                FilterVariant2,
                typeof(byte[]),
                FilterVariant3,
                typeof(byte[]),
                FilterVariant4,
                typeof(byte[]),
                FilterVariant5,
                typeof(byte[]),
                FilterVariant6,
                typeof(byte[]),
                FilterVariant7,
                typeof(byte[]),
                FilterVariant8,
                typeof(byte[]),
                FilterVariant9,
                typeof(byte[]),
                FilterVariant10,
                typeof(byte[]),
                FilterVariant11,
                typeof(byte[]),
                FilterVariant12,
                typeof(byte[]),
                FilterVariant13,
                typeof(byte[]),
                FilterVariant14,
                typeof(byte[]),
                FilterVariant15,
                typeof(byte[]),
                FilterVariant16,
                typeof(byte[]),
                FilterVariant17,
                typeof(byte[]),
                FilterVariant18,
                typeof(byte[]),
                FilterVariant19,
                typeof(byte[]),
                FilterVariant20,
                typeof(byte[]),
                FilterVariant21,
                typeof(byte[]),
                FilterVariant22,
                typeof(byte[]),
                FilterVariant23,
                typeof(byte[]),
                FilterVariant24,
                typeof(byte[]),
                FilterVariant25,
                typeof(byte[]),
                FilterVariant26,
                typeof(byte[]),
                FilterVariant27,
                typeof(byte[]),
                FilterVariant28,
                typeof(byte[]),
                FilterVariant29,
                typeof(byte[]),
                FilterVariant30,
                typeof(byte[]),
                FilterVariant31,
                typeof(byte[]),
                FilterVariant32,
                typeof(byte[]),
                FilterVariant33,
                typeof(byte[]),
                FilterVariant34,
                typeof(byte[]),
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
        public bool Equals(Filter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant1, other.FilterVariant1) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant2, other.FilterVariant2) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant3, other.FilterVariant3) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant4, other.FilterVariant4) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant5, other.FilterVariant5) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant6, other.FilterVariant6) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant7, other.FilterVariant7) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant8, other.FilterVariant8) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant9, other.FilterVariant9) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant10, other.FilterVariant10) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant11, other.FilterVariant11) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant12, other.FilterVariant12) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant13, other.FilterVariant13) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant14, other.FilterVariant14) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant15, other.FilterVariant15) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant16, other.FilterVariant16) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant17, other.FilterVariant17) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant18, other.FilterVariant18) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant19, other.FilterVariant19) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant20, other.FilterVariant20) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant21, other.FilterVariant21) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant22, other.FilterVariant22) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant23, other.FilterVariant23) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant24, other.FilterVariant24) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant25, other.FilterVariant25) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant26, other.FilterVariant26) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant27, other.FilterVariant27) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant28, other.FilterVariant28) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant29, other.FilterVariant29) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant30, other.FilterVariant30) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant31, other.FilterVariant31) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant32, other.FilterVariant32) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant33, other.FilterVariant33) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(FilterVariant34, other.FilterVariant34) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Filter obj1, Filter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Filter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Filter obj1, Filter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Filter o && Equals(o);
        }
    }
}
