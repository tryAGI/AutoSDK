//HintName: G.JsonConverters.PostToolRouterSessionBySessionIdExecuteMetaRequestSlugNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolRouterSessionBySessionIdExecuteMetaRequestSlugNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug?>
    {
        /// <inheritdoc />
        public override global::G.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug? Read(
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
                        return global::G.PostToolRouterSessionBySessionIdExecuteMetaRequestSlugExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PostToolRouterSessionBySessionIdExecuteMetaRequestSlugExtensions.ToValueString(value.Value));
            }
        }
    }
}
