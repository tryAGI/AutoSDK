//HintName: JsonConverters.OrgMemberIdentityAccessScopeNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrgMemberIdentityAccessScopeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OrgMemberIdentityAccessScope?>
    {
        /// <inheritdoc />
        public override global::G.OrgMemberIdentityAccessScope? Read(
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
                        return global::G.OrgMemberIdentityAccessScopeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.OrgMemberIdentityAccessScope)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OrgMemberIdentityAccessScope? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.OrgMemberIdentityAccessScopeExtensions.ToValueString(value.Value));
            }
        }
    }
}
