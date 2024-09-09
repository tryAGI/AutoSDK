//HintName: JsonConverters.AppsListAccountsForPlanStubbedDirection.g.cs
#nullable enable

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsListAccountsForPlanStubbedDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AppsListAccountsForPlanStubbedDirection>
    {
        /// <inheritdoc />
        public override global::G.AppsListAccountsForPlanStubbedDirection Read(
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
                        return global::G.AppsListAccountsForPlanStubbedDirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AppsListAccountsForPlanStubbedDirection)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AppsListAccountsForPlanStubbedDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.AppsListAccountsForPlanStubbedDirectionExtensions.ToValueString(value));
        }
    }
}
