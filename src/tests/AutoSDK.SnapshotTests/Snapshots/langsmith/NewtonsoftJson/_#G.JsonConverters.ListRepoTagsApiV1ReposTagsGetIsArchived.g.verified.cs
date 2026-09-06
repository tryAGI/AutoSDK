//HintName: G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListRepoTagsApiV1ReposTagsGetIsArchivedJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListRepoTagsApiV1ReposTagsGetIsArchived>
    {
        /// <inheritdoc />
        public override global::G.ListRepoTagsApiV1ReposTagsGetIsArchived ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListRepoTagsApiV1ReposTagsGetIsArchived existingValue,
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
                        return global::G.ListRepoTagsApiV1ReposTagsGetIsArchivedExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListRepoTagsApiV1ReposTagsGetIsArchived)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListRepoTagsApiV1ReposTagsGetIsArchived);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListRepoTagsApiV1ReposTagsGetIsArchived value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ListRepoTagsApiV1ReposTagsGetIsArchivedExtensions.ToValueString(value));
        }
    }
}
