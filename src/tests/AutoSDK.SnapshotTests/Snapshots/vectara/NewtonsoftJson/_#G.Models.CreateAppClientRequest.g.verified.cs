//HintName: G.Models.CreateAppClientRequest.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateAppClientRequest : global::System.IEquatable<CreateAppClientRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAppClientRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Create an App Client which allows you to call Vectara APIs using OAuth 2.0 client credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateClientCredentialsRequest? ClientCredentials { get; init; }
#else
        public global::G.CreateClientCredentialsRequest? ClientCredentials { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientCredentials))]
#endif
        public bool IsClientCredentials => ClientCredentials != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAppClientRequest(global::G.CreateClientCredentialsRequest value) => new CreateAppClientRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateClientCredentialsRequest?(CreateAppClientRequest @this) => @this.ClientCredentials;

        /// <summary>
        /// 
        /// </summary>
        public CreateAppClientRequest(global::G.CreateClientCredentialsRequest? value)
        {
            ClientCredentials = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateAppClientRequest(
            global::G.CreateAppClientRequestDiscriminatorType? type,
            global::G.CreateClientCredentialsRequest? clientCredentials
            )
        {
            Type = type;

            ClientCredentials = clientCredentials;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClientCredentials as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClientCredentials;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateClientCredentialsRequest?, TResult>? clientCredentials = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientCredentials && clientCredentials != null)
            {
                return clientCredentials(ClientCredentials!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateClientCredentialsRequest?>? clientCredentials = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientCredentials)
            {
                clientCredentials?.Invoke(ClientCredentials!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ClientCredentials,
                typeof(global::G.CreateClientCredentialsRequest),
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
        public bool Equals(CreateAppClientRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateClientCredentialsRequest?>.Default.Equals(ClientCredentials, other.ClientCredentials) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateAppClientRequest obj1, CreateAppClientRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAppClientRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateAppClientRequest obj1, CreateAppClientRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAppClientRequest o && Equals(o);
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
        public static global::G.CreateAppClientRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateAppClientRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CreateAppClientRequest?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CreateAppClientRequest?>(serializer.Deserialize<global::G.CreateAppClientRequest>(jsonReader));
        }

    }
}
