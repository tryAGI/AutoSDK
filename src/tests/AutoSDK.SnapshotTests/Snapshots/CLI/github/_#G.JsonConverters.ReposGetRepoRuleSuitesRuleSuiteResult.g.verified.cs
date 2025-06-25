﻿//HintName: G.JsonConverters.ReposGetRepoRuleSuitesRuleSuiteResult.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposGetRepoRuleSuitesRuleSuiteResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposGetRepoRuleSuitesRuleSuiteResult>
    {
        /// <inheritdoc />
        public override global::G.ReposGetRepoRuleSuitesRuleSuiteResult Read(
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
                        return global::G.ReposGetRepoRuleSuitesRuleSuiteResultExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposGetRepoRuleSuitesRuleSuiteResult)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ReposGetRepoRuleSuitesRuleSuiteResult);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposGetRepoRuleSuitesRuleSuiteResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ReposGetRepoRuleSuitesRuleSuiteResultExtensions.ToValueString(value));
        }
    }
}
