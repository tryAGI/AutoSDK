//HintName: G.JsonConverters.SkipResponseEdgeVariant2TransitionConditionType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SkipResponseEdgeVariant2TransitionConditionTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.SkipResponseEdgeVariant2TransitionConditionType>
    {
        /// <inheritdoc />
        public override global::G.SkipResponseEdgeVariant2TransitionConditionType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.SkipResponseEdgeVariant2TransitionConditionType existingValue,
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
                        return global::G.SkipResponseEdgeVariant2TransitionConditionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.SkipResponseEdgeVariant2TransitionConditionType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.SkipResponseEdgeVariant2TransitionConditionType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.SkipResponseEdgeVariant2TransitionConditionType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.SkipResponseEdgeVariant2TransitionConditionTypeExtensions.ToValueString(value));
        }
    }
}
