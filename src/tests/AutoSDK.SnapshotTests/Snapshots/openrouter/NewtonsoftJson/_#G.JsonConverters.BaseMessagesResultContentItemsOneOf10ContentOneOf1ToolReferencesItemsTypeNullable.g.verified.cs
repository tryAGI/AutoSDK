//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType?>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType? existingValue,
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
                        return global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
