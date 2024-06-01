//HintName: JsonConverters.RepositoryAdvisoryCreateCreditsType.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryAdvisoryCreateCreditsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoryAdvisoryCreateCreditsType>
    {
        /// <inheritdoc />
        public override global::G.RepositoryAdvisoryCreateCreditsType Read(
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
                        return global::G.RepositoryAdvisoryCreateCreditsTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RepositoryAdvisoryCreateCreditsType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryAdvisoryCreateCreditsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.RepositoryAdvisoryCreateCreditsTypeExtensions.ToValueString(value));
        }
    }
}
