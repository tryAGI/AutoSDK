//HintName: G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelParamsOpenAIModelParamsToolChoiceAutoNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModelParamsOpenAIModelParamsToolChoiceAuto?>
    {
        /// <inheritdoc />
        public override global::G.ModelParamsOpenAIModelParamsToolChoiceAuto? Read(
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
                        return global::G.ModelParamsOpenAIModelParamsToolChoiceAutoExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ModelParamsOpenAIModelParamsToolChoiceAuto)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ModelParamsOpenAIModelParamsToolChoiceAuto?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ModelParamsOpenAIModelParamsToolChoiceAuto? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ModelParamsOpenAIModelParamsToolChoiceAutoExtensions.ToValueString(value.Value));
            }
        }
    }
}
