//HintName: G.Models.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
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
        public int? Value2 { get; init; }
#else
        public int? Value2 { get; }
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
        public global::System.Collections.Generic.IList<int>? Value3 { get; init; }
#else
        public global::System.Collections.Generic.IList<int>? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// Use this option for multimodal input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 { get; init; }
#else
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(string value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(int value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(int? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items((global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(
            string? value1,
            int? value2,
            global::System.Collections.Generic.IList<int>? value3,
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 as object ??
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
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 || !IsValue1 && IsValue2 && !IsValue3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 || !IsValue1 && !IsValue2 && IsValue3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 || !IsValue1 && !IsValue2 && !IsValue3 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<int?, TResult>? value2 = null,
            global::System.Func<global::System.Collections.Generic.IList<int>?, TResult>? value3 = null,
            global::System.Func<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<int?>? value2 = null,
            global::System.Action<global::System.Collections.Generic.IList<int>?>? value3 = null,
            global::System.Action<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3!);
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
                typeof(string),
                Value2,
                typeof(int),
                Value3,
                typeof(global::System.Collections.Generic.IList<int>),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3,
                typeof(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3),
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<int>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items o && Equals(o);
        }
    }
}
