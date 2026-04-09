//HintName: G.JsonConverters.CodeInterpreterServerToolContainerOneOf1MemoryLimit.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeInterpreterServerToolContainerOneOf1MemoryLimitJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit>
    {
        /// <inheritdoc />
        public override global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit existingValue,
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
                        return global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimitExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimitExtensions.ToValueString(value));
        }
    }
}
