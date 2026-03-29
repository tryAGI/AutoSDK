//HintName: G.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnColumn.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class JSONQueryOnCallTableWithStringTypeColumnColumnJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JSONQueryOnCallTableWithStringTypeColumnColumn>
    {
        /// <inheritdoc />
        public override global::G.JSONQueryOnCallTableWithStringTypeColumnColumn Read(
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
                        return global::G.JSONQueryOnCallTableWithStringTypeColumnColumnExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.JSONQueryOnCallTableWithStringTypeColumnColumn)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.JSONQueryOnCallTableWithStringTypeColumnColumn);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JSONQueryOnCallTableWithStringTypeColumnColumn value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.JSONQueryOnCallTableWithStringTypeColumnColumnExtensions.ToValueString(value));
        }
    }
}
