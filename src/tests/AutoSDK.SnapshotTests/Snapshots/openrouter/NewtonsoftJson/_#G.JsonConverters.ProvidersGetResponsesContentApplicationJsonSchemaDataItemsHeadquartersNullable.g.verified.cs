//HintName: G.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?>
    {
        /// <inheritdoc />
        public override global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters? existingValue,
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
                        return global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersExtensions.ToValueString(value.Value));
            }
        }
    }
}
