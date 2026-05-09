//HintName: G.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVoiceDubbingRequestDiscriminatorModelNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateVoiceDubbingRequestDiscriminatorModel?>
    {
        /// <inheritdoc />
        public override global::G.CreateVoiceDubbingRequestDiscriminatorModel? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateVoiceDubbingRequestDiscriminatorModel? existingValue,
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
                        return global::G.CreateVoiceDubbingRequestDiscriminatorModelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateVoiceDubbingRequestDiscriminatorModel)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateVoiceDubbingRequestDiscriminatorModel?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateVoiceDubbingRequestDiscriminatorModel? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateVoiceDubbingRequestDiscriminatorModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
