//HintName: G.JsonConverters.GetOrgOwnerProjectListResponseDataItemWebhookVersionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrgOwnerProjectListResponseDataItemWebhookVersionNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersion?>
    {
        /// <inheritdoc />
        public override global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersion? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersion? existingValue,
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
                        return global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersion)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersion?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersion? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
