//HintName: G.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2?>
    {
        /// <inheritdoc />
        public override global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2? existingValue,
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
                        return global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2Extensions.ToValueString(value.Value));
            }
        }
    }
}
