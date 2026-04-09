//HintName: G.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType?>
    {
        /// <inheritdoc />
        public override global::G.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType? existingValue,
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
                        return global::G.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
