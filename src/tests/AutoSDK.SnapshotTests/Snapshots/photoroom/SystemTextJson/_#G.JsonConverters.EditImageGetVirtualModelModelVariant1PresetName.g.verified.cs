//HintName: G.JsonConverters.EditImageGetVirtualModelModelVariant1PresetName.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGetVirtualModelModelVariant1PresetNameJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EditImageGetVirtualModelModelVariant1PresetName>
    {
        /// <inheritdoc />
        public override global::G.EditImageGetVirtualModelModelVariant1PresetName Read(
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
                        return global::G.EditImageGetVirtualModelModelVariant1PresetNameExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.EditImageGetVirtualModelModelVariant1PresetName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.EditImageGetVirtualModelModelVariant1PresetName);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EditImageGetVirtualModelModelVariant1PresetName value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.EditImageGetVirtualModelModelVariant1PresetNameExtensions.ToValueString(value));
        }
    }
}
