//HintName: G.Models.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput>
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
        public global::System.Collections.Generic.IList<string>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? Value2 { get; }
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
        public global::System.Collections.Generic.IList<double>? Value3 { get; init; }
#else
        public global::System.Collections.Generic.IList<double>? Value3 { get; }
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
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Value4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Value4 { get; }
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
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput(string value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput(
            string? value1,
            global::System.Collections.Generic.IList<string>? value2,
            global::System.Collections.Generic.IList<double>? value3,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? value4,
            global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = embeddingsPostRequestBodyContentApplicationJsonSchemaInput4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 as object ??
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
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? value2 = null,
            global::System.Func<global::System.Collections.Generic.IList<double>?, TResult>? value3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?, TResult>? value4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 && embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInput4(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? value2 = null,
            global::System.Action<global::System.Collections.Generic.IList<double>?>? value3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?>? value4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInput4?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4!);
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
                typeof(global::System.Collections.Generic.IList<string>),
                Value3,
                typeof(global::System.Collections.Generic.IList<double>),
                Value4,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4,
                typeof(global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>),
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<double>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput o && Equals(o);
        }
    }
}
