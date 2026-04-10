//HintName: G.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateFineTuningJobRequestHyperparametersLearningRateMultiplierNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?>
    {
        /// <inheritdoc />
        public override global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier? existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierExtensions.ToValueString(value.Value));
            }
        }
    }
}
