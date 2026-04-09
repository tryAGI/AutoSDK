//HintName: G.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussionsJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions>
    {
        /// <inheritdoc />
        public override global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions existingValue,
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
                        return global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussionsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussionsExtensions.ToValueString(value));
        }
    }
}
