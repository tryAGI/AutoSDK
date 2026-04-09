//HintName: G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme>
    {
        /// <inheritdoc />
        public override global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme existingValue,
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
                        return global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeExtensions.ToValueString(value));
        }
    }
}
