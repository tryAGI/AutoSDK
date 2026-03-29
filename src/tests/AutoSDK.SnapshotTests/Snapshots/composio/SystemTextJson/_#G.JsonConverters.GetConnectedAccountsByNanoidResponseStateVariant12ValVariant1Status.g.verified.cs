//HintName: G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1StatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status>
    {
        /// <inheritdoc />
        public override global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status Read(
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
                        return global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1StatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1StatusExtensions.ToValueString(value));
        }
    }
}
