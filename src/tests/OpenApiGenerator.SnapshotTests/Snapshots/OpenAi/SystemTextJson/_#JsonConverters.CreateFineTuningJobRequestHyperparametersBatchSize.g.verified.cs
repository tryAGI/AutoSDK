//HintName: JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSize.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class CreateFineTuningJobRequestHyperparametersBatchSizeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateFineTuningJobRequestHyperparametersBatchSize>
    {
        public override global::G.CreateFineTuningJobRequestHyperparametersBatchSize Read(
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
                        return global::G.CreateFineTuningJobRequestHyperparametersBatchSizeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.CreateFineTuningJobRequestHyperparametersBatchSizeExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateFineTuningJobRequestHyperparametersBatchSize value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.CreateFineTuningJobRequestHyperparametersBatchSizeExtensions.ToValueString(value));
        }
    }
}
