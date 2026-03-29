//HintName: G.Models.AttributeSchema.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The schema for an attribute attached to a document.
    /// </summary>
    public readonly partial struct AttributeSchema : global::System.IEquatable<AttributeSchema>
    {
        /// <summary>
        /// The data type of the attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AttributeTypeName { get; init; }
#else
        public string? AttributeTypeName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AttributeTypeName))]
#endif
        public bool IsAttributeTypeName => AttributeTypeName != null;

        /// <summary>
        /// Detailed configuration for an attribute attached to a document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AttributeSchemaConfig? Value2 { get; init; }
#else
        public global::G.AttributeSchemaConfig? Value2 { get; }
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
        public static implicit operator AttributeSchema(string value) => new AttributeSchema((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AttributeSchema @this) => @this.AttributeTypeName;

        /// <summary>
        /// 
        /// </summary>
        public AttributeSchema(string? value)
        {
            AttributeTypeName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AttributeSchema(global::G.AttributeSchemaConfig value) => new AttributeSchema((global::G.AttributeSchemaConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AttributeSchemaConfig?(AttributeSchema @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public AttributeSchema(global::G.AttributeSchemaConfig? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AttributeSchema(
            string? attributeTypeName,
            global::G.AttributeSchemaConfig? value2
            )
        {
            AttributeTypeName = attributeTypeName;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            AttributeTypeName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AttributeTypeName?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAttributeTypeName || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? attributeTypeName = null,
            global::System.Func<global::G.AttributeSchemaConfig?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAttributeTypeName && attributeTypeName != null)
            {
                return attributeTypeName(AttributeTypeName!);
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
            global::System.Action<string?>? attributeTypeName = null,
            global::System.Action<global::G.AttributeSchemaConfig?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAttributeTypeName)
            {
                attributeTypeName?.Invoke(AttributeTypeName!);
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
                AttributeTypeName,
                typeof(string),
                Value2,
                typeof(global::G.AttributeSchemaConfig),
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
        public bool Equals(AttributeSchema other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AttributeTypeName, other.AttributeTypeName) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AttributeSchemaConfig?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AttributeSchema obj1, AttributeSchema obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AttributeSchema>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AttributeSchema obj1, AttributeSchema obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AttributeSchema o && Equals(o);
        }
    }
}
