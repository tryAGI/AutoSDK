//HintName: G.JsonConverters.FineTuneDPOMethodHyperparametersNEpochsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuneDPOMethodHyperparametersNEpochsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FineTuneDPOMethodHyperparametersNEpochs?>
    {
        /// <inheritdoc />
        public override global::G.FineTuneDPOMethodHyperparametersNEpochs? Read(
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
                        return global::G.FineTuneDPOMethodHyperparametersNEpochsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FineTuneDPOMethodHyperparametersNEpochs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FineTuneDPOMethodHyperparametersNEpochs?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FineTuneDPOMethodHyperparametersNEpochs? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FineTuneDPOMethodHyperparametersNEpochsExtensions.ToValueString(value.Value));
            }
        }
    }
}
