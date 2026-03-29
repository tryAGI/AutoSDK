//HintName: G.JsonConverters.Result2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Result2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Result2>
    {
        /// <inheritdoc />
        public override global::G.Result2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentJobStatusResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentJobStatusResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentJobStatusResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AgentSuccessResult? success = default;
            if (discriminator?.Status == global::G.AgentJobStatusResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSuccessResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentSuccessResult)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AgentErrorResult? error = default;
            if (discriminator?.Status == global::G.AgentJobStatusResultDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentErrorResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentErrorResult)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Result2(
                discriminator?.Status,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Result2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSuccessResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentSuccessResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
        }
    }
}