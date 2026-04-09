//HintName: G.JsonConverters.ConsensusThreadStatusVariant3ConsensusThreadStatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConsensusThreadStatusVariant3ConsensusThreadStatusNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ConsensusThreadStatusVariant3ConsensusThreadStatus?>
    {
        /// <inheritdoc />
        public override global::G.ConsensusThreadStatusVariant3ConsensusThreadStatus? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ConsensusThreadStatusVariant3ConsensusThreadStatus? existingValue,
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
                        return global::G.ConsensusThreadStatusVariant3ConsensusThreadStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ConsensusThreadStatusVariant3ConsensusThreadStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ConsensusThreadStatusVariant3ConsensusThreadStatus?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ConsensusThreadStatusVariant3ConsensusThreadStatus? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ConsensusThreadStatusVariant3ConsensusThreadStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
