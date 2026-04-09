//HintName: G.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject?>
    {
        /// <inheritdoc />
        public override global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? existingValue,
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
                        return global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
