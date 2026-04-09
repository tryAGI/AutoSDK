//HintName: G.JsonConverters.TeamsUpdateInOrgRequestNotificationSetting.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamsUpdateInOrgRequestNotificationSettingJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.TeamsUpdateInOrgRequestNotificationSetting>
    {
        /// <inheritdoc />
        public override global::G.TeamsUpdateInOrgRequestNotificationSetting ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.TeamsUpdateInOrgRequestNotificationSetting existingValue,
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
                        return global::G.TeamsUpdateInOrgRequestNotificationSettingExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.TeamsUpdateInOrgRequestNotificationSetting)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.TeamsUpdateInOrgRequestNotificationSetting);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.TeamsUpdateInOrgRequestNotificationSetting value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.TeamsUpdateInOrgRequestNotificationSettingExtensions.ToValueString(value));
        }
    }
}
