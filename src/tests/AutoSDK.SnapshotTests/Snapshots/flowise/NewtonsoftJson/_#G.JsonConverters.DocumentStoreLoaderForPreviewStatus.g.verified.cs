//HintName: G.JsonConverters.DocumentStoreLoaderForPreviewStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DocumentStoreLoaderForPreviewStatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.DocumentStoreLoaderForPreviewStatus>
    {
        /// <inheritdoc />
        public override global::G.DocumentStoreLoaderForPreviewStatus ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.DocumentStoreLoaderForPreviewStatus existingValue,
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
                        return global::G.DocumentStoreLoaderForPreviewStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.DocumentStoreLoaderForPreviewStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.DocumentStoreLoaderForPreviewStatus);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.DocumentStoreLoaderForPreviewStatus value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.DocumentStoreLoaderForPreviewStatusExtensions.ToValueString(value));
        }
    }
}
