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
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageBatchIndividualResponseResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageBatchIndividualResponseResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageBatchIndividualResponseResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SucceededResult? succeeded = default;
            if (discriminator?.Type == global::G.MessageBatchIndividualResponseResultDiscriminatorType.Succeeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SucceededResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SucceededResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SucceededResult)}");
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ErroredResult? errored = default;
            if (discriminator?.Type == global::G.MessageBatchIndividualResponseResultDiscriminatorType.Errored)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErroredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErroredResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ErroredResult)}");
                errored = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CanceledResult? canceled = default;
            if (discriminator?.Type == global::G.MessageBatchIndividualResponseResultDiscriminatorType.Canceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CanceledResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CanceledResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CanceledResult)}");
                canceled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ExpiredResult? expired = default;
            if (discriminator?.Type == global::G.MessageBatchIndividualResponseResultDiscriminatorType.Expired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExpiredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExpiredResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ExpiredResult)}");
                expired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Result2(
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
            global::G.Result2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SucceededResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SucceededResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SucceededResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeInfo);
            }
            else if (value.IsErrored)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErroredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErroredResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ErroredResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Errored, typeInfo);
            }
            else if (value.IsCanceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CanceledResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CanceledResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CanceledResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled, typeInfo);
            }
            else if (value.IsExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExpiredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExpiredResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExpiredResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expired, typeInfo);
            }
        }
    }
}