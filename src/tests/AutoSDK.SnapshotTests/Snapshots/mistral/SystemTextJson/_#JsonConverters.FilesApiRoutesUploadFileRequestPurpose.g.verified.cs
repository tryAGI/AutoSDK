//HintName: JsonConverters.FilesApiRoutesUploadFileRequestPurpose.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilesApiRoutesUploadFileRequestPurposeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FilesApiRoutesUploadFileRequestPurpose>
    {
        /// <inheritdoc />
        public override global::G.FilesApiRoutesUploadFileRequestPurpose Read(
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
                        return global::G.FilesApiRoutesUploadFileRequestPurposeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FilesApiRoutesUploadFileRequestPurpose)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FilesApiRoutesUploadFileRequestPurpose value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.FilesApiRoutesUploadFileRequestPurposeExtensions.ToValueString(value));
        }
    }
}
