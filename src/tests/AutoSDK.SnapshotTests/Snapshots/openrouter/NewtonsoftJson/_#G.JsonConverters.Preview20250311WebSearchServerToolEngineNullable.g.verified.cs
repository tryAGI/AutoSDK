//HintName: G.JsonConverters.Preview20250311WebSearchServerToolEngineNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Preview20250311WebSearchServerToolEngineNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.Preview20250311WebSearchServerToolEngine?>
    {
        /// <inheritdoc />
        public override global::G.Preview20250311WebSearchServerToolEngine? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.Preview20250311WebSearchServerToolEngine? existingValue,
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
                        return global::G.Preview20250311WebSearchServerToolEngineExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.Preview20250311WebSearchServerToolEngine)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.Preview20250311WebSearchServerToolEngine?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.Preview20250311WebSearchServerToolEngine? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.Preview20250311WebSearchServerToolEngineExtensions.ToValueString(value.Value));
            }
        }
    }
}
