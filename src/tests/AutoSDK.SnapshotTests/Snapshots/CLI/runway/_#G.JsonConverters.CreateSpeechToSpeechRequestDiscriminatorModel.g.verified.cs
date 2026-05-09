//HintName: G.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModel.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSpeechToSpeechRequestDiscriminatorModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateSpeechToSpeechRequestDiscriminatorModel>
    {
        /// <inheritdoc />
        public override global::G.CreateSpeechToSpeechRequestDiscriminatorModel Read(
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
                        return global::G.CreateSpeechToSpeechRequestDiscriminatorModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateSpeechToSpeechRequestDiscriminatorModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateSpeechToSpeechRequestDiscriminatorModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateSpeechToSpeechRequestDiscriminatorModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateSpeechToSpeechRequestDiscriminatorModelExtensions.ToValueString(value));
        }
    }
}
