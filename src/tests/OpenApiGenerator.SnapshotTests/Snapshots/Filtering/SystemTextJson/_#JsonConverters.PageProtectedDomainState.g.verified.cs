//HintName: JsonConverters.PageProtectedDomainState.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class PageProtectedDomainStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PageProtectedDomainState>
    {
        public override global::G.PageProtectedDomainState Read(
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
                        return global::G.PageProtectedDomainStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.PageProtectedDomainStateExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PageProtectedDomainState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.PageProtectedDomainStateExtensions.ToValueString(value));
        }
    }
}
