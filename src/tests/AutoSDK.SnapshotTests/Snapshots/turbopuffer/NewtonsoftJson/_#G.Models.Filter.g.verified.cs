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
        public byte[]? Value1 { get; init; }
#else
        public byte[]? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Inverse of `Eq`. If value is `null`, matches documents with the attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value2 { get; init; }
#else
        public byte[]? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Matches any attribute value contained in the provided list.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value3 { get; init; }
#else
        public byte[]? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// Inverse of `In`, matches any attributes values not contained in the provided list.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value4 { get; init; }
#else
        public byte[]? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// Checks whether the selected array attribute contains the provided value.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value5 { get; init; }
#else
        public byte[]? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// Inverse of Contains
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value6 { get; init; }
#else
        public byte[]? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// Checks whether the selected array attribute contains any of the values provided (intersection filter).
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value7 { get; init; }
#else
        public byte[]? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// Inverse of ContainsAny.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value8 { get; init; }
#else
        public byte[]? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// For ints, this is a numeric less-than. For strings, lexicographic less-than. For datetimes, numeric less-than on millisecond representation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value9 { get; init; }
#else
        public byte[]? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// For ints, this is a numeric less-than-or-equal. For strings, lexicographic less-than-or-equal. For datetimes, numeric less-than-or-equal on millisecond representation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value10 { get; init; }
#else
        public byte[]? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// For ints, this is a numeric greater-than. For strings, lexicographic greater-than. For datetimes, numeric greater-than on millisecond representation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value11 { get; init; }
#else
        public byte[]? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// For ints, this is a numeric greater-than-or-equal. For strings, lexicographic greater-than-or-equal. For datetimes, numeric greater-than-or-equal on millisecond representation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value12 { get; init; }
#else
        public byte[]? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// Checks whether any element of an array attribute is less than the provided value, using the same rules as `Lt`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value13 { get; init; }
#else
        public byte[]? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// Checks whether any element of an array attribute is less than or equal to the provided value, using the same rules as `Lte`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value14 { get; init; }
#else
        public byte[]? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        /// Checks whether any element of an array attribute is greater than the provided value, using the same rules as `Gt`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value15 { get; init; }
#else
        public byte[]? Value15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        /// <summary>
        /// Checks whether any element of an array attribute is greater than or equal to the provided value, using the same rules as `Gte`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value16 { get; init; }
#else
        public byte[]? Value16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        /// <summary>
        /// Unix-style glob match against string values. The full syntax is described in the Rust `globset` crate documentation. Glob patterns with a concrete prefix like "foo*" internally compile to efficient range queries.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value17 { get; init; }
#else
        public byte[]? Value17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value17))]
#endif
        public bool IsValue17 => Value17 != null;

        /// <summary>
        /// Inverse of `Glob`, Unix-style glob filters against string attributes values. The full syntax is described in the Rust `globset` crate documentation.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value18 { get; init; }
#else
        public byte[]? Value18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value18))]
#endif
        public bool IsValue18 => Value18 != null;

        /// <summary>
        /// Case insensitive version of `Glob`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value19 { get; init; }
#else
        public byte[]? Value19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value19))]
#endif
        public bool IsValue19 => Value19 != null;

        /// <summary>
        /// Case insensitive version of `NotGlob`.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value20 { get; init; }
#else
        public byte[]? Value20 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value20))]
#endif
        public bool IsValue20 => Value20 != null;

        /// <summary>
        /// Regular expression match against string values. Requires the regex schema attribute to be enabled before use.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value21 { get; init; }
#else
        public byte[]? Value21 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value21))]
#endif
        public bool IsValue21 => Value21 != null;

        /// <summary>
        /// Matches if all tokens in the input string are present in the attributes value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value22 { get; init; }
#else
        public byte[]? Value22 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value22))]
#endif
        public bool IsValue22 => Value22 != null;

        /// <summary>
        /// Matches if all tokens in the input string are present in the attributes value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value23 { get; init; }
#else
        public byte[]? Value23 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value23))]
#endif
        public bool IsValue23 => Value23 != null;

        /// <summary>
        /// Matches if all tokens in the input string are present in the attributes value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value24 { get; init; }
#else
        public byte[]? Value24 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value24))]
#endif
        public bool IsValue24 => Value24 != null;

        /// <summary>
        /// Matches if all tokens in the input string are present in the attributes value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value25 { get; init; }
#else
        public byte[]? Value25 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value25))]
#endif
        public bool IsValue25 => Value25 != null;

        /// <summary>
        /// Matches if any of the tokens in the input string are present in the attribute value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value26 { get; init; }
#else
        public byte[]? Value26 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value26))]
