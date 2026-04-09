//HintName: G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthSchemeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme>
    {
        /// <inheritdoc />
        public override global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme existingValue,
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
                        return global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthSchemeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthSchemeExtensions.ToValueString(value));
        }
    }
}
