﻿//HintName: G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetKnowledgeBaseSummaryFileResponseModelTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetKnowledgeBaseSummaryFileResponseModelType?>
    {
        /// <inheritdoc />
        public override global::G.GetKnowledgeBaseSummaryFileResponseModelType? Read(
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
                        return global::G.GetKnowledgeBaseSummaryFileResponseModelTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetKnowledgeBaseSummaryFileResponseModelType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetKnowledgeBaseSummaryFileResponseModelType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetKnowledgeBaseSummaryFileResponseModelType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetKnowledgeBaseSummaryFileResponseModelTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
