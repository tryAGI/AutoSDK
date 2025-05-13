//HintName: JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole?>
    {
        /// <inheritdoc />
        public override global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? Read(
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
                        return global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
