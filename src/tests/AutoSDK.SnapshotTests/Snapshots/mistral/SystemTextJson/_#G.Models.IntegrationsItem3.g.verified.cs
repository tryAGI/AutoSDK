//HintName: G.Models.IntegrationsItem3.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationsItem3 : global::System.IEquatable<IntegrationsItem3>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WandbIntegrationOut? WandbIntegrationOut { get; init; }
#else
        public global::G.WandbIntegrationOut? WandbIntegrationOut { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WandbIntegrationOut))]
#endif
        public bool IsWandbIntegrationOut => WandbIntegrationOut != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationsItem3(global::G.WandbIntegrationOut value) => new IntegrationsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WandbIntegrationOut?(IntegrationsItem3 @this) => @this.WandbIntegrationOut;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem3(global::G.WandbIntegrationOut? value)
        {
            WandbIntegrationOut = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WandbIntegrationOut as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWandbIntegrationOut;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WandbIntegrationOut?, TResult>? wandbIntegrationOut = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandbIntegrationOut && wandbIntegrationOut != null)
            {
                return wandbIntegrationOut(WandbIntegrationOut!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WandbIntegrationOut?>? wandbIntegrationOut = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandbIntegrationOut)
            {
                wandbIntegrationOut?.Invoke(WandbIntegrationOut!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WandbIntegrationOut,
                typeof(global::G.WandbIntegrationOut),
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
        public bool Equals(IntegrationsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WandbIntegrationOut?>.Default.Equals(WandbIntegrationOut, other.WandbIntegrationOut) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationsItem3 obj1, IntegrationsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationsItem3 obj1, IntegrationsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationsItem3 o && Equals(o);
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
        public static global::G.IntegrationsItem3? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.IntegrationsItem3),
                jsonSerializerContext) as global::G.IntegrationsItem3?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.IntegrationsItem3? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.IntegrationsItem3>(
                json,
                jsonSerializerOptions);
        }

    }
}
