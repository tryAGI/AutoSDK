//HintName: G.JsonConverters.RepositoryRulesetConditionsRepositoryPropertySpecSource.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryRulesetConditionsRepositoryPropertySpecSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource>
    {
        /// <inheritdoc />
        public override global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource Read(
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
                        return global::G.RepositoryRulesetConditionsRepositoryPropertySpecSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.RepositoryRulesetConditionsRepositoryPropertySpecSourceExtensions.ToValueString(value));
        }
    }
}
