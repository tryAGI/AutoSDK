//HintName: G.Models.EntitiesItem.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EntitiesItem : global::System.IEquatable<EntitiesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.TenantShareTokensResponseEntitieDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TenantShareRunToken? TenantShareRunToken { get; init; }
#else
        public global::G.TenantShareRunToken? TenantShareRunToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TenantShareRunToken))]
#endif
        public bool IsTenantShareRunToken => TenantShareRunToken != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EntitiesItem(global::G.TenantShareRunToken value) => new EntitiesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TenantShareRunToken?(EntitiesItem @this) => @this.TenantShareRunToken;

        /// <summary>
        /// 
        /// </summary>
        public EntitiesItem(global::G.TenantShareRunToken? value)
        {
            TenantShareRunToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TenantShareDatasetToken? TenantShareDatasetToken { get; init; }
#else
        public global::G.TenantShareDatasetToken? TenantShareDatasetToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TenantShareDatasetToken))]
#endif
        public bool IsTenantShareDatasetToken => TenantShareDatasetToken != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EntitiesItem(global::G.TenantShareDatasetToken value) => new EntitiesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TenantShareDatasetToken?(EntitiesItem @this) => @this.TenantShareDatasetToken;

        /// <summary>
        /// 
        /// </summary>
        public EntitiesItem(global::G.TenantShareDatasetToken? value)
        {
            TenantShareDatasetToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EntitiesItem(
            global::G.TenantShareTokensResponseEntitieDiscriminatorType? type,
            global::G.TenantShareRunToken? tenantShareRunToken,
            global::G.TenantShareDatasetToken? tenantShareDatasetToken
            )
        {
            Type = type;

            TenantShareRunToken = tenantShareRunToken;
            TenantShareDatasetToken = tenantShareDatasetToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TenantShareDatasetToken as object ??
            TenantShareRunToken as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTenantShareRunToken && !IsTenantShareDatasetToken || !IsTenantShareRunToken && IsTenantShareDatasetToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TenantShareRunToken?, TResult>? tenantShareRunToken = null,
            global::System.Func<global::G.TenantShareDatasetToken?, TResult>? tenantShareDatasetToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTenantShareRunToken && tenantShareRunToken != null)
            {
                return tenantShareRunToken(TenantShareRunToken!);
            }
            else if (IsTenantShareDatasetToken && tenantShareDatasetToken != null)
            {
                return tenantShareDatasetToken(TenantShareDatasetToken!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TenantShareRunToken?>? tenantShareRunToken = null,
            global::System.Action<global::G.TenantShareDatasetToken?>? tenantShareDatasetToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTenantShareRunToken)
            {
                tenantShareRunToken?.Invoke(TenantShareRunToken!);
            }
            else if (IsTenantShareDatasetToken)
            {
                tenantShareDatasetToken?.Invoke(TenantShareDatasetToken!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TenantShareRunToken,
                typeof(global::G.TenantShareRunToken),
                TenantShareDatasetToken,
                typeof(global::G.TenantShareDatasetToken),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EntitiesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TenantShareRunToken?>.Default.Equals(TenantShareRunToken, other.TenantShareRunToken) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TenantShareDatasetToken?>.Default.Equals(TenantShareDatasetToken, other.TenantShareDatasetToken) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EntitiesItem obj1, EntitiesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EntitiesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EntitiesItem obj1, EntitiesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EntitiesItem o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.EntitiesItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.EntitiesItem),
                jsonSerializerContext) as global::G.EntitiesItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.EntitiesItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.EntitiesItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
