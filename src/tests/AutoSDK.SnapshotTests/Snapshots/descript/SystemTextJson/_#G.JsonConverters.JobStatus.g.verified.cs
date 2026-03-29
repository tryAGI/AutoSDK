//HintName: G.JsonConverters.JobStatus.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class JobStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JobStatus>
    {
        /// <inheritdoc />
        public override global::G.JobStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JobStatusDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JobStatusDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JobStatusDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ImportJobStatus? importProjectMedia = default;
            if (discriminator?.JobType == global::G.JobStatusDiscriminatorJobType.ImportProjectMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImportJobStatus), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImportJobStatus> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImportJobStatus)}");
                importProjectMedia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AgentJobStatus? agent = default;
            if (discriminator?.JobType == global::G.JobStatusDiscriminatorJobType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentJobStatus), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentJobStatus> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentJobStatus)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.JobStatus(
                discriminator?.JobType,
                importProjectMedia,

                agent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JobStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImportProjectMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImportJobStatus), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImportJobStatus?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImportJobStatus).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImportProjectMedia, typeInfo);
            }
            else if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentJobStatus), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentJobStatus?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentJobStatus).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent, typeInfo);
            }
        }
    }
}