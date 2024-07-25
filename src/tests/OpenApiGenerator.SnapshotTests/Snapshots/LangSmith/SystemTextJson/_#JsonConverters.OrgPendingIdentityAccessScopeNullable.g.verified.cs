//HintName: JsonConverters.OrgPendingIdentityAccessScopeNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrgPendingIdentityAccessScopeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OrgPendingIdentityAccessScope?>
    {
        /// <inheritdoc />
        public override global::G.OrgPendingIdentityAccessScope? Read(
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
                        return global::G.OrgPendingIdentityAccessScopeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.OrgPendingIdentityAccessScope)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OrgPendingIdentityAccessScope? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.OrgPendingIdentityAccessScopeExtensions.ToValueString(value.Value));
            }
        }
    }
}
