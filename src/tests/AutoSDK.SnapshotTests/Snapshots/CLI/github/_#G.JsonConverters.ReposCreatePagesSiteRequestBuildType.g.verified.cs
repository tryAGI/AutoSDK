//HintName: G.JsonConverters.ReposCreatePagesSiteRequestBuildType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposCreatePagesSiteRequestBuildTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposCreatePagesSiteRequestBuildType>
    {
        /// <inheritdoc />
        public override global::G.ReposCreatePagesSiteRequestBuildType Read(
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
                        return global::G.ReposCreatePagesSiteRequestBuildTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposCreatePagesSiteRequestBuildType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ReposCreatePagesSiteRequestBuildType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposCreatePagesSiteRequestBuildType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ReposCreatePagesSiteRequestBuildTypeExtensions.ToValueString(value));
        }
    }
}
