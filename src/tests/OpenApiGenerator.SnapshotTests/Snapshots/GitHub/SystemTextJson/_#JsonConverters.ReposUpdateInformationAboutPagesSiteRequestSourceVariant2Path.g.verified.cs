//HintName: JsonConverters.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposUpdateInformationAboutPagesSiteRequestSourceVariant2PathJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path>
    {
        /// <inheritdoc />
        public override global::G.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path Read(
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
                        return global::G.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2PathExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2PathExtensions.ToValueString(value));
        }
    }
}
