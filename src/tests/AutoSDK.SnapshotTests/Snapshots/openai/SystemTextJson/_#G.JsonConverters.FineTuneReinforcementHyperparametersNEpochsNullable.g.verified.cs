//HintName: G.JsonConverters.FineTuneReinforcementHyperparametersNEpochsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuneReinforcementHyperparametersNEpochsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FineTuneReinforcementHyperparametersNEpochs?>
    {
        /// <inheritdoc />
        public override global::G.FineTuneReinforcementHyperparametersNEpochs? Read(
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
                        return global::G.FineTuneReinforcementHyperparametersNEpochsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FineTuneReinforcementHyperparametersNEpochs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FineTuneReinforcementHyperparametersNEpochs?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FineTuneReinforcementHyperparametersNEpochs? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FineTuneReinforcementHyperparametersNEpochsExtensions.ToValueString(value.Value));
            }
        }
    }
}
