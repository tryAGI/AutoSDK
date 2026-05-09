//HintName: G.JsonConverters.GeneratedAsset.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GeneratedAssetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GeneratedAsset>
    {
        /// <inheritdoc />
        public override global::G.GeneratedAsset Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneratedAssetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneratedAssetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GeneratedAssetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ShotstackGeneratedAsset? shotstack = default;
            if (discriminator?.Provider == global::G.GeneratedAssetDiscriminatorProvider.Shotstack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackGeneratedAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShotstackGeneratedAsset)}");
                shotstack = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DIDGeneratedAsset? dId = default;
            if (discriminator?.Provider == global::G.GeneratedAssetDiscriminatorProvider.DId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DIDGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DIDGeneratedAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DIDGeneratedAsset)}");
                dId = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ElevenLabsGeneratedAsset? elevenlabs = default;
            if (discriminator?.Provider == global::G.GeneratedAssetDiscriminatorProvider.Elevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ElevenLabsGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ElevenLabsGeneratedAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ElevenLabsGeneratedAsset)}");
                elevenlabs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HeyGenGeneratedAsset? heygen = default;
            if (discriminator?.Provider == global::G.GeneratedAssetDiscriminatorProvider.Heygen)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeyGenGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeyGenGeneratedAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HeyGenGeneratedAsset)}");
                heygen = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OpenAiGeneratedAsset? openai = default;
            if (discriminator?.Provider == global::G.GeneratedAssetDiscriminatorProvider.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiGeneratedAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OpenAiGeneratedAsset)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StabilityAiGeneratedAsset? stabilityAi = default;
            if (discriminator?.Provider == global::G.GeneratedAssetDiscriminatorProvider.StabilityAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StabilityAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StabilityAiGeneratedAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StabilityAiGeneratedAsset)}");
                stabilityAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GeneratedAsset(
                discriminator?.Provider,
                shotstack,

                dId,

                elevenlabs,

                heygen,

                openai,

                stabilityAi
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GeneratedAsset value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShotstack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shotstack!, typeInfo);
            }
            else if (value.IsDId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DIDGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DIDGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DIDGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DId!, typeInfo);
            }
            else if (value.IsElevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ElevenLabsGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ElevenLabsGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ElevenLabsGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Elevenlabs!, typeInfo);
            }
            else if (value.IsHeygen)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeyGenGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeyGenGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HeyGenGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heygen!, typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai!, typeInfo);
            }
            else if (value.IsStabilityAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StabilityAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StabilityAiGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StabilityAiGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StabilityAi!, typeInfo);
            }
        }
    }
}