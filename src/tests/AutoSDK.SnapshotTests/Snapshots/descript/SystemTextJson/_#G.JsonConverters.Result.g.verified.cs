//HintName: G.JsonConverters.Result.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Result>
    {
        /// <inheritdoc />
        public override global::G.Result Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImportJobStatusResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImportJobStatusResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImportJobStatusResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ImportSuccessResult? success = default;
            if (discriminator?.Status == global::G.ImportJobStatusResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImportSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImportSuccessResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImportSuccessResult)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImportErrorResult? error = default;
            if (discriminator?.Status == global::G.ImportJobStatusResultDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImportErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImportErrorResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImportErrorResult)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Result(
                discriminator?.Status,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Result value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImportSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImportSuccessResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImportSuccessResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImportErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImportErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImportErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}