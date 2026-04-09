//HintName: G.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelId.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId>
    {
        /// <inheritdoc />
        public override global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId existingValue,
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
                        return global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelIdExtensions.ToValueString(value));
        }
    }
}
