//HintName: G.JsonConverters.OnlineScoreConfigScorerVariant2FunctionType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OnlineScoreConfigScorerVariant2FunctionTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.OnlineScoreConfigScorerVariant2FunctionType>
    {
        /// <inheritdoc />
        public override global::G.OnlineScoreConfigScorerVariant2FunctionType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.OnlineScoreConfigScorerVariant2FunctionType existingValue,
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
                        return global::G.OnlineScoreConfigScorerVariant2FunctionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.OnlineScoreConfigScorerVariant2FunctionType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.OnlineScoreConfigScorerVariant2FunctionType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.OnlineScoreConfigScorerVariant2FunctionType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.OnlineScoreConfigScorerVariant2FunctionTypeExtensions.ToValueString(value));
        }
    }
}
