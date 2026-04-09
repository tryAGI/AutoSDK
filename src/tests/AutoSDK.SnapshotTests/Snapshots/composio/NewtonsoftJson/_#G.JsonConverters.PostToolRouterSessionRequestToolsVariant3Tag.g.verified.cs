//HintName: G.JsonConverters.PostToolRouterSessionRequestToolsVariant3Tag.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolRouterSessionRequestToolsVariant3TagJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostToolRouterSessionRequestToolsVariant3Tag>
    {
        /// <inheritdoc />
        public override global::G.PostToolRouterSessionRequestToolsVariant3Tag ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostToolRouterSessionRequestToolsVariant3Tag existingValue,
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
                        return global::G.PostToolRouterSessionRequestToolsVariant3TagExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostToolRouterSessionRequestToolsVariant3Tag)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostToolRouterSessionRequestToolsVariant3Tag);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostToolRouterSessionRequestToolsVariant3Tag value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PostToolRouterSessionRequestToolsVariant3TagExtensions.ToValueString(value));
        }
    }
}
