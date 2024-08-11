//HintName: JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByType.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeploymentsCreateResponseCurrentReleaseCreatedByTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DeploymentsCreateResponseCurrentReleaseCreatedByType>
    {
        /// <inheritdoc />
        public override global::G.DeploymentsCreateResponseCurrentReleaseCreatedByType Read(
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
                        return global::G.DeploymentsCreateResponseCurrentReleaseCreatedByTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.DeploymentsCreateResponseCurrentReleaseCreatedByType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DeploymentsCreateResponseCurrentReleaseCreatedByType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.DeploymentsCreateResponseCurrentReleaseCreatedByTypeExtensions.ToValueString(value));
        }
    }
}
