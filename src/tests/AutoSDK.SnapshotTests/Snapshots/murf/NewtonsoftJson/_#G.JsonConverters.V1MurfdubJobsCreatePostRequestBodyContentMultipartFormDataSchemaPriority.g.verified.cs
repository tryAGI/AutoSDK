//HintName: G.JsonConverters.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriorityJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority>
    {
        /// <inheritdoc />
        public override global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority existingValue,
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
                        return global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriorityExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriorityExtensions.ToValueString(value));
        }
    }
}
