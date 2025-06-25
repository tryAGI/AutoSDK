//HintName: G.JsonConverters.CodeSecurityCreateConfigurationRequestDependencyGraphNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityCreateConfigurationRequestDependencyGraphNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeSecurityCreateConfigurationRequestDependencyGraph?>
    {
        /// <inheritdoc />
        public override global::G.CodeSecurityCreateConfigurationRequestDependencyGraph? Read(
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
                        return global::G.CodeSecurityCreateConfigurationRequestDependencyGraphExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CodeSecurityCreateConfigurationRequestDependencyGraph)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CodeSecurityCreateConfigurationRequestDependencyGraph?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraph? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CodeSecurityCreateConfigurationRequestDependencyGraphExtensions.ToValueString(value.Value));
            }
        }
    }
}
