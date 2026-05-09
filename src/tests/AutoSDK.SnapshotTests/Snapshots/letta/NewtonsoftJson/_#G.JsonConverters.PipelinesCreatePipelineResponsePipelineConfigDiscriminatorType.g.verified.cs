//HintName: G.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PipelinesCreatePipelineResponsePipelineConfigDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType existingValue,
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
                        return global::G.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
