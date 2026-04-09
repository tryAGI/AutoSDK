//HintName: G.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat2?>
    {
        /// <inheritdoc />
        public override global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat2? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat2? existingValue,
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
                        return global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat2Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat2?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat2? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat2Extensions.ToValueString(value.Value));
            }
        }
    }
}
