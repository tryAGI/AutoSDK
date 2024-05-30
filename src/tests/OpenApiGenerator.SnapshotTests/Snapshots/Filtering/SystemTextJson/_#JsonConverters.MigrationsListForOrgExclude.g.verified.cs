//HintName: JsonConverters.MigrationsListForOrgExclude.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class MigrationsListForOrgExcludeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MigrationsListForOrgExclude>
    {
        public override global::G.MigrationsListForOrgExclude Read(
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
                        return global::G.MigrationsListForOrgExcludeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.MigrationsListForOrgExcludeExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MigrationsListForOrgExclude value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.MigrationsListForOrgExcludeExtensions.ToValueString(value));
        }
    }
}
