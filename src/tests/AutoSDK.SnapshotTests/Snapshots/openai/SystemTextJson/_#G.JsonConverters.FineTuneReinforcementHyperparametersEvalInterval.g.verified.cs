//HintName: G.JsonConverters.FineTuneReinforcementHyperparametersEvalInterval.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuneReinforcementHyperparametersEvalIntervalJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FineTuneReinforcementHyperparametersEvalInterval>
    {
        /// <inheritdoc />
        public override global::G.FineTuneReinforcementHyperparametersEvalInterval Read(
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
                        return global::G.FineTuneReinforcementHyperparametersEvalIntervalExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FineTuneReinforcementHyperparametersEvalInterval)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FineTuneReinforcementHyperparametersEvalInterval);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FineTuneReinforcementHyperparametersEvalInterval value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.FineTuneReinforcementHyperparametersEvalIntervalExtensions.ToValueString(value));
        }
    }
}
