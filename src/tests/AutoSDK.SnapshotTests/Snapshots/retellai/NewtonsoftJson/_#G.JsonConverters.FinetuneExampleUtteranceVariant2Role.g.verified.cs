//HintName: G.JsonConverters.FinetuneExampleUtteranceVariant2Role.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FinetuneExampleUtteranceVariant2RoleJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.FinetuneExampleUtteranceVariant2Role>
    {
        /// <inheritdoc />
        public override global::G.FinetuneExampleUtteranceVariant2Role ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.FinetuneExampleUtteranceVariant2Role existingValue,
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
                        return global::G.FinetuneExampleUtteranceVariant2RoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.FinetuneExampleUtteranceVariant2Role)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.FinetuneExampleUtteranceVariant2Role);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.FinetuneExampleUtteranceVariant2Role value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.FinetuneExampleUtteranceVariant2RoleExtensions.ToValueString(value));
        }
    }
}
