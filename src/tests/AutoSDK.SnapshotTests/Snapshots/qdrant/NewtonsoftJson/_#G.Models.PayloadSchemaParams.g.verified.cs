//HintName: G.Models.PayloadSchemaParams.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Payload type with parameters
    /// </summary>
    public readonly partial struct PayloadSchemaParams : global::System.IEquatable<PayloadSchemaParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeywordIndexParams? KeywordIndex { get; init; }
#else
        public global::G.KeywordIndexParams? KeywordIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeywordIndex))]
#endif
        public bool IsKeywordIndex => KeywordIndex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IntegerIndexParams? IntegerIndex { get; init; }
#else
        public global::G.IntegerIndexParams? IntegerIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IntegerIndex))]
#endif
        public bool IsIntegerIndex => IntegerIndex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FloatIndexParams? FloatIndex { get; init; }
#else
        public global::G.FloatIndexParams? FloatIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FloatIndex))]
#endif
        public bool IsFloatIndex => FloatIndex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GeoIndexParams? GeoIndex { get; init; }
#else
        public global::G.GeoIndexParams? GeoIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeoIndex))]
#endif
        public bool IsGeoIndex => GeoIndex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextIndexParams? TextIndex { get; init; }
#else
        public global::G.TextIndexParams? TextIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextIndex))]
#endif
        public bool IsTextIndex => TextIndex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BoolIndexParams? BoolIndex { get; init; }
#else
        public global::G.BoolIndexParams? BoolIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BoolIndex))]
#endif
        public bool IsBoolIndex => BoolIndex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DatetimeIndexParams? DatetimeIndex { get; init; }
#else
        public global::G.DatetimeIndexParams? DatetimeIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatetimeIndex))]
#endif
        public bool IsDatetimeIndex => DatetimeIndex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UuidIndexParams? UuidIndex { get; init; }
#else
        public global::G.UuidIndexParams? UuidIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UuidIndex))]
