//HintName: G.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PronunciationDictionaryVersionResponseModelPermissionOnResourceJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource>
    {
        /// <inheritdoc />
        public override global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource existingValue,
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
                        return global::G.PronunciationDictionaryVersionResponseModelPermissionOnResourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PronunciationDictionaryVersionResponseModelPermissionOnResourceExtensions.ToValueString(value));
        }
    }
}
