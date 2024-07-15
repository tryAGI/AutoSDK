//HintName: JsonConverters.ReposGetRepoRuleSuitesResponseEvaluationResult.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposGetRepoRuleSuitesResponseEvaluationResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposGetRepoRuleSuitesResponseEvaluationResult>
    {
        /// <inheritdoc />
        public override global::G.ReposGetRepoRuleSuitesResponseEvaluationResult Read(
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
                        return global::G.ReposGetRepoRuleSuitesResponseEvaluationResultExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposGetRepoRuleSuitesResponseEvaluationResult)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposGetRepoRuleSuitesResponseEvaluationResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ReposGetRepoRuleSuitesResponseEvaluationResultExtensions.ToValueString(value));
        }
    }
}
