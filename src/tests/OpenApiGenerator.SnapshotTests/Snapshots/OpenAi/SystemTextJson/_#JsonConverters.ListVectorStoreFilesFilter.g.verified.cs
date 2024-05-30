//HintName: JsonConverters.ListVectorStoreFilesFilter.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class ListVectorStoreFilesFilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListVectorStoreFilesFilter>
    {
        public override global::G.ListVectorStoreFilesFilter Read(
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
                        return global::G.ListVectorStoreFilesFilterExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.ListVectorStoreFilesFilterExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListVectorStoreFilesFilter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ListVectorStoreFilesFilterExtensions.ToValueString(value));
        }
    }
}
