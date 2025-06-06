﻿//HintName: G.JsonConverters.BodyAddProjectV1ProjectsAddPostApplyTextNormalizationNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyAddProjectV1ProjectsAddPostApplyTextNormalizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization?>
    {
        /// <inheritdoc />
        public override global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization? Read(
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
                        return global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalizationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
