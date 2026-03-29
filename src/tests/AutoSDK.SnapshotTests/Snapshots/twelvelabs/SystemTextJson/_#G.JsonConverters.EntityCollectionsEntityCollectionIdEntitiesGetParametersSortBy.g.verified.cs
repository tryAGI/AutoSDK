//HintName: G.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy>
    {
        /// <inheritdoc />
        public override global::G.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy Read(
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
                        return global::G.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByExtensions.ToValueString(value));
        }
    }
}