#endif
        public bool IsValue26 => Value26 != null;

        /// <summary>
        /// Matches if any of the tokens in the input string array are present in the attribute value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value27 { get; init; }
#else
        public byte[]? Value27 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value27))]
#endif
        public bool IsValue27 => Value27 != null;

        /// <summary>
        /// Matches if any of the tokens in the input string are present in the attribute value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value28 { get; init; }
#else
        public byte[]? Value28 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value28))]
#endif
        public bool IsValue28 => Value28 != null;

        /// <summary>
        /// Matches if any of the tokens in the input string array are present in the attribute value. Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value29 { get; init; }
#else
        public byte[]? Value29 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value29))]
#endif
        public bool IsValue29 => Value29 != null;

        /// <summary>
        /// Matches if all the tokens in the input string are present in the attribute value, in the correct order (i.e., as a phrase). Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value30 { get; init; }
#else
        public byte[]? Value30 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value30))]
#endif
        public bool IsValue30 => Value30 != null;

        /// <summary>
        /// Matches if all the tokens in the input string are present in the attribute value, in the correct order (i.e., as a phrase). Requires that the attribute is configured for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value31 { get; init; }
#else
        public byte[]? Value31 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value31))]
#endif
        public bool IsValue31 => Value31 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value32 { get; init; }
#else
        public byte[]? Value32 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value32))]
#endif
        public bool IsValue32 => Value32 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value33 { get; init; }
#else
        public byte[]? Value33 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value33))]
#endif
        public bool IsValue33 => Value33 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value34 { get; init; }
#else
        public byte[]? Value34 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value34))]
