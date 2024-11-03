//HintName: G.Models.EmbeddingInput.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingInput : global::System.IEquatable<EmbeddingInput>
    {
        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextEmbeddingInput? Text { get; init; }
#else
        public global::G.TextEmbeddingInput? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::G.TextEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextEmbeddingInput?(EmbeddingInput @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.TextEmbeddingInput? value)
        {
            Text = value;
        }

        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageEmbeddingInput? Image { get; init; }
#else
        public global::G.ImageEmbeddingInput? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::G.ImageEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageEmbeddingInput?(EmbeddingInput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.ImageEmbeddingInput? value)
        {
            Image = value;
        }

        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MixedEmbeddingInput? Mixed { get; init; }
#else
        public global::G.MixedEmbeddingInput? Mixed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mixed))]
#endif
        public bool IsMixed => Mixed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::G.MixedEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MixedEmbeddingInput?(EmbeddingInput @this) => @this.Mixed;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.MixedEmbeddingInput? value)
        {
            Mixed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(
            global::G.TextEmbeddingInput? text,
            global::G.ImageEmbeddingInput? image,
            global::G.MixedEmbeddingInput? mixed
            )
        {
            Text = text;
            Image = image;
            Mixed = mixed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Mixed as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText || IsImage || IsMixed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextEmbeddingInput?, TResult>? text = null,
            global::System.Func<global::G.ImageEmbeddingInput?, TResult>? image = null,
            global::System.Func<global::G.MixedEmbeddingInput?, TResult>? mixed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsMixed && mixed != null)
            {
                return mixed(Mixed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextEmbeddingInput?>? text = null,
            global::System.Action<global::G.ImageEmbeddingInput?>? image = null,
            global::System.Action<global::G.MixedEmbeddingInput?>? mixed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsMixed)
            {
                mixed?.Invoke(Mixed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.TextEmbeddingInput),
                Image,
                typeof(global::G.ImageEmbeddingInput),
                Mixed,
                typeof(global::G.MixedEmbeddingInput),
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
        public bool Equals(EmbeddingInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextEmbeddingInput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageEmbeddingInput?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MixedEmbeddingInput?>.Default.Equals(Mixed, other.Mixed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingInput obj1, EmbeddingInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingInput obj1, EmbeddingInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingInput o && Equals(o);
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
        public static global::G.EmbeddingInput? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.EmbeddingInput),
                jsonSerializerContext) as global::G.EmbeddingInput?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.EmbeddingInput? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmbeddingInput>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.EmbeddingInput?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.EmbeddingInput),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.EmbeddingInput?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.EmbeddingInput?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.EmbeddingInput?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
