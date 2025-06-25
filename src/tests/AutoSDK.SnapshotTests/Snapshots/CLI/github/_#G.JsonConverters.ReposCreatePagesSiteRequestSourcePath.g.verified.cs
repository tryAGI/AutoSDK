//HintName: G.JsonConverters.ReposCreatePagesSiteRequestSourcePath.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposCreatePagesSiteRequestSourcePathJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposCreatePagesSiteRequestSourcePath>
    {
        /// <inheritdoc />
        public override global::G.ReposCreatePagesSiteRequestSourcePath Read(
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
                        return global::G.ReposCreatePagesSiteRequestSourcePathExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposCreatePagesSiteRequestSourcePath)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ReposCreatePagesSiteRequestSourcePath);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposCreatePagesSiteRequestSourcePath value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ReposCreatePagesSiteRequestSourcePathExtensions.ToValueString(value));
        }
    }
}
