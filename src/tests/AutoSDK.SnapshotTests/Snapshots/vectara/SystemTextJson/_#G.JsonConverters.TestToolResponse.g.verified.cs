//HintName: G.JsonConverters.TestToolResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TestToolResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TestToolResponse>
    {
        /// <inheritdoc />
        public override global::G.TestToolResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TestToolResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TestToolResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TestToolResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TestToolSuccessResponse? success = default;
            if (discriminator?.Type == global::G.TestToolResponseDiscriminatorType.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TestToolSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TestToolSuccessResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TestToolSuccessResponse)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TestToolErrorResponse? error = default;
            if (discriminator?.Type == global::G.TestToolResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TestToolErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TestToolErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TestToolErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.TestToolResponse(
                discriminator?.Type,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TestToolResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TestToolSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TestToolSuccessResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TestToolSuccessResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TestToolErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TestToolErrorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TestToolErrorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}