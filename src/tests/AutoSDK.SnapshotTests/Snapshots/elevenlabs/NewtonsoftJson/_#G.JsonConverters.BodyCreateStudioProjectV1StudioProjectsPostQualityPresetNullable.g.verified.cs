//HintName: G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyCreateStudioProjectV1StudioProjectsPostQualityPresetNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyCreateStudioProjectV1StudioProjectsPostQualityPreset?>
    {
        /// <inheritdoc />
        public override global::G.BodyCreateStudioProjectV1StudioProjectsPostQualityPreset? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyCreateStudioProjectV1StudioProjectsPostQualityPreset? existingValue,
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
                        return global::G.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyCreateStudioProjectV1StudioProjectsPostQualityPreset)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyCreateStudioProjectV1StudioProjectsPostQualityPreset?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyCreateStudioProjectV1StudioProjectsPostQualityPreset? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetExtensions.ToValueString(value.Value));
            }
        }
    }
}
