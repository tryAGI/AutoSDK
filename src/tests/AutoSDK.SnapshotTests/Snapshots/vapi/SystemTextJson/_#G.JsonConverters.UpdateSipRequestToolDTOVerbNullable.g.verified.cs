//HintName: G.JsonConverters.UpdateSipRequestToolDTOVerbNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateSipRequestToolDTOVerbNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdateSipRequestToolDTOVerb?>
    {
        /// <inheritdoc />
        public override global::G.UpdateSipRequestToolDTOVerb? Read(
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
                        return global::G.UpdateSipRequestToolDTOVerbExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UpdateSipRequestToolDTOVerb)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UpdateSipRequestToolDTOVerb?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdateSipRequestToolDTOVerb? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.UpdateSipRequestToolDTOVerbExtensions.ToValueString(value.Value));
            }
        }
    }
}
