//HintName: JsonConverters.BetaMessageBatchResult.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BetaMessageBatchResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaMessageBatchResult>
    {
        /// <inheritdoc />
        public override global::G.BetaMessageBatchResult Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaMessageBatchResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaMessageBatchResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaMessageBatchResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaSucceededResult? succeeded = default;
            if (discriminator?.Type == global::G.BetaMessageBatchResultDiscriminatorType.Succeeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaSucceededResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaSucceededResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaSucceededResult)}");
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaErroredResult? errored = default;
            if (discriminator?.Type == global::G.BetaMessageBatchResultDiscriminatorType.Errored)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaErroredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaErroredResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaErroredResult)}");
                errored = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaCanceledResult? canceled = default;
            if (discriminator?.Type == global::G.BetaMessageBatchResultDiscriminatorType.Canceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaCanceledResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaCanceledResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaCanceledResult)}");
                canceled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaExpiredResult? expired = default;
            if (discriminator?.Type == global::G.BetaMessageBatchResultDiscriminatorType.Expired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaExpiredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaExpiredResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaExpiredResult)}");
                expired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.BetaMessageBatchResult(
                discriminator?.Type,
                succeeded,
                errored,
                canceled,
                expired
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BetaMessageBatchResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaSucceededResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaSucceededResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaSucceededResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeInfo);
            }
            else if (value.IsErrored)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaErroredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaErroredResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaErroredResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Errored, typeInfo);
            }
            else if (value.IsCanceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaCanceledResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaCanceledResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaCanceledResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled, typeInfo);
            }
            else if (value.IsExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaExpiredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaExpiredResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaExpiredResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expired, typeInfo);
            }
        }
    }
}