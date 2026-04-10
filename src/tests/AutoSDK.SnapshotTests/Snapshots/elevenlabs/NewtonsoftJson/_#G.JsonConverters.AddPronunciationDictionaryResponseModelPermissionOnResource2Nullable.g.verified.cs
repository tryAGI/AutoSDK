//HintName: G.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2?>
    {
        /// <inheritdoc />
        public override global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2? existingValue,
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
                        return global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2Extensions.ToValueString(value.Value));
            }
        }
    }
}
