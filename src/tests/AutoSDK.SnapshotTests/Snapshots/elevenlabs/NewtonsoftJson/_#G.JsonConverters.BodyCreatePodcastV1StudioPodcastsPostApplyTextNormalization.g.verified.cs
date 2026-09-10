//HintName: G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalizationJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization>
    {
        /// <inheritdoc />
        public override global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization existingValue,
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
                        return global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalizationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalizationExtensions.ToValueString(value));
        }
    }
}
