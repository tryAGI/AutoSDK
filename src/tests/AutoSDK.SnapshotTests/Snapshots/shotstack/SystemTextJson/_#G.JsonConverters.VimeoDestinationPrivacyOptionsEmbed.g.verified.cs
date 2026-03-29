//HintName: G.JsonConverters.VimeoDestinationPrivacyOptionsEmbed.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class VimeoDestinationPrivacyOptionsEmbedJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.VimeoDestinationPrivacyOptionsEmbed>
    {
        /// <inheritdoc />
        public override global::G.VimeoDestinationPrivacyOptionsEmbed Read(
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
                        return global::G.VimeoDestinationPrivacyOptionsEmbedExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.VimeoDestinationPrivacyOptionsEmbed)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.VimeoDestinationPrivacyOptionsEmbed);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.VimeoDestinationPrivacyOptionsEmbed value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.VimeoDestinationPrivacyOptionsEmbedExtensions.ToValueString(value));
        }
    }
}
