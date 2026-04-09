//HintName: G.JsonConverters.GetClipsPresentersResponsePresenterVoiceElevenLabsTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetClipsPresentersResponsePresenterVoiceElevenLabsTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetClipsPresentersResponsePresenterVoiceElevenLabsType?>
    {
        /// <inheritdoc />
        public override global::G.GetClipsPresentersResponsePresenterVoiceElevenLabsType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetClipsPresentersResponsePresenterVoiceElevenLabsType? existingValue,
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
                        return global::G.GetClipsPresentersResponsePresenterVoiceElevenLabsTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetClipsPresentersResponsePresenterVoiceElevenLabsType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetClipsPresentersResponsePresenterVoiceElevenLabsType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetClipsPresentersResponsePresenterVoiceElevenLabsType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.GetClipsPresentersResponsePresenterVoiceElevenLabsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
