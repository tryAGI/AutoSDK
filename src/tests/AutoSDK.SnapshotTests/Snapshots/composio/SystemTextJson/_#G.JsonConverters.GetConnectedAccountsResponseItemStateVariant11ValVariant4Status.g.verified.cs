//HintName: G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsResponseItemStateVariant11ValVariant4StatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status>
    {
        /// <inheritdoc />
        public override global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status Read(
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
                        return global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4StatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4StatusExtensions.ToValueString(value));
        }
    }
}
