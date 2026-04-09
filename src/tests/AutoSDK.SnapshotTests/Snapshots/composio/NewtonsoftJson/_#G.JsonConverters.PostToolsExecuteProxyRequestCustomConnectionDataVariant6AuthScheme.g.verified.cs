//HintName: G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthSchemeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme>
    {
        /// <inheritdoc />
        public override global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme existingValue,
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
                        return global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthSchemeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthSchemeExtensions.ToValueString(value));
        }
    }
}
