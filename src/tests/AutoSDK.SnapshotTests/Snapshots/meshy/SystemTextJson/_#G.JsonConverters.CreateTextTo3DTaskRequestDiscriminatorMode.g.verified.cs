//HintName: G.JsonConverters.CreateTextTo3DTaskRequestDiscriminatorMode.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextTo3DTaskRequestDiscriminatorModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextTo3DTaskRequestDiscriminatorMode>
    {
        /// <inheritdoc />
        public override global::G.CreateTextTo3DTaskRequestDiscriminatorMode Read(
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
                        return global::G.CreateTextTo3DTaskRequestDiscriminatorModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateTextTo3DTaskRequestDiscriminatorMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateTextTo3DTaskRequestDiscriminatorMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextTo3DTaskRequestDiscriminatorMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateTextTo3DTaskRequestDiscriminatorModeExtensions.ToValueString(value));
        }
    }
}
