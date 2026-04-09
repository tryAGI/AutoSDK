//HintName: G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthSchemeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthSchemeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme?>
    {
        /// <inheritdoc />
        public override global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme? existingValue,
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
                        return global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthSchemeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthSchemeExtensions.ToValueString(value.Value));
            }
        }
    }
}
