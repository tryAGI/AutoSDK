//HintName: G.JsonConverters.Create2RequestScriptTextProviderAmazonVoiceId.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Create2RequestScriptTextProviderAmazonVoiceIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Create2RequestScriptTextProviderAmazonVoiceId>
    {
        /// <inheritdoc />
        public override global::G.Create2RequestScriptTextProviderAmazonVoiceId Read(
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
                        return global::G.Create2RequestScriptTextProviderAmazonVoiceIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.Create2RequestScriptTextProviderAmazonVoiceId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.Create2RequestScriptTextProviderAmazonVoiceId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Create2RequestScriptTextProviderAmazonVoiceId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.Create2RequestScriptTextProviderAmazonVoiceIdExtensions.ToValueString(value));
        }
    }
}
