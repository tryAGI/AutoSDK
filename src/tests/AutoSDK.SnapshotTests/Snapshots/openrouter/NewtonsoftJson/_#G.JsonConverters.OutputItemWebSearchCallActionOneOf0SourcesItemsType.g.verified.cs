//HintName: G.JsonConverters.OutputItemWebSearchCallActionOneOf0SourcesItemsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OutputItemWebSearchCallActionOneOf0SourcesItemsTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType>
    {
        /// <inheritdoc />
        public override global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType existingValue,
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
                        return global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeExtensions.ToValueString(value));
        }
    }
}
