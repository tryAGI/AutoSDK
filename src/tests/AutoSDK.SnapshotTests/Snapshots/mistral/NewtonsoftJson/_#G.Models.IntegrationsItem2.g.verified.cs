//HintName: G.Models.IntegrationsItem2.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationsItem2 : global::System.IEquatable<IntegrationsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WandbIntegration? WandbIntegration { get; init; }
#else
        public global::G.WandbIntegration? WandbIntegration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WandbIntegration))]
#endif
        public bool IsWandbIntegration => WandbIntegration != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationsItem2(global::G.WandbIntegration value) => new IntegrationsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WandbIntegration?(IntegrationsItem2 @this) => @this.WandbIntegration;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem2(global::G.WandbIntegration? value)
        {
            WandbIntegration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WandbIntegration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWandbIntegration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WandbIntegration?, TResult>? wandbIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandbIntegration && wandbIntegration != null)
            {
                return wandbIntegration(WandbIntegration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WandbIntegration?>? wandbIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandbIntegration)
            {
                wandbIntegration?.Invoke(WandbIntegration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WandbIntegration,
                typeof(global::G.WandbIntegration),
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
        public bool Equals(IntegrationsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WandbIntegration?>.Default.Equals(WandbIntegration, other.WandbIntegration) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationsItem2 obj1, IntegrationsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationsItem2 obj1, IntegrationsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationsItem2 o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.IntegrationsItem2? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.IntegrationsItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
