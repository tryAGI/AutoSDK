//HintName: G.JsonConverters.BulkDeleteDocumentsResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BulkDeleteDocumentsResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BulkDeleteDocumentsResponse>
    {
        /// <inheritdoc />
        public override global::G.BulkDeleteDocumentsResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BulkDeleteDocumentsResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BulkDeleteDocumentsResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BulkDeleteDocumentsResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BulkDeleteAsyncResponse? async = default;
            if (discriminator?.ResponseType == global::G.BulkDeleteDocumentsResponseDiscriminatorResponseType.Async)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BulkDeleteAsyncResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BulkDeleteAsyncResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BulkDeleteAsyncResponse)}");
                async = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BulkDeleteSyncSuccessResponse? success = default;
            if (discriminator?.ResponseType == global::G.BulkDeleteDocumentsResponseDiscriminatorResponseType.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BulkDeleteSyncSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BulkDeleteSyncSuccessResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BulkDeleteSyncSuccessResponse)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.BulkDeleteDocumentsResponse(
                discriminator?.ResponseType,
                async,

                success
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BulkDeleteDocumentsResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAsync)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BulkDeleteAsyncResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BulkDeleteAsyncResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BulkDeleteAsyncResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Async!, typeInfo);
            }
            else if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BulkDeleteSyncSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BulkDeleteSyncSuccessResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BulkDeleteSyncSuccessResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
        }
    }
}