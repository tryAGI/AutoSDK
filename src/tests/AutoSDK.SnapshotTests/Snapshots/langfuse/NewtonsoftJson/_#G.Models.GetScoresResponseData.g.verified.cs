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
        public global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>? GetScoresResponseDataVariant1 { get; init; }
#else
        public global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>? GetScoresResponseDataVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant1))]
#endif
        public bool IsGetScoresResponseDataVariant1 => GetScoresResponseDataVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>? GetScoresResponseDataVariant2 { get; init; }
#else
        public global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>? GetScoresResponseDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant2))]
#endif
        public bool IsGetScoresResponseDataVariant2 => GetScoresResponseDataVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>? GetScoresResponseDataVariant3 { get; init; }
#else
        public global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>? GetScoresResponseDataVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant3))]
#endif
        public bool IsGetScoresResponseDataVariant3 => GetScoresResponseDataVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>? GetScoresResponseDataVariant4 { get; init; }
#else
        public global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>? GetScoresResponseDataVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant4))]
#endif
        public bool IsGetScoresResponseDataVariant4 => GetScoresResponseDataVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric> value) => new GetScoresResponseData((global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant1;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>? value)
        {
            GetScoresResponseDataVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical> value) => new GetScoresResponseData((global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>? value)
        {
            GetScoresResponseDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean> value) => new GetScoresResponseData((global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant3;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>? value)
        {
            GetScoresResponseDataVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection> value) => new GetScoresResponseData((global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant4;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>? value)
        {
            GetScoresResponseDataVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(
            global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>? getScoresResponseDataVariant1,
            global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>? getScoresResponseDataVariant2,
            global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>? getScoresResponseDataVariant3,
            global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>? getScoresResponseDataVariant4
            )
        {
            GetScoresResponseDataVariant1 = getScoresResponseDataVariant1;
            GetScoresResponseDataVariant2 = getScoresResponseDataVariant2;
            GetScoresResponseDataVariant3 = getScoresResponseDataVariant3;
            GetScoresResponseDataVariant4 = getScoresResponseDataVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetScoresResponseDataVariant4 as object ??
            GetScoresResponseDataVariant3 as object ??
            GetScoresResponseDataVariant2 as object ??
            GetScoresResponseDataVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GetScoresResponseDataVariant1?.ToString() ??
            GetScoresResponseDataVariant2?.ToString() ??
            GetScoresResponseDataVariant3?.ToString() ??
            GetScoresResponseDataVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGetScoresResponseDataVariant1 && !IsGetScoresResponseDataVariant2 && !IsGetScoresResponseDataVariant3 && !IsGetScoresResponseDataVariant4 || !IsGetScoresResponseDataVariant1 && IsGetScoresResponseDataVariant2 && !IsGetScoresResponseDataVariant3 && !IsGetScoresResponseDataVariant4 || !IsGetScoresResponseDataVariant1 && !IsGetScoresResponseDataVariant2 && IsGetScoresResponseDataVariant3 && !IsGetScoresResponseDataVariant4 || !IsGetScoresResponseDataVariant1 && !IsGetScoresResponseDataVariant2 && !IsGetScoresResponseDataVariant3 && IsGetScoresResponseDataVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?, TResult>? getScoresResponseDataVariant1 = null,
            global::System.Func<global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?, TResult>? getScoresResponseDataVariant2 = null,
            global::System.Func<global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?, TResult>? getScoresResponseDataVariant3 = null,
            global::System.Func<global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?, TResult>? getScoresResponseDataVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetScoresResponseDataVariant1 && getScoresResponseDataVariant1 != null)
            {
                return getScoresResponseDataVariant1(GetScoresResponseDataVariant1!);
            }
            else if (IsGetScoresResponseDataVariant2 && getScoresResponseDataVariant2 != null)
            {
                return getScoresResponseDataVariant2(GetScoresResponseDataVariant2!);
            }
            else if (IsGetScoresResponseDataVariant3 && getScoresResponseDataVariant3 != null)
            {
                return getScoresResponseDataVariant3(GetScoresResponseDataVariant3!);
            }
            else if (IsGetScoresResponseDataVariant4 && getScoresResponseDataVariant4 != null)
            {
                return getScoresResponseDataVariant4(GetScoresResponseDataVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?>? getScoresResponseDataVariant1 = null,
            global::System.Action<global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?>? getScoresResponseDataVariant2 = null,
            global::System.Action<global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?>? getScoresResponseDataVariant3 = null,
            global::System.Action<global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?>? getScoresResponseDataVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetScoresResponseDataVariant1)
            {
                getScoresResponseDataVariant1?.Invoke(GetScoresResponseDataVariant1!);
            }
            else if (IsGetScoresResponseDataVariant2)
            {
                getScoresResponseDataVariant2?.Invoke(GetScoresResponseDataVariant2!);
            }
            else if (IsGetScoresResponseDataVariant3)
            {
                getScoresResponseDataVariant3?.Invoke(GetScoresResponseDataVariant3!);
            }
            else if (IsGetScoresResponseDataVariant4)
            {
                getScoresResponseDataVariant4?.Invoke(GetScoresResponseDataVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GetScoresResponseDataVariant1,
                typeof(global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>),
                GetScoresResponseDataVariant2,
                typeof(global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>),
                GetScoresResponseDataVariant3,
                typeof(global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>),
                GetScoresResponseDataVariant4,
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
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>?>.Default.Equals(GetScoresResponseDataVariant1, other.GetScoresResponseDataVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>?>.Default.Equals(GetScoresResponseDataVariant2, other.GetScoresResponseDataVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>?>.Default.Equals(GetScoresResponseDataVariant3, other.GetScoresResponseDataVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>?>.Default.Equals(GetScoresResponseDataVariant4, other.GetScoresResponseDataVariant4) 
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
