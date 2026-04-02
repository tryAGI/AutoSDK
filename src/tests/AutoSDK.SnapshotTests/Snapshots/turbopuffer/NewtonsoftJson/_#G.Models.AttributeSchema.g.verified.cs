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
        public global::G.AttributeSchemaConfig? Config { get; init; }
#else
        public global::G.AttributeSchemaConfig? Config { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Config))]
#endif
        public bool IsConfig => Config != null;
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
        public static implicit operator global::G.AttributeSchemaConfig?(AttributeSchema @this) => @this.Config;

        /// <summary>
        /// 
        /// </summary>
        public AttributeSchema(global::G.AttributeSchemaConfig? value)
        {
            Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AttributeSchema(
            string? attributeTypeName,
            global::G.AttributeSchemaConfig? config
            )
        {
            AttributeTypeName = attributeTypeName;
            Config = config;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Config as object ??
            AttributeTypeName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AttributeTypeName?.ToString() ??
            Config?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAttributeTypeName || IsConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? attributeTypeName = null,
            global::System.Func<global::G.AttributeSchemaConfig?, TResult>? config = null,
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
            else if (IsConfig && config != null)
            {
                return config(Config!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? attributeTypeName = null,
            global::System.Action<global::G.AttributeSchemaConfig?>? config = null,
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
            else if (IsConfig)
            {
                config?.Invoke(Config!);
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
                Config,
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
                global::System.Collections.Generic.EqualityComparer<global::G.AttributeSchemaConfig?>.Default.Equals(Config, other.Config) 
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
