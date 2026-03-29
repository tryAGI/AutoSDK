//HintName: G.JsonConverters.EditImageGetVirtualModelSceneVariant1PresetNameNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGetVirtualModelSceneVariant1PresetNameNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EditImageGetVirtualModelSceneVariant1PresetName?>
    {
        /// <inheritdoc />
        public override global::G.EditImageGetVirtualModelSceneVariant1PresetName? Read(
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
                        return global::G.EditImageGetVirtualModelSceneVariant1PresetNameExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.EditImageGetVirtualModelSceneVariant1PresetName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.EditImageGetVirtualModelSceneVariant1PresetName?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EditImageGetVirtualModelSceneVariant1PresetName? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.EditImageGetVirtualModelSceneVariant1PresetNameExtensions.ToValueString(value.Value));
            }
        }
    }
}
