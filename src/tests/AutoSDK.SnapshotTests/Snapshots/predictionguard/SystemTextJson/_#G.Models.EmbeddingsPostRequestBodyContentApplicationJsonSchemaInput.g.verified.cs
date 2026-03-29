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
        /// An array of strings or objects containing the text and/or images to be embedded.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1 != null;
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
            global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput1
            )
        {
            Value1 = value1;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1 = embeddingsPostRequestBodyContentApplicationJsonSchemaInput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1 || !IsValue1 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput1 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1 && embeddingsPostRequestBodyContentApplicationJsonSchemaInput1 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInput1(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput1 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInput1?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1!);
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
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1,
                typeof(global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>),
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput1) 
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
