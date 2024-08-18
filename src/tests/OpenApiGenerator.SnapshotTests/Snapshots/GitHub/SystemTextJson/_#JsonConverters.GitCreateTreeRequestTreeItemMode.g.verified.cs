﻿//HintName: JsonConverters.GitCreateTreeRequestTreeItemMode.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class GitCreateTreeRequestTreeItemModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GitCreateTreeRequestTreeItemMode>
    {
        /// <inheritdoc />
        public override global::G.GitCreateTreeRequestTreeItemMode Read(
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
                        return global::G.GitCreateTreeRequestTreeItemModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GitCreateTreeRequestTreeItemMode)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GitCreateTreeRequestTreeItemMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GitCreateTreeRequestTreeItemModeExtensions.ToValueString(value));
        }
    }
}