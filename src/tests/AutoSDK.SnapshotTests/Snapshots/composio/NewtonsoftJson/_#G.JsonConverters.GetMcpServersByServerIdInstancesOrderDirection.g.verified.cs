//HintName: G.JsonConverters.GetMcpServersByServerIdInstancesOrderDirection.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMcpServersByServerIdInstancesOrderDirectionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetMcpServersByServerIdInstancesOrderDirection>
    {
        /// <inheritdoc />
        public override global::G.GetMcpServersByServerIdInstancesOrderDirection ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetMcpServersByServerIdInstancesOrderDirection existingValue,
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
                        return global::G.GetMcpServersByServerIdInstancesOrderDirectionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetMcpServersByServerIdInstancesOrderDirection)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetMcpServersByServerIdInstancesOrderDirection);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetMcpServersByServerIdInstancesOrderDirection value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetMcpServersByServerIdInstancesOrderDirectionExtensions.ToValueString(value));
        }
    }
}
