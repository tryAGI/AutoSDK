//HintName: G.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModel.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVoiceIsolationRequestDiscriminatorModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateVoiceIsolationRequestDiscriminatorModel>
    {
        /// <inheritdoc />
        public override global::G.CreateVoiceIsolationRequestDiscriminatorModel Read(
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
                        return global::G.CreateVoiceIsolationRequestDiscriminatorModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateVoiceIsolationRequestDiscriminatorModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateVoiceIsolationRequestDiscriminatorModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateVoiceIsolationRequestDiscriminatorModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateVoiceIsolationRequestDiscriminatorModelExtensions.ToValueString(value));
        }
    }
}
