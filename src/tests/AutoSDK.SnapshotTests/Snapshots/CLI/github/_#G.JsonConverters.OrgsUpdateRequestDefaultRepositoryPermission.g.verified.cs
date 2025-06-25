//HintName: G.JsonConverters.OrgsUpdateRequestDefaultRepositoryPermission.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrgsUpdateRequestDefaultRepositoryPermissionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OrgsUpdateRequestDefaultRepositoryPermission>
    {
        /// <inheritdoc />
        public override global::G.OrgsUpdateRequestDefaultRepositoryPermission Read(
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
                        return global::G.OrgsUpdateRequestDefaultRepositoryPermissionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.OrgsUpdateRequestDefaultRepositoryPermission)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.OrgsUpdateRequestDefaultRepositoryPermission);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OrgsUpdateRequestDefaultRepositoryPermission value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.OrgsUpdateRequestDefaultRepositoryPermissionExtensions.ToValueString(value));
        }
    }
}
