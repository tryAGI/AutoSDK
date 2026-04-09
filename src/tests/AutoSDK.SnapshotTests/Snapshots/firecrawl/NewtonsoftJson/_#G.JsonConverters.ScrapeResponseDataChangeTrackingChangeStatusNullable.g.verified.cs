//HintName: G.JsonConverters.ScrapeResponseDataChangeTrackingChangeStatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScrapeResponseDataChangeTrackingChangeStatusNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ScrapeResponseDataChangeTrackingChangeStatus?>
    {
        /// <inheritdoc />
        public override global::G.ScrapeResponseDataChangeTrackingChangeStatus? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ScrapeResponseDataChangeTrackingChangeStatus? existingValue,
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
                        return global::G.ScrapeResponseDataChangeTrackingChangeStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ScrapeResponseDataChangeTrackingChangeStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ScrapeResponseDataChangeTrackingChangeStatus?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ScrapeResponseDataChangeTrackingChangeStatus? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ScrapeResponseDataChangeTrackingChangeStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
