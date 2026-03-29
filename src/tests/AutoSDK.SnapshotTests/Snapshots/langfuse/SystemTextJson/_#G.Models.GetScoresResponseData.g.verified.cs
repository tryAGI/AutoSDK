//HintName: G.Models.GetScoresResponseData.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetScoresResponseData : global::System.IEquatable<GetScoresResponseData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>? Value1 { get; init; }
#else
        public global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>? Value2 { get; init; }
#else
        public global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>? Value3 { get; init; }
#else
        public global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>? Value4 { get; init; }
#else
        public global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric> value) => new GetScoresResponseData((global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?(GetScoresResponseData @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical> value) => new GetScoresResponseData((global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?(GetScoresResponseData @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean> value) => new GetScoresResponseData((global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?(GetScoresResponseData @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection> value) => new GetScoresResponseData((global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?(GetScoresResponseData @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(
            global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>? value1,
            global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>? value2,
            global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>? value3,
            global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Value4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?, TResult>? value1 = null,
            global::System.Func<global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?, TResult>? value2 = null,
            global::System.Func<global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?, TResult>? value3 = null,
            global::System.Func<global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?, TResult>? value4 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?>? value1 = null,
            global::System.Action<global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?>? value2 = null,
            global::System.Action<global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?>? value3 = null,
            global::System.Action<global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?>? value4 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>),
                Value2,
                typeof(global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>),
                Value3,
                typeof(global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>),
                Value4,
                typeof(global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>),
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
        public bool Equals(GetScoresResponseData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?>.Default.Equals(Value4, other.Value4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetScoresResponseData obj1, GetScoresResponseData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetScoresResponseData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetScoresResponseData obj1, GetScoresResponseData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetScoresResponseData o && Equals(o);
        }
    }
}
