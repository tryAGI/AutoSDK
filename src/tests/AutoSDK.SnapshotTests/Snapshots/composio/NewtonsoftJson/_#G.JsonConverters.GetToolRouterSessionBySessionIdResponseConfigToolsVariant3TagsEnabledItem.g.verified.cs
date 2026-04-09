//HintName: G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>
    {
        /// <inheritdoc />
        public override global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem existingValue,
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
                        return global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemExtensions.ToValueString(value));
        }
    }
}
