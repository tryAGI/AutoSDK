//HintName: G.JsonConverters.PostFilesUploadRequestResponseMetadataStorageBackendNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostFilesUploadRequestResponseMetadataStorageBackendNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostFilesUploadRequestResponseMetadataStorageBackend?>
    {
        /// <inheritdoc />
        public override global::G.PostFilesUploadRequestResponseMetadataStorageBackend? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.PostFilesUploadRequestResponseMetadataStorageBackendExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PostFilesUploadRequestResponseMetadataStorageBackend)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PostFilesUploadRequestResponseMetadataStorageBackend?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostFilesUploadRequestResponseMetadataStorageBackend? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PostFilesUploadRequestResponseMetadataStorageBackendExtensions.ToValueString(value.Value));
            }
        }
    }
}