#endif
        public bool IsValue34 => Value34 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Filter(byte[] value) => new Filter((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(Filter @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Filter(byte[]? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Filter(
            byte[]? value1,
            byte[]? value2,
            byte[]? value3,
            byte[]? value4,
            byte[]? value5,
            byte[]? value6,
            byte[]? value7,
            byte[]? value8,
            byte[]? value9,
            byte[]? value10,
            byte[]? value11,
            byte[]? value12,
            byte[]? value13,
            byte[]? value14,
            byte[]? value15,
            byte[]? value16,
            byte[]? value17,
            byte[]? value18,
            byte[]? value19,
            byte[]? value20,
            byte[]? value21,
            byte[]? value22,
            byte[]? value23,
            byte[]? value24,
            byte[]? value25,
            byte[]? value26,
            byte[]? value27,
            byte[]? value28,
            byte[]? value29,
            byte[]? value30,
            byte[]? value31,
            byte[]? value32,
            byte[]? value33,
            byte[]? value34
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
            Value15 = value15;
            Value16 = value16;
            Value17 = value17;
            Value18 = value18;
            Value19 = value19;
            Value20 = value20;
            Value21 = value21;
            Value22 = value22;
            Value23 = value23;
            Value24 = value24;
            Value25 = value25;
            Value26 = value26;
            Value27 = value27;
            Value28 = value28;
            Value29 = value29;
            Value30 = value30;
            Value31 = value31;
            Value32 = value32;
            Value33 = value33;
            Value34 = value34;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value34 as object ??
            Value33 as object ??
            Value32 as object ??
            Value31 as object ??
            Value30 as object ??
            Value29 as object ??
            Value28 as object ??
            Value27 as object ??
            Value26 as object ??
            Value25 as object ??
            Value24 as object ??
            Value23 as object ??
            Value22 as object ??
            Value21 as object ??
            Value20 as object ??
            Value19 as object ??
            Value18 as object ??
            Value17 as object ??
            Value16 as object ??
            Value15 as object ??
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() ??
            Value11?.ToString() ??
            Value12?.ToString() ??
            Value13?.ToString() ??
            Value14?.ToString() ??
            Value15?.ToString() ??
            Value16?.ToString() ??
            Value17?.ToString() ??
            Value18?.ToString() ??
            Value19?.ToString() ??
            Value20?.ToString() ??
            Value21?.ToString() ??
            Value22?.ToString() ??
            Value23?.ToString() ??
            Value24?.ToString() ??
            Value25?.ToString() ??
            Value26?.ToString() ??
            Value27?.ToString() ??
            Value28?.ToString() ??
            Value29?.ToString() ??
            Value30?.ToString() ??
            Value31?.ToString() ??
            Value32?.ToString() ??
            Value33?.ToString() ??
            Value34?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7 || IsValue8 || IsValue9 || IsValue10 || IsValue11 || IsValue12 || IsValue13 || IsValue14 || IsValue15 || IsValue16 || IsValue17 || IsValue18 || IsValue19 || IsValue20 || IsValue21 || IsValue22 || IsValue23 || IsValue24 || IsValue25 || IsValue26 || IsValue27 || IsValue28 || IsValue29 || IsValue30 || IsValue31 || IsValue32 || IsValue33 || IsValue34;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? value1 = null,
            global::System.Func<byte[]?, TResult>? value2 = null,
            global::System.Func<byte[]?, TResult>? value3 = null,
            global::System.Func<byte[]?, TResult>? value4 = null,
            global::System.Func<byte[]?, TResult>? value5 = null,
            global::System.Func<byte[]?, TResult>? value6 = null,
            global::System.Func<byte[]?, TResult>? value7 = null,
            global::System.Func<byte[]?, TResult>? value8 = null,
            global::System.Func<byte[]?, TResult>? value9 = null,
            global::System.Func<byte[]?, TResult>? value10 = null,
            global::System.Func<byte[]?, TResult>? value11 = null,
            global::System.Func<byte[]?, TResult>? value12 = null,
            global::System.Func<byte[]?, TResult>? value13 = null,
            global::System.Func<byte[]?, TResult>? value14 = null,
            global::System.Func<byte[]?, TResult>? value15 = null,
            global::System.Func<byte[]?, TResult>? value16 = null,
            global::System.Func<byte[]?, TResult>? value17 = null,
            global::System.Func<byte[]?, TResult>? value18 = null,
            global::System.Func<byte[]?, TResult>? value19 = null,
            global::System.Func<byte[]?, TResult>? value20 = null,
            global::System.Func<byte[]?, TResult>? value21 = null,
            global::System.Func<byte[]?, TResult>? value22 = null,
            global::System.Func<byte[]?, TResult>? value23 = null,
            global::System.Func<byte[]?, TResult>? value24 = null,
            global::System.Func<byte[]?, TResult>? value25 = null,
            global::System.Func<byte[]?, TResult>? value26 = null,
            global::System.Func<byte[]?, TResult>? value27 = null,
            global::System.Func<byte[]?, TResult>? value28 = null,
            global::System.Func<byte[]?, TResult>? value29 = null,
            global::System.Func<byte[]?, TResult>? value30 = null,
            global::System.Func<byte[]?, TResult>? value31 = null,
            global::System.Func<byte[]?, TResult>? value32 = null,
            global::System.Func<byte[]?, TResult>? value33 = null,
            global::System.Func<byte[]?, TResult>? value34 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }
            else if (IsValue15 && value15 != null)
            {
                return value15(Value15!);
            }
            else if (IsValue16 && value16 != null)
            {
                return value16(Value16!);
            }
            else if (IsValue17 && value17 != null)
            {
                return value17(Value17!);
            }
            else if (IsValue18 && value18 != null)
            {
                return value18(Value18!);
            }
            else if (IsValue19 && value19 != null)
            {
                return value19(Value19!);
            }
            else if (IsValue20 && value20 != null)
            {
                return value20(Value20!);
            }
            else if (IsValue21 && value21 != null)
            {
                return value21(Value21!);
            }
            else if (IsValue22 && value22 != null)
            {
                return value22(Value22!);
            }
            else if (IsValue23 && value23 != null)
            {
                return value23(Value23!);
            }
            else if (IsValue24 && value24 != null)
            {
                return value24(Value24!);
            }
            else if (IsValue25 && value25 != null)
            {
                return value25(Value25!);
            }
            else if (IsValue26 && value26 != null)
            {
                return value26(Value26!);
            }
            else if (IsValue27 && value27 != null)
            {
                return value27(Value27!);
            }
            else if (IsValue28 && value28 != null)
            {
                return value28(Value28!);
            }
            else if (IsValue29 && value29 != null)
            {
                return value29(Value29!);
            }
            else if (IsValue30 && value30 != null)
            {
                return value30(Value30!);
            }
            else if (IsValue31 && value31 != null)
            {
                return value31(Value31!);
            }
            else if (IsValue32 && value32 != null)
            {
                return value32(Value32!);
            }
            else if (IsValue33 && value33 != null)
            {
                return value33(Value33!);
            }
            else if (IsValue34 && value34 != null)
            {
                return value34(Value34!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? value1 = null,
            global::System.Action<byte[]?>? value2 = null,
            global::System.Action<byte[]?>? value3 = null,
            global::System.Action<byte[]?>? value4 = null,
            global::System.Action<byte[]?>? value5 = null,
            global::System.Action<byte[]?>? value6 = null,
            global::System.Action<byte[]?>? value7 = null,
            global::System.Action<byte[]?>? value8 = null,
            global::System.Action<byte[]?>? value9 = null,
            global::System.Action<byte[]?>? value10 = null,
            global::System.Action<byte[]?>? value11 = null,
            global::System.Action<byte[]?>? value12 = null,
            global::System.Action<byte[]?>? value13 = null,
            global::System.Action<byte[]?>? value14 = null,
            global::System.Action<byte[]?>? value15 = null,
            global::System.Action<byte[]?>? value16 = null,
            global::System.Action<byte[]?>? value17 = null,
            global::System.Action<byte[]?>? value18 = null,
            global::System.Action<byte[]?>? value19 = null,
            global::System.Action<byte[]?>? value20 = null,
            global::System.Action<byte[]?>? value21 = null,
            global::System.Action<byte[]?>? value22 = null,
            global::System.Action<byte[]?>? value23 = null,
            global::System.Action<byte[]?>? value24 = null,
            global::System.Action<byte[]?>? value25 = null,
            global::System.Action<byte[]?>? value26 = null,
            global::System.Action<byte[]?>? value27 = null,
            global::System.Action<byte[]?>? value28 = null,
            global::System.Action<byte[]?>? value29 = null,
            global::System.Action<byte[]?>? value30 = null,
            global::System.Action<byte[]?>? value31 = null,
            global::System.Action<byte[]?>? value32 = null,
            global::System.Action<byte[]?>? value33 = null,
            global::System.Action<byte[]?>? value34 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
            else if (IsValue15)
            {
                value15?.Invoke(Value15!);
            }
            else if (IsValue16)
            {
                value16?.Invoke(Value16!);
            }
            else if (IsValue17)
            {
                value17?.Invoke(Value17!);
            }
            else if (IsValue18)
            {
                value18?.Invoke(Value18!);
            }
            else if (IsValue19)
            {
                value19?.Invoke(Value19!);
            }
            else if (IsValue20)
            {
                value20?.Invoke(Value20!);
            }
            else if (IsValue21)
            {
                value21?.Invoke(Value21!);
            }
            else if (IsValue22)
            {
                value22?.Invoke(Value22!);
            }
            else if (IsValue23)
            {
                value23?.Invoke(Value23!);
            }
            else if (IsValue24)
            {
                value24?.Invoke(Value24!);
            }
            else if (IsValue25)
            {
                value25?.Invoke(Value25!);
            }
            else if (IsValue26)
            {
                value26?.Invoke(Value26!);
            }
            else if (IsValue27)
            {
                value27?.Invoke(Value27!);
            }
            else if (IsValue28)
            {
                value28?.Invoke(Value28!);
            }
            else if (IsValue29)
            {
                value29?.Invoke(Value29!);
            }
            else if (IsValue30)
            {
                value30?.Invoke(Value30!);
            }
            else if (IsValue31)
            {
                value31?.Invoke(Value31!);
            }
            else if (IsValue32)
            {
                value32?.Invoke(Value32!);
            }
            else if (IsValue33)
            {
                value33?.Invoke(Value33!);
            }
            else if (IsValue34)
            {
                value34?.Invoke(Value34!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(byte[]),
                Value2,
                typeof(byte[]),
                Value3,
                typeof(byte[]),
                Value4,
                typeof(byte[]),
                Value5,
                typeof(byte[]),
                Value6,
                typeof(byte[]),
                Value7,
                typeof(byte[]),
                Value8,
                typeof(byte[]),
                Value9,
                typeof(byte[]),
                Value10,
                typeof(byte[]),
                Value11,
                typeof(byte[]),
                Value12,
                typeof(byte[]),
                Value13,
                typeof(byte[]),
                Value14,
                typeof(byte[]),
                Value15,
                typeof(byte[]),
                Value16,
                typeof(byte[]),
                Value17,
                typeof(byte[]),
                Value18,
                typeof(byte[]),
                Value19,
                typeof(byte[]),
                Value20,
                typeof(byte[]),
                Value21,
                typeof(byte[]),
                Value22,
                typeof(byte[]),
                Value23,
                typeof(byte[]),
                Value24,
                typeof(byte[]),
                Value25,
                typeof(byte[]),
                Value26,
                typeof(byte[]),
                Value27,
                typeof(byte[]),
                Value28,
                typeof(byte[]),
                Value29,
                typeof(byte[]),
                Value30,
                typeof(byte[]),
                Value31,
                typeof(byte[]),
                Value32,
                typeof(byte[]),
                Value33,
                typeof(byte[]),
                Value34,
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
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value17, other.Value17) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value18, other.Value18) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value19, other.Value19) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value20, other.Value20) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value21, other.Value21) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value22, other.Value22) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value23, other.Value23) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value24, other.Value24) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value25, other.Value25) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value26, other.Value26) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value27, other.Value27) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value28, other.Value28) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value29, other.Value29) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value30, other.Value30) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value31, other.Value31) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value32, other.Value32) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value33, other.Value33) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value34, other.Value34) 
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
