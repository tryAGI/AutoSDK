//HintName: G.JsonConverters.ListUsageLimitsPolicyEntitiesStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListUsageLimitsPolicyEntitiesStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListUsageLimitsPolicyEntitiesStatus>
    {
        /// <inheritdoc />
        public override global::G.ListUsageLimitsPolicyEntitiesStatus Read(
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
                        return global::G.ListUsageLimitsPolicyEntitiesStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListUsageLimitsPolicyEntitiesStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListUsageLimitsPolicyEntitiesStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListUsageLimitsPolicyEntitiesStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ListUsageLimitsPolicyEntitiesStatusExtensions.ToValueString(value));
        }
    }
}
