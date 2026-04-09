//HintName: G.JsonConverters.FineTuningJobHyperparametersBatchSize.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuningJobHyperparametersBatchSizeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.FineTuningJobHyperparametersBatchSize>
    {
        /// <inheritdoc />
        public override global::G.FineTuningJobHyperparametersBatchSize ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.FineTuningJobHyperparametersBatchSize existingValue,
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
                        return global::G.FineTuningJobHyperparametersBatchSizeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.FineTuningJobHyperparametersBatchSize)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.FineTuningJobHyperparametersBatchSize);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.FineTuningJobHyperparametersBatchSize value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.FineTuningJobHyperparametersBatchSizeExtensions.ToValueString(value));
        }
    }
}
