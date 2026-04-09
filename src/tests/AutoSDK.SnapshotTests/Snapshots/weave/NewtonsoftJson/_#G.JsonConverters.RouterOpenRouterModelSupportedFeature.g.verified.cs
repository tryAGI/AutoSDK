//HintName: G.JsonConverters.RouterOpenRouterModelSupportedFeature.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RouterOpenRouterModelSupportedFeatureJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.RouterOpenRouterModelSupportedFeature>
    {
        /// <inheritdoc />
        public override global::G.RouterOpenRouterModelSupportedFeature ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.RouterOpenRouterModelSupportedFeature existingValue,
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
                        return global::G.RouterOpenRouterModelSupportedFeatureExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.RouterOpenRouterModelSupportedFeature)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.RouterOpenRouterModelSupportedFeature);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.RouterOpenRouterModelSupportedFeature value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.RouterOpenRouterModelSupportedFeatureExtensions.ToValueString(value));
        }
    }
}
