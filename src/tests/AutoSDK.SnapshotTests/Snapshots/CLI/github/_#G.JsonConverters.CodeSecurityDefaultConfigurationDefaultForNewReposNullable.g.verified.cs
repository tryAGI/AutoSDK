//HintName: G.JsonConverters.CodeSecurityDefaultConfigurationDefaultForNewReposNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityDefaultConfigurationDefaultForNewReposNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeSecurityDefaultConfigurationDefaultForNewRepos?>
    {
        /// <inheritdoc />
        public override global::G.CodeSecurityDefaultConfigurationDefaultForNewRepos? Read(
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
                        return global::G.CodeSecurityDefaultConfigurationDefaultForNewReposExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CodeSecurityDefaultConfigurationDefaultForNewRepos)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CodeSecurityDefaultConfigurationDefaultForNewRepos?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeSecurityDefaultConfigurationDefaultForNewRepos? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CodeSecurityDefaultConfigurationDefaultForNewReposExtensions.ToValueString(value.Value));
            }
        }
    }
}
