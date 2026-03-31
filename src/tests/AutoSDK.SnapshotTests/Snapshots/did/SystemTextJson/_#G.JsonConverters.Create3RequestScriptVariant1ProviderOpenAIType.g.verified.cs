//HintName: G.JsonConverters.Create3RequestScriptVariant1ProviderOpenAIType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Create3RequestScriptVariant1ProviderOpenAITypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Create3RequestScriptVariant1ProviderOpenAIType>
    {
        /// <inheritdoc />
        public override global::G.Create3RequestScriptVariant1ProviderOpenAIType Read(
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
                        return global::G.Create3RequestScriptVariant1ProviderOpenAITypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.Create3RequestScriptVariant1ProviderOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.Create3RequestScriptVariant1ProviderOpenAIType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Create3RequestScriptVariant1ProviderOpenAIType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.Create3RequestScriptVariant1ProviderOpenAITypeExtensions.ToValueString(value));
        }
    }
}
