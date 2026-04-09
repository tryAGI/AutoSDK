//HintName: G.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>
    {
        /// <inheritdoc />
        public override global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemExtensions.ToValueString(value));
        }
    }
}