#endif
        public bool IsUuidIndex => UuidIndex != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::G.KeywordIndexParams value) => new PayloadSchemaParams((global::G.KeywordIndexParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeywordIndexParams?(PayloadSchemaParams @this) => @this.KeywordIndex;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(global::G.KeywordIndexParams? value)
        {
            KeywordIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::G.IntegerIndexParams value) => new PayloadSchemaParams((global::G.IntegerIndexParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IntegerIndexParams?(PayloadSchemaParams @this) => @this.IntegerIndex;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(global::G.IntegerIndexParams? value)
        {
            IntegerIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::G.FloatIndexParams value) => new PayloadSchemaParams((global::G.FloatIndexParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FloatIndexParams?(PayloadSchemaParams @this) => @this.FloatIndex;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(global::G.FloatIndexParams? value)
        {
            FloatIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::G.GeoIndexParams value) => new PayloadSchemaParams((global::G.GeoIndexParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GeoIndexParams?(PayloadSchemaParams @this) => @this.GeoIndex;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(global::G.GeoIndexParams? value)
        {
            GeoIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::G.TextIndexParams value) => new PayloadSchemaParams((global::G.TextIndexParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextIndexParams?(PayloadSchemaParams @this) => @this.TextIndex;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(global::G.TextIndexParams? value)
        {
            TextIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::G.BoolIndexParams value) => new PayloadSchemaParams((global::G.BoolIndexParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BoolIndexParams?(PayloadSchemaParams @this) => @this.BoolIndex;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(global::G.BoolIndexParams? value)
        {
            BoolIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::G.DatetimeIndexParams value) => new PayloadSchemaParams((global::G.DatetimeIndexParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DatetimeIndexParams?(PayloadSchemaParams @this) => @this.DatetimeIndex;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(global::G.DatetimeIndexParams? value)
        {
            DatetimeIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::G.UuidIndexParams value) => new PayloadSchemaParams((global::G.UuidIndexParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UuidIndexParams?(PayloadSchemaParams @this) => @this.UuidIndex;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(global::G.UuidIndexParams? value)
        {
            UuidIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PayloadSchemaParams(
            global::G.KeywordIndexParams? keywordIndex,
            global::G.IntegerIndexParams? integerIndex,
            global::G.FloatIndexParams? floatIndex,
            global::G.GeoIndexParams? geoIndex,
            global::G.TextIndexParams? textIndex,
            global::G.BoolIndexParams? boolIndex,
            global::G.DatetimeIndexParams? datetimeIndex,
            global::G.UuidIndexParams? uuidIndex
            )
        {
            KeywordIndex = keywordIndex;
            IntegerIndex = integerIndex;
            FloatIndex = floatIndex;
            GeoIndex = geoIndex;
            TextIndex = textIndex;
            BoolIndex = boolIndex;
            DatetimeIndex = datetimeIndex;
            UuidIndex = uuidIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UuidIndex as object ??
            DatetimeIndex as object ??
            BoolIndex as object ??
            TextIndex as object ??
            GeoIndex as object ??
            FloatIndex as object ??
            IntegerIndex as object ??
            KeywordIndex as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            KeywordIndex?.ToString() ??
            IntegerIndex?.ToString() ??
            FloatIndex?.ToString() ??
            GeoIndex?.ToString() ??
            TextIndex?.ToString() ??
            BoolIndex?.ToString() ??
            DatetimeIndex?.ToString() ??
            UuidIndex?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsKeywordIndex || IsIntegerIndex || IsFloatIndex || IsGeoIndex || IsTextIndex || IsBoolIndex || IsDatetimeIndex || IsUuidIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.KeywordIndexParams?, TResult>? keywordIndex = null,
            global::System.Func<global::G.IntegerIndexParams?, TResult>? integerIndex = null,
            global::System.Func<global::G.FloatIndexParams?, TResult>? floatIndex = null,
            global::System.Func<global::G.GeoIndexParams?, TResult>? geoIndex = null,
            global::System.Func<global::G.TextIndexParams?, TResult>? textIndex = null,
            global::System.Func<global::G.BoolIndexParams?, TResult>? boolIndex = null,
            global::System.Func<global::G.DatetimeIndexParams?, TResult>? datetimeIndex = null,
            global::System.Func<global::G.UuidIndexParams?, TResult>? uuidIndex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeywordIndex && keywordIndex != null)
            {
                return keywordIndex(KeywordIndex!);
            }
            else if (IsIntegerIndex && integerIndex != null)
            {
                return integerIndex(IntegerIndex!);
            }
            else if (IsFloatIndex && floatIndex != null)
            {
                return floatIndex(FloatIndex!);
            }
            else if (IsGeoIndex && geoIndex != null)
            {
                return geoIndex(GeoIndex!);
            }
            else if (IsTextIndex && textIndex != null)
            {
                return textIndex(TextIndex!);
            }
            else if (IsBoolIndex && boolIndex != null)
            {
                return boolIndex(BoolIndex!);
            }
            else if (IsDatetimeIndex && datetimeIndex != null)
            {
                return datetimeIndex(DatetimeIndex!);
            }
            else if (IsUuidIndex && uuidIndex != null)
            {
                return uuidIndex(UuidIndex!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.KeywordIndexParams?>? keywordIndex = null,
            global::System.Action<global::G.IntegerIndexParams?>? integerIndex = null,
            global::System.Action<global::G.FloatIndexParams?>? floatIndex = null,
            global::System.Action<global::G.GeoIndexParams?>? geoIndex = null,
            global::System.Action<global::G.TextIndexParams?>? textIndex = null,
            global::System.Action<global::G.BoolIndexParams?>? boolIndex = null,
            global::System.Action<global::G.DatetimeIndexParams?>? datetimeIndex = null,
            global::System.Action<global::G.UuidIndexParams?>? uuidIndex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeywordIndex)
            {
                keywordIndex?.Invoke(KeywordIndex!);
            }
            else if (IsIntegerIndex)
            {
                integerIndex?.Invoke(IntegerIndex!);
            }
            else if (IsFloatIndex)
            {
                floatIndex?.Invoke(FloatIndex!);
            }
            else if (IsGeoIndex)
            {
                geoIndex?.Invoke(GeoIndex!);
            }
            else if (IsTextIndex)
            {
                textIndex?.Invoke(TextIndex!);
            }
            else if (IsBoolIndex)
            {
                boolIndex?.Invoke(BoolIndex!);
            }
            else if (IsDatetimeIndex)
            {
                datetimeIndex?.Invoke(DatetimeIndex!);
            }
            else if (IsUuidIndex)
            {
                uuidIndex?.Invoke(UuidIndex!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                KeywordIndex,
                typeof(global::G.KeywordIndexParams),
                IntegerIndex,
                typeof(global::G.IntegerIndexParams),
                FloatIndex,
                typeof(global::G.FloatIndexParams),
                GeoIndex,
                typeof(global::G.GeoIndexParams),
                TextIndex,
                typeof(global::G.TextIndexParams),
                BoolIndex,
                typeof(global::G.BoolIndexParams),
                DatetimeIndex,
                typeof(global::G.DatetimeIndexParams),
                UuidIndex,
                typeof(global::G.UuidIndexParams),
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
        public bool Equals(PayloadSchemaParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.KeywordIndexParams?>.Default.Equals(KeywordIndex, other.KeywordIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.IntegerIndexParams?>.Default.Equals(IntegerIndex, other.IntegerIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FloatIndexParams?>.Default.Equals(FloatIndex, other.FloatIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GeoIndexParams?>.Default.Equals(GeoIndex, other.GeoIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextIndexParams?>.Default.Equals(TextIndex, other.TextIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BoolIndexParams?>.Default.Equals(BoolIndex, other.BoolIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DatetimeIndexParams?>.Default.Equals(DatetimeIndex, other.DatetimeIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UuidIndexParams?>.Default.Equals(UuidIndex, other.UuidIndex) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PayloadSchemaParams obj1, PayloadSchemaParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PayloadSchemaParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PayloadSchemaParams obj1, PayloadSchemaParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PayloadSchemaParams o && Equals(o);
        }
    }
}
