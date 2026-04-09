//HintName: G.JsonConverters.AlwaysEdgeVariant2TransitionConditionPrompt.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AlwaysEdgeVariant2TransitionConditionPromptJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AlwaysEdgeVariant2TransitionConditionPrompt>
    {
        /// <inheritdoc />
        public override global::G.AlwaysEdgeVariant2TransitionConditionPrompt ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AlwaysEdgeVariant2TransitionConditionPrompt existingValue,
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
                        return global::G.AlwaysEdgeVariant2TransitionConditionPromptExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AlwaysEdgeVariant2TransitionConditionPrompt)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AlwaysEdgeVariant2TransitionConditionPrompt);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AlwaysEdgeVariant2TransitionConditionPrompt value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AlwaysEdgeVariant2TransitionConditionPromptExtensions.ToValueString(value));
        }
    }
}
