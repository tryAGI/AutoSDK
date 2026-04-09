//HintName: G.JsonConverters.UpdateChatMetadataRequestDataStorageSetting.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateChatMetadataRequestDataStorageSettingJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateChatMetadataRequestDataStorageSetting>
    {
        /// <inheritdoc />
        public override global::G.UpdateChatMetadataRequestDataStorageSetting ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateChatMetadataRequestDataStorageSetting existingValue,
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
                        return global::G.UpdateChatMetadataRequestDataStorageSettingExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateChatMetadataRequestDataStorageSetting)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateChatMetadataRequestDataStorageSetting);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateChatMetadataRequestDataStorageSetting value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdateChatMetadataRequestDataStorageSettingExtensions.ToValueString(value));
        }
    }
}
