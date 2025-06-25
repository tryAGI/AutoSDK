//HintName: G.JsonConverters.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPackageUpdatedPackagePackageVersionReleaseAuthorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType?>
    {
        /// <inheritdoc />
        public override global::G.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType? Read(
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
                        return global::G.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
