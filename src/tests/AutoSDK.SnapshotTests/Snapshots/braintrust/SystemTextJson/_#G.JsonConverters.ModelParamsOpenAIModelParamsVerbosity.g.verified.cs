//HintName: G.JsonConverters.ModelParamsOpenAIModelParamsVerbosity.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelParamsOpenAIModelParamsVerbosityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModelParamsOpenAIModelParamsVerbosity>
    {
        /// <inheritdoc />
        public override global::G.ModelParamsOpenAIModelParamsVerbosity Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.ModelParamsOpenAIModelParamsVerbosityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ModelParamsOpenAIModelParamsVerbosity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ModelParamsOpenAIModelParamsVerbosity);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ModelParamsOpenAIModelParamsVerbosity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ModelParamsOpenAIModelParamsVerbosityExtensions.ToValueString(value));
        }
    }
}
