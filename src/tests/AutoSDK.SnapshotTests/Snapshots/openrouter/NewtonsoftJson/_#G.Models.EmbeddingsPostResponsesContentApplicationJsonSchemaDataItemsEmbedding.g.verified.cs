//HintName: G.Models.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding : global::System.IEquatable<EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<double>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<double>? Value1 { get; }
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
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
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
        public static implicit operator EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding(string value) => new EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding(
            global::System.Collections.Generic.IList<double>? value1,
            string? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<double>?, TResult>? value1 = null,
            global::System.Func<string?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<double>?>? value1 = null,
            global::System.Action<string?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::System.Collections.Generic.IList<double>),
                Value2,
                typeof(string),
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
        public bool Equals(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<double>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding obj1, EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding obj1, EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding o && Equals(o);
        }
    }
}
