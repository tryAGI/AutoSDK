//HintName: G.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetVideoTranslationsApiResponseTranslationDiscriminatorStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus?>
    {
        /// <inheritdoc />
        public override global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? Read(
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
                        return global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
