//HintName: JsonConverters.ReposGetRepoRuleSuitesTimePeriodNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposGetRepoRuleSuitesTimePeriodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposGetRepoRuleSuitesTimePeriod?>
    {
        /// <inheritdoc />
        public override global::G.ReposGetRepoRuleSuitesTimePeriod? Read(
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
                        return global::G.ReposGetRepoRuleSuitesTimePeriodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposGetRepoRuleSuitesTimePeriod)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposGetRepoRuleSuitesTimePeriod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ReposGetRepoRuleSuitesTimePeriodExtensions.ToValueString(value.Value));
            }
        }
    }
}
