//HintName: G.JsonConverters.GetResearchResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetResearchResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetResearchResponse>
    {
        /// <inheritdoc />
        public override global::G.GetResearchResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetResearchResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetResearchResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetResearchResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResearchTaskCompleted? completed = default;
            if (discriminator?.Status == global::G.GetResearchResponseDiscriminatorStatus.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchTaskCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchTaskCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchTaskCompleted)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchTaskFailed? failed = default;
            if (discriminator?.Status == global::G.GetResearchResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchTaskFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchTaskFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchTaskFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GetResearchResponse(
                discriminator?.Status,
                completed,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetResearchResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchTaskCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchTaskCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchTaskCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchTaskFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchTaskFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchTaskFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed, typeInfo);
            }
        }
    }
}